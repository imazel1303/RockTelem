using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockTelem
{    
    public partial class RockTelemForm : Form
    {
        private Thread APRSListnerThread;
        private volatile bool APRSListnerThreadEnabled;

        private StreamWriter logFileWriter;
        private string logFileDirectory = @"C:\RockTelem\";

        private int receivedFilteredPackets;
        private int receivedTotalPackets;

        private string[] testDataset;
        private int testDatasetProcessedCount;

        private int latitudeDegrees;
        private int latitudeMinutes;
        private double latitudeSeconds;
        private string latitudeCardinal;
        private int longitudeDegrees;
        private int longitudeMinutes;
        private double longitudeSeconds;
        private string longitudeCardinal;
        private int altitude;
        private int maxAltitude;
        private int drogueAltitude;
        private int mainAltitude;
        private int speed;
        private int maxSpeed;
        private double batteryVoltage;
        private double temperature;
        private bool drogueParachuteDeployed;
        private bool mainParachuteDeployed;
        private bool drogueParachuteContinuity;
        private bool mainParachuteContinuity;
        private bool GPSSignalValid;
        private bool altimeterUART;
        private bool launchDetected;
        private bool landingDetected;

        private SpeechSynthesizer speechSynth;
        private bool allowVoiceReadout = true;
        private int lastVoiceAltitude;

        public RockTelemForm()
        {
            InitializeComponent();

            speechSynth = new SpeechSynthesizer();
            speechSynth.SetOutputToDefaultAudioDevice();
            speechSynth.SelectVoice(speechSynth.GetInstalledVoices().Where(x => x.VoiceInfo.Gender == VoiceGender.Female).First().VoiceInfo.Name);
            speechSynth.SpeakCompleted += SpeechSynth_SpeakCompleted;
        }

        private void WriteToConsole(string textToWrite)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteToConsole), new object[] { textToWrite });
                return;
            }
            
            textBox_Console.AppendText(textToWrite);
            textBox_Console.AppendText(Environment.NewLine);

            if (checkBox_EnableLogging.Checked)
            {
                logFileWriter.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + ": " + textToWrite);
            }
        }

        private void UpdateDisplay()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateDisplay));
                return;
            }

            label_PositionLatitude.Text = String.Format("{0:00}° {1:00}' {2:00.00}\" {3}", latitudeDegrees, latitudeMinutes, latitudeSeconds, latitudeCardinal);
            label_PositionLongitude.Text = String.Format("{0:00}° {1:00}' {2:00.00}\" {3}", longitudeDegrees, longitudeMinutes, longitudeSeconds, longitudeCardinal);
            label_Altitude.Text = String.Format("{0} FT", altitude);
            label_MaxAltitude.Text = String.Format("{0} FT", maxAltitude);
            label_Speed.Text = String.Format("{0} MPH", speed);
            label_MaxSpeed.Text = String.Format("{0} MPH", maxSpeed);
            label_BatteryVoltage.Text = String.Format("{0:0.00} V", batteryVoltage);
            label_Temperature.Text = string.Format("{0:0.00} C", temperature);

            if(drogueParachuteContinuity && !drogueParachuteDeployed)
            {
                SetLabelColor(label_DrogueEvent, Color.Yellow);
            }
            else if(!drogueParachuteContinuity && drogueParachuteDeployed)
            {
                SetLabelColor(label_DrogueEvent, Color.Green);
            }
            else
            {
                SetLabelColor(label_DrogueEvent, Color.Red);
            }

            if (mainParachuteContinuity && !mainParachuteDeployed)
            {
                SetLabelColor(label_MainEvent, Color.Yellow);
            }
            else if (!mainParachuteContinuity && mainParachuteDeployed)
            {
                SetLabelColor(label_MainEvent, Color.Green);
            }
            else
            {
                SetLabelColor(label_MainEvent, Color.Red);
            }

            SetLabelColor(label_GPSStatus, GPSSignalValid);
            SetLabelColor(label_AltimeterStatus, altimeterUART);
            SetLabelColor(label_LaunchDetected, launchDetected);
            SetLabelColor(label_LandingDetected, landingDetected);
        }

        private void SetLabelColor(Label label, bool setActive)
        {
            if (setActive)
            {
                SetLabelColor(label, Color.Green);
            }
            else
            {
                SetLabelColor(label, Color.Red);
            }
        }

        private void SetLabelColor(Label label, Color color)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Label, Color>(SetLabelColor), new object[] { label, color });
                return;
            }

            label.ForeColor = color;
        }

        private void SetGUIState(bool lockGui)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<bool>(SetGUIState), new object[] { lockGui });
                return;
            }

            textBox_Callsign.Enabled = !lockGui;
            textBox_SSID.Enabled = !lockGui;
            textBox_IPAddress.Enabled = !lockGui;
            textBox_Port.Enabled = !lockGui;
            checkBox_EnableLogging.Enabled = !lockGui;
            checkBox_LogAllPackets.Enabled = !lockGui;
            button_Connect.Enabled = !lockGui;
            button_Disconnect.Enabled = lockGui;
        }

        private void ResetTelemetryValues()
        {
            latitudeDegrees = 0;
            latitudeMinutes = 0;
            latitudeSeconds = 0;
            latitudeCardinal = "N";
            longitudeDegrees = 0;
            longitudeMinutes = 0;
            longitudeSeconds = 0;
            longitudeCardinal = "W";
            altitude = 0;
            maxAltitude = 0;
            drogueAltitude = 0;
            mainAltitude = 0;
            lastVoiceAltitude = 0;
            speed = 0;
            maxSpeed = 0;
            batteryVoltage = 0;
            temperature = 0;
            drogueParachuteDeployed = false;
            mainParachuteDeployed = false;
            drogueParachuteContinuity = false;
            mainParachuteContinuity = false;
            GPSSignalValid = false;
            altimeterUART = false;
            launchDetected = false;
            landingDetected = false;

            UpdateDisplay();
        }

        private void ListenForAPRSPackets()
        {
            AX25Address APRSStation = new AX25Address(textBox_Callsign.Text, Convert.ToInt32(textBox_SSID.Text));

            StartLogFile(APRSStation);
            SetGUIState(true);
            WriteToConsole("KISS TNC listener started.");

            string kissAddress = textBox_IPAddress.Text;
            int kissPort = Convert.ToInt32(textBox_Port.Text);

            byte[] receivedBytes;
            receivedFilteredPackets = 0;
            receivedTotalPackets = 0;

            TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect(kissAddress, kissPort);
                WriteToConsole(string.Format("Connected to KISS TNC at {0} port {1}.", kissAddress, kissPort.ToString()));
            }
            catch (Exception error)
            {
                WriteToConsole(error.Message);
            }

            while (APRSListnerThreadEnabled && IsTCPClientEstablished(tcpClient))
            {
                try
                {
                    NetworkStream networkStream = tcpClient.GetStream();
                    if (networkStream.DataAvailable)
                    {
                        receivedBytes = new byte[tcpClient.ReceiveBufferSize];
                        networkStream.Read(receivedBytes, 0, tcpClient.ReceiveBufferSize);

                        byte[][] KISSPackets = APRS.SplitKISSPackets(receivedBytes);

                        foreach (byte[] KISSPacket in KISSPackets)
                        {
                            APRSPacket currentAPRSPacket = APRS.ParseKISSPacket(KISSPacket);
                            bool matchesFilter = false;
                            receivedTotalPackets++;

                            // Filter packets for those containing RockTelem relevent data.
                            if (currentAPRSPacket.Source == APRSStation && currentAPRSPacket.GetDataType() == APRSDataType.PositionWithoutTimestampWithAPRSMessaging)
                            {
                                matchesFilter = true;
                                receivedFilteredPackets++;
                                ProcessRockTelemPacket(currentAPRSPacket);
                                ResetWatchdog();
                            }

                            if (matchesFilter || checkBox_LogAllPackets.Checked)
                            {
                                WriteToConsole(currentAPRSPacket.ToString());
                            }

                            toolStripStatusLabel_ReceivedPacketCount.Text = String.Format("{0}/{1}", receivedFilteredPackets, receivedTotalPackets);
                        }
                    }
                }
                catch (Exception error)
                {
                    WriteToConsole(error.Message);
                }
            }

            try
            {
                tcpClient.Close();
                WriteToConsole("Disconnected from KISS TNC.");
            }
            catch (Exception error)
            {
                WriteToConsole(error.Message);
            }

            WriteToConsole("KISS TNC listener stopped.");
            SetGUIState(false);
            EndLogFile();
        }

        private void StartLogFile(AX25Address APRSStation)
        {
            if (checkBox_EnableLogging.Checked)
            {
                string logFileName = "RockTelemLog_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".txt";
                Directory.CreateDirectory(logFileDirectory);
                logFileWriter = File.CreateText(logFileDirectory + logFileName);
                logFileWriter.WriteLine("RockTelem v0.1 log file created: {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
                logFileWriter.WriteLine("APRS Station: {0}", APRSStation.ToString());
                logFileWriter.WriteLine("KISS TNC: {0}:{1}", textBox_IPAddress.Text, textBox_Port.Text);
                logFileWriter.WriteLine("Log All Packets: {0}", checkBox_LogAllPackets.Checked);
                logFileWriter.WriteLine(Environment.NewLine);
            }
        }

        private void EndLogFile()
        {
            if (checkBox_EnableLogging.Checked)
            {
                logFileWriter.WriteLine(Environment.NewLine);
                logFileWriter.WriteLine("END OF LOG FILE");
                logFileWriter.Close();
            }
        }

        private void ProcessRockTelemPacket(APRSPacket rockTelemPacket)
        {
            // APRS latitude is formatted as DDMM.MM.  Parse and format as DD° MM' SS".
            latitudeDegrees = Convert.ToInt32(rockTelemPacket.InformationField.Substring(1, 2));
            latitudeMinutes = Convert.ToInt32(rockTelemPacket.InformationField.Substring(3, 2));
            latitudeSeconds = Convert.ToInt32(rockTelemPacket.InformationField.Substring(6, 2)) * 60d / 100d;
            latitudeCardinal = rockTelemPacket.InformationField.Substring(8, 1);

            // APRS longitude is formatted as DDDMM.MM.  Parse and format as DDD° MM' SS".
            longitudeDegrees = Convert.ToInt32(rockTelemPacket.InformationField.Substring(10, 3));
            longitudeMinutes = Convert.ToInt32(rockTelemPacket.InformationField.Substring(13, 2));
            longitudeSeconds = Convert.ToInt32(rockTelemPacket.InformationField.Substring(16, 2)) * 60d / 100d;
            longitudeCardinal = rockTelemPacket.InformationField.Substring(18, 1);

            altitude = Convert.ToInt32(rockTelemPacket.InformationField.Substring(20, 5));
            speed = Convert.ToInt32(rockTelemPacket.InformationField.Substring(25, 4));

            if (altitude > maxAltitude)
            {
                maxAltitude = altitude;
            }
            if(speed > maxSpeed)
            {
                maxSpeed = speed;
            }

            // Battery voltage and temperature scaled x 100.
            batteryVoltage = Convert.ToInt32(rockTelemPacket.InformationField.Substring(29, 4)) / 100d;
            temperature = Convert.ToInt32(rockTelemPacket.InformationField.Substring(33, 4)) / 100d;

            drogueParachuteDeployed = rockTelemPacket.InformationField.Substring(37, 1) == "D";
            mainParachuteDeployed = rockTelemPacket.InformationField.Substring(38, 1) == "M";
            drogueParachuteContinuity = rockTelemPacket.InformationField.Substring(37, 1) == "d";
            mainParachuteContinuity = rockTelemPacket.InformationField.Substring(38, 1) == "m";
            GPSSignalValid = rockTelemPacket.InformationField.Substring(39, 1) == "1";
            altimeterUART = rockTelemPacket.InformationField.Substring(40, 1) == "1";
            launchDetected = rockTelemPacket.InformationField.Substring(41, 1) == "1";
            landingDetected = rockTelemPacket.InformationField.Substring(42, 1) == "1";

            // Detect drogue deployement
            if (drogueParachuteDeployed && drogueAltitude == 0)
            {
                drogueAltitude = altitude;
                DrogueDeploymentVoiceReport();
            }

            // Detect main deployment
            if (mainParachuteDeployed && mainAltitude == 0)
            {
                mainAltitude = altitude;
                MainDeploymentVoiceReport();
            }

            if (mainParachuteDeployed)
            {
                // Read out altitude every 100 ft on the way down
                int currentVoiceAltitude = (altitude / 100 + 1) * 100;
                if (currentVoiceAltitude < lastVoiceAltitude)
                {
                    lastVoiceAltitude = altitude;
                    MidFlightAltitudeVoiceReport(currentVoiceAltitude);
                }
            }
            else if (drogueParachuteDeployed)
            {
                // Read out altitude every 1000 ft on the way down
                int currentVoiceAltitude = (altitude / 1000 + 1) * 1000;
                if (currentVoiceAltitude < lastVoiceAltitude)
                {
                    lastVoiceAltitude = altitude;
                    MidFlightAltitudeVoiceReport(currentVoiceAltitude);
                }
            }
            else
            {
                // Read out altitude every 1000 ft on the way up
                int currentVoiceAltitude = altitude / 1000 * 1000;
                if (currentVoiceAltitude > lastVoiceAltitude)
                {
                    lastVoiceAltitude = altitude;
                    MidFlightAltitudeVoiceReport(currentVoiceAltitude);
                }
            }

            UpdateDisplay();
        }

        private void DrogueDeploymentVoiceReport()
        {
            if (checkBox_EnableVoiceReadout.Checked)
            {
                allowVoiceReadout = false;

                string report = String.Format("Drogue deployed. Maximum altitude was {0} feet. Maximum speed was {1} miles per hour.", maxAltitude, maxSpeed);
                speechSynth.SpeakAsync(report);
            }
        }

        private void MainDeploymentVoiceReport()
        {
            if (checkBox_EnableVoiceReadout.Checked)
            {
                allowVoiceReadout = false;

                string report = String.Format("Main chute deployed near {0} feet.", mainAltitude);
                speechSynth.SpeakAsync(report);
            }
        }

        private void MidFlightAltitudeVoiceReport(int altitude)
        {
            if (allowVoiceReadout && checkBox_EnableVoiceReadout.Checked)
            {
                allowVoiceReadout = false;
                speechSynth.SpeakAsync(altitude.ToString());
            }
        }

        private void StartAPRSListner()
        {
            APRSListnerThread = new Thread(ListenForAPRSPackets);
            APRSListnerThread.IsBackground = true;
            APRSListnerThreadEnabled = true;
            APRSListnerThread.Start();
        }

        private void StopAPRSListner()
        {
            APRSListnerThreadEnabled = false;
        }

        private bool IsTCPClientEstablished(TcpClient tcpClient)
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections().Where(x => x.LocalEndPoint.Equals(tcpClient.Client.LocalEndPoint) && x.RemoteEndPoint.Equals(tcpClient.Client.RemoteEndPoint)).ToArray();

            if (tcpConnections != null && tcpConnections.Length > 0)
            {
                TcpState stateOfConnection = tcpConnections.First().State;
                if (stateOfConnection == TcpState.Established)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void PlaybackTestDataset()
        {
            if (openFileDialog_TestDatset.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_TestDatset.FileName;
                testDataset = File.ReadAllLines(filePath, Encoding.UTF8);
                testDatasetProcessedCount = 0;

                StartLogFile(new AX25Address("N0CALL", 0));
                SetGUIState(true);
                WriteToConsole("Starting test dataset.");
                timer_TestDatasetPlayback.Start();
            }
        }
        private void StopTestDatasetPlayback()
        {
            if (timer_TestDatasetPlayback.Enabled)
            {
                timer_TestDatasetPlayback.Stop();
                WriteToConsole("Test dataset end.");
                SetGUIState(false);
                EndLogFile();
            }
        }

        private void ResetWatchdog()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(ResetWatchdog));
                return;
            }

            SetLabelColor(label_LinkStatus, true);

            timer_LinkWatchdog.Stop();
            timer_LinkWatchdog.Start();
        }

        private void button_Connect_MouseUp(object sender, MouseEventArgs e)
        {
            ResetTelemetryValues();
            if (e.Button == MouseButtons.Right)
            {
                PlaybackTestDataset();
            }
            else
            {
                StartAPRSListner();
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            StopAPRSListner();
            StopTestDatasetPlayback();
        }

        private void timer_TestDatasetPlayback_Tick(object sender, EventArgs e)
        {
            if (testDatasetProcessedCount < testDataset.Length)
            {
                APRSPacket tempPacket = new APRSPacket();
                tempPacket.InformationField = testDataset[testDatasetProcessedCount];
                ProcessRockTelemPacket(tempPacket);
                ResetWatchdog();
                WriteToConsole(tempPacket.InformationField);
                testDatasetProcessedCount++;
            }
            else
            {
                StopTestDatasetPlayback();
            }
        }

        private void timer_LinkWatchdog_Tick(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<object, EventArgs>(timer_LinkWatchdog_Tick), new object[] { sender, e });
                return;
            }

            // Link watchdog expired
            timer_LinkWatchdog.Stop();
            SetLabelColor(label_LinkStatus, false);
            SetLabelColor(label_GPSStatus, false);
            SetLabelColor(label_AltimeterStatus, false);
        }

        private void SpeechSynth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            allowVoiceReadout = true;
        }
    }
}
