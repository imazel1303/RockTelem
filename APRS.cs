using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockTelem.APRS;

namespace RockTelem
{    
    internal enum APRSDataType
    {
        PositionWithoutTimestampNoAPRSMessaging,
        PeetBrosUIIWeatherStation,
        RawGPSDataOrUltimeter2000,
        AgreloDFJrMicroFinder,
        OldMicEDataCurrentTMD700,
        Item,
        InvalidDataOrTestData,
        PositionWithTimestampNoAPRSMessaging,
        Message,
        Object,
        StationCapabilities,
        PositionWithoutTimestampWithAPRSMessaging,
        Status,
        Query,
        PositionWithTimestampWithAPRSMessaging,
        Telemetry,
        MaidenheadGridLocatorBeacon,
        WeatherReportWithoutPosition,
        CurrentMicENotTMD700,
        UserDefinedAPRSPacket,
        ThirdPartyTraffic,
        undefined
    }

    internal class AX25Address
    {
        public string Callsign;
        public int SSID;

        public AX25Address(string callsign, int ssid)
        {
            Callsign = callsign;
            SSID = ssid;
        }
        public override string ToString()
        {
            if (SSID == 0)
            {
                return Callsign;
            }
            else
            {
                return string.Format("{0}-{1}", Callsign, SSID);
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(AX25Address left, AX25Address right)
        {
            return left.Callsign == right.Callsign && left.SSID == right.SSID;
        }
        public static bool operator !=(AX25Address left, AX25Address right)
        {
            return left.Callsign != right.Callsign || left.SSID != right.SSID;
        }

    }

    internal class APRSPacket
    {
        public AX25Address Destination;
        public AX25Address Source;
        public List<AX25Address> Digipeaters;
        public string InformationField;

        public override string ToString()
        {
            // Format kiss packet into TNC2 format
            return string.Format("{0}>{1},{2}:{3}", Source.ToString(), Destination.ToString(), string.Join(",", Digipeaters), InformationField);
        }
        public APRSDataType GetDataType()
        {
            APRSDataType packetDataType = APRSDataType.undefined;
            DataTypeTable.TryGetValue(InformationField.ToCharArray()[0], out packetDataType);
            return packetDataType;
        }
    }
    internal class APRS
    {
        const byte KISS_FEND = 0xc0;
        const byte KISS_FESC = 0xdb;
        const byte KISS_TFEND = 0xdc;
        const byte KISS_TFESC = 0xdd;

        const byte KISS_CMD_DATAFRAME0 = 0x00;
        const byte KISS_CMD_TXDELAY = 0x01;
        const byte KISS_CMD_TXTAIL = 0x04;
        const byte KISS_CMD_SETHARDWARE = 0x06;

        internal static readonly Dictionary<char, APRSDataType> DataTypeTable = new Dictionary<char, APRSDataType>
        {
            { '!' , APRSDataType.PositionWithoutTimestampNoAPRSMessaging },
            { '#' , APRSDataType.PeetBrosUIIWeatherStation },
            { '$' , APRSDataType.RawGPSDataOrUltimeter2000 },
            { '%' , APRSDataType.AgreloDFJrMicroFinder },
            { '\'' , APRSDataType.OldMicEDataCurrentTMD700 },
            { ')' , APRSDataType.Item },
            { '*' , APRSDataType.PeetBrosUIIWeatherStation },
            { ',' , APRSDataType.InvalidDataOrTestData },
            { '/' , APRSDataType.PositionWithTimestampNoAPRSMessaging },
            { ':' , APRSDataType.Message },
            { ';' , APRSDataType.Object },
            { '<' , APRSDataType.StationCapabilities },
            { '=' , APRSDataType.PositionWithoutTimestampWithAPRSMessaging },
            { '>' , APRSDataType.Status },
            { '?' , APRSDataType.Query },
            { '@' , APRSDataType.PositionWithTimestampWithAPRSMessaging },
            { 'T' , APRSDataType.Telemetry },
            { '[' , APRSDataType.MaidenheadGridLocatorBeacon },
            { '_' , APRSDataType.WeatherReportWithoutPosition },
            { '`' , APRSDataType.CurrentMicENotTMD700 },
            { '{' , APRSDataType.UserDefinedAPRSPacket },
            { '}' , APRSDataType.ThirdPartyTraffic }
        };

        internal static APRSPacket ParseKISSPacket(byte[] kissPacket)
        {
            // Filter for only KISS data frame command.  First non-frame-end byte in KISS packet contains command code.
            if (kissPacket[0] == KISS_CMD_DATAFRAME0)
            {
                int bytesProcessed = 1; // Track bytes processed.  First byte processed was KISS packet command code.
                int addressLength = 7;  // Length of AX.25 addressed are 7 bytes.

                // Parse destination address
                byte[] destinationAddressBytes = new byte[addressLength];
                Array.Copy(kissPacket, bytesProcessed, destinationAddressBytes, 0, addressLength);
                AX25Address destinationAddress = ParseAX25Address(destinationAddressBytes);
                bytesProcessed = bytesProcessed + addressLength;

                // Parse source address
                byte[] sourceAddressBytes = new byte[addressLength];
                Array.Copy(kissPacket, bytesProcessed, sourceAddressBytes, 0, addressLength);
                AX25Address sourceAddress = ParseAX25Address(sourceAddressBytes);
                bytesProcessed = bytesProcessed + addressLength;

                // After source address up to eight 7-byte digipeater addresses may be present.
                // Per APRS specification, last digipeater address will be followed by 0x03 then 0xF0.
                // Address will only contain alphanumeric characters, so 0x03 and 0xF0 will never be part of an address.
                List<AX25Address> digipeaterAddresses = new List<AX25Address>();
                for (int i = 0; i < 8; i++)
                {
                    // Check if end of digipeater addresses.
                    if (kissPacket[bytesProcessed] == 0x03 && kissPacket[bytesProcessed + 1] == 0xF0)
                    {
                        bytesProcessed = bytesProcessed + 2;
                        break;
                    }

                    // Parse digipeater address
                    byte[] digipeaterAddressBytes = new byte[addressLength];
                    Array.Copy(kissPacket, bytesProcessed, digipeaterAddressBytes, 0, addressLength);
                    digipeaterAddresses.Add(ParseAX25Address(digipeaterAddressBytes));
                    bytesProcessed = bytesProcessed + addressLength;
                }

                // Remainder of kiss packet is APRS information field
                int remainingBytes = kissPacket.Length - bytesProcessed;
                byte[] APRSInfoFieldBytes = new byte[remainingBytes];
                Array.Copy(kissPacket, bytesProcessed, APRSInfoFieldBytes, 0, remainingBytes);
                bytesProcessed = bytesProcessed + remainingBytes;
                string APRSInfoField = Encoding.UTF8.GetString(APRSInfoFieldBytes);

                return new APRSPacket()
                {
                    Destination = destinationAddress,
                    Source = sourceAddress,
                    Digipeaters = digipeaterAddresses,
                    InformationField = APRSInfoField
                };
            }
            else
            {
                throw new InvalidOperationException("Only KISS packets with the DATA FRAME command code can be processed.");
            }
        }

        internal static byte[][] SplitKISSPackets(byte[] packetBytes)
        {
            // Each recieved packet is framed by the KISS_FEND byte
            List<byte[]> kissPackets = new List<byte[]>();
            List<byte> tempPacket = new List<byte>();
            for (int i = 0; i < packetBytes.Length; i++)
            {
                if (packetBytes[i] == KISS_FEND && tempPacket.Count > 0)
                {
                    kissPackets.Add(tempPacket.ToArray());
                    tempPacket.Clear();
                }
                else if (packetBytes[i] != KISS_FEND)
                {
                    tempPacket.Add(packetBytes[i]);
                }

                // Escape for loop if no more KISS_FEND bytes left (no packets remaining)
                if (Array.FindLastIndex<byte>(packetBytes, b => b.Equals(KISS_FEND)) < i)
                {
                    break;
                }
            }

            return kissPackets.ToArray();
        }

        internal static AX25Address ParseAX25Address(byte[] address)
        {
            if (address.Length != 7)
            {
                throw new ArgumentException("Address must be exactly 7 bytes to comply with the AX.25 and APRS specifications.");
            }

            // AX.25 addresses octets contain an "extension bit" in the LSB position that is not relevant to the address data.
            for (int i = 0; i < 7; i++)
            {
                address[i] = (byte)(address[i] >> 1);
            }

            // First 6 bytes of AX.25 address are callsign.  Last byte is SSID.
            byte[] callsign = new byte[6];
            Array.Copy(address, callsign, 6);

            return new AX25Address(Encoding.UTF8.GetString(callsign).Trim(' '), 0b00001111 & address[6]);  // AX.25 SSID format is CRRSSID0, but SSID has already been shifted 1 bit to the right.
        }
    }
}
