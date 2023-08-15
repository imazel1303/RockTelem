# RockTelem
APRS Rocketry Telemetry Display

RockTelem is the real time display for high power rocket telemetry and location data transmitted from the [RocketAPRS](https://github.com/imazel1303/RocketAPRS) transmitter.  It implements the [KISS Protocol](https://www.ax25.net/kiss.aspx) to interface with a [TNC](https://en.wikipedia.org/wiki/Terminal_node_controller) to display and log specially formatted APRS packets.  In addition, this project includes a small library (APRS.cs) for extracting data from the KISS TNC APRS packet frame.

## Features
- Real time display of [RocketAPRS](https://github.com/imazel1303/RocketAPRS) data
- Voice readout of altitude, deployment events, and maximum speed
- Connection to a networked TNC (compatible with [Dire Wolf](https://github.com/wb2osz/direwolf))
- Packet filtering based on amateur radio callsign and SSID
- Packet logging
- Test mode for replaying simulated flights
- Runs on Windows 10 and Windows 11

## Screenshots
![image](https://github.com/imazel1303/RockTelem/assets/141973761/326afa3e-3121-4b9f-a2f0-3438ac172144)

## Packet Format
### KISS TNC APRS Packet Frame
![image](https://github.com/imazel1303/RockTelem/assets/141973761/e73a057e-1e98-46b3-9b05-56ac510440be)

### RockTelem APRS Information Field
![image](https://github.com/imazel1303/RockTelem/assets/141973761/8ba2b3bd-8c97-48b0-8226-9136d6e41de2)
![image](https://github.com/imazel1303/RockTelem/assets/141973761/bb6d4b16-280d-4482-b3c4-703fbbc7220f)
