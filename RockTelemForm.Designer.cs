namespace RockTelem
{
    partial class RockTelemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_About = new System.Windows.Forms.Label();
            this.label_URL = new System.Windows.Forms.Label();
            this.groupBox_APRSStation = new System.Windows.Forms.GroupBox();
            this.textBox_SSID = new System.Windows.Forms.TextBox();
            this.label_SSID = new System.Windows.Forms.Label();
            this.textBox_Callsign = new System.Windows.Forms.TextBox();
            this.label_Callsign = new System.Windows.Forms.Label();
            this.groupBox_KISSTNCControl = new System.Windows.Forms.GroupBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_IPAddress = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_IPAddress = new System.Windows.Forms.Label();
            this.groupBox_RockTelemControl = new System.Windows.Forms.GroupBox();
            this.checkBox_LogAllPackets = new System.Windows.Forms.CheckBox();
            this.checkBox_EnableLogging = new System.Windows.Forms.CheckBox();
            this.checkBox_EnableVoiceReadout = new System.Windows.Forms.CheckBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Altitude = new System.Windows.Forms.Label();
            this.label_MaxAltitude = new System.Windows.Forms.Label();
            this.label_PositionLatitude = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Speed = new System.Windows.Forms.Label();
            this.label_MaxSpeed = new System.Windows.Forms.Label();
            this.label_PositionLongitude = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_DrogueEvent = new System.Windows.Forms.Label();
            this.label_MainEvent = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_LinkStatus = new System.Windows.Forms.Label();
            this.label_GPSStatus = new System.Windows.Forms.Label();
            this.label_AltimeterStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_LaunchDetected = new System.Windows.Forms.Label();
            this.label_LandingDetected = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_BatteryVoltage = new System.Windows.Forms.Label();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_ReceivedPacketCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_TestDatasetPlayback = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_TestDatset = new System.Windows.Forms.OpenFileDialog();
            this.timer_LinkWatchdog = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox_APRSStation.SuspendLayout();
            this.groupBox_KISSTNCControl.SuspendLayout();
            this.groupBox_RockTelemControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_About);
            this.flowLayoutPanel1.Controls.Add(this.label_URL);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_APRSStation);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_KISSTNCControl);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_RockTelemControl);
            this.flowLayoutPanel1.Controls.Add(this.button_Connect);
            this.flowLayoutPanel1.Controls.Add(this.button_Disconnect);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 530);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label_About
            // 
            this.label_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_About.Location = new System.Drawing.Point(4, 0);
            this.label_About.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(267, 123);
            this.label_About.TabIndex = 8;
            this.label_About.Text = "RockTelem v0.1\r\nAPRS Rocketry Telemetry Display";
            this.label_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_URL
            // 
            this.label_URL.Location = new System.Drawing.Point(4, 123);
            this.label_URL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(267, 49);
            this.label_URL.TabIndex = 9;
            this.label_URL.Text = "www.isaacmazel.com";
            this.label_URL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_APRSStation
            // 
            this.groupBox_APRSStation.Controls.Add(this.textBox_SSID);
            this.groupBox_APRSStation.Controls.Add(this.label_SSID);
            this.groupBox_APRSStation.Controls.Add(this.textBox_Callsign);
            this.groupBox_APRSStation.Controls.Add(this.label_Callsign);
            this.groupBox_APRSStation.Location = new System.Drawing.Point(4, 180);
            this.groupBox_APRSStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_APRSStation.Name = "groupBox_APRSStation";
            this.groupBox_APRSStation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_APRSStation.Size = new System.Drawing.Size(267, 92);
            this.groupBox_APRSStation.TabIndex = 5;
            this.groupBox_APRSStation.TabStop = false;
            this.groupBox_APRSStation.Text = "APRS Station";
            // 
            // textBox_SSID
            // 
            this.textBox_SSID.Location = new System.Drawing.Point(96, 57);
            this.textBox_SSID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_SSID.Name = "textBox_SSID";
            this.textBox_SSID.Size = new System.Drawing.Size(132, 22);
            this.textBox_SSID.TabIndex = 3;
            this.textBox_SSID.Text = "11";
            // 
            // label_SSID
            // 
            this.label_SSID.AutoSize = true;
            this.label_SSID.Location = new System.Drawing.Point(11, 60);
            this.label_SSID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SSID.Name = "label_SSID";
            this.label_SSID.Size = new System.Drawing.Size(38, 16);
            this.label_SSID.TabIndex = 2;
            this.label_SSID.Text = "SSID";
            // 
            // textBox_Callsign
            // 
            this.textBox_Callsign.Location = new System.Drawing.Point(96, 25);
            this.textBox_Callsign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Callsign.Name = "textBox_Callsign";
            this.textBox_Callsign.Size = new System.Drawing.Size(132, 22);
            this.textBox_Callsign.TabIndex = 1;
            this.textBox_Callsign.Text = "N0CALL";
            // 
            // label_Callsign
            // 
            this.label_Callsign.AutoSize = true;
            this.label_Callsign.Location = new System.Drawing.Point(11, 28);
            this.label_Callsign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Callsign.Name = "label_Callsign";
            this.label_Callsign.Size = new System.Drawing.Size(55, 16);
            this.label_Callsign.TabIndex = 0;
            this.label_Callsign.Text = "Callsign";
            // 
            // groupBox_KISSTNCControl
            // 
            this.groupBox_KISSTNCControl.Controls.Add(this.textBox_Port);
            this.groupBox_KISSTNCControl.Controls.Add(this.textBox_IPAddress);
            this.groupBox_KISSTNCControl.Controls.Add(this.label_Port);
            this.groupBox_KISSTNCControl.Controls.Add(this.label_IPAddress);
            this.groupBox_KISSTNCControl.Location = new System.Drawing.Point(4, 280);
            this.groupBox_KISSTNCControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_KISSTNCControl.Name = "groupBox_KISSTNCControl";
            this.groupBox_KISSTNCControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_KISSTNCControl.Size = new System.Drawing.Size(267, 92);
            this.groupBox_KISSTNCControl.TabIndex = 6;
            this.groupBox_KISSTNCControl.TabStop = false;
            this.groupBox_KISSTNCControl.Text = "KISS TNC Config";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(96, 57);
            this.textBox_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(132, 22);
            this.textBox_Port.TabIndex = 4;
            this.textBox_Port.Text = "8001";
            // 
            // textBox_IPAddress
            // 
            this.textBox_IPAddress.Location = new System.Drawing.Point(96, 25);
            this.textBox_IPAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_IPAddress.Name = "textBox_IPAddress";
            this.textBox_IPAddress.Size = new System.Drawing.Size(132, 22);
            this.textBox_IPAddress.TabIndex = 3;
            this.textBox_IPAddress.Text = "127.0.0.1";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(11, 60);
            this.label_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(31, 16);
            this.label_Port.TabIndex = 2;
            this.label_Port.Text = "Port";
            // 
            // label_IPAddress
            // 
            this.label_IPAddress.AutoSize = true;
            this.label_IPAddress.Location = new System.Drawing.Point(11, 28);
            this.label_IPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IPAddress.Name = "label_IPAddress";
            this.label_IPAddress.Size = new System.Drawing.Size(73, 16);
            this.label_IPAddress.TabIndex = 0;
            this.label_IPAddress.Text = "IP Address";
            // 
            // groupBox_RockTelemControl
            // 
            this.groupBox_RockTelemControl.Controls.Add(this.checkBox_LogAllPackets);
            this.groupBox_RockTelemControl.Controls.Add(this.checkBox_EnableLogging);
            this.groupBox_RockTelemControl.Controls.Add(this.checkBox_EnableVoiceReadout);
            this.groupBox_RockTelemControl.Location = new System.Drawing.Point(4, 380);
            this.groupBox_RockTelemControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_RockTelemControl.Name = "groupBox_RockTelemControl";
            this.groupBox_RockTelemControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_RockTelemControl.Size = new System.Drawing.Size(267, 111);
            this.groupBox_RockTelemControl.TabIndex = 7;
            this.groupBox_RockTelemControl.TabStop = false;
            this.groupBox_RockTelemControl.Text = "RockTelem Config";
            // 
            // checkBox_LogAllPackets
            // 
            this.checkBox_LogAllPackets.AutoSize = true;
            this.checkBox_LogAllPackets.Location = new System.Drawing.Point(15, 78);
            this.checkBox_LogAllPackets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_LogAllPackets.Name = "checkBox_LogAllPackets";
            this.checkBox_LogAllPackets.Size = new System.Drawing.Size(122, 20);
            this.checkBox_LogAllPackets.TabIndex = 3;
            this.checkBox_LogAllPackets.Text = "Log All Packets";
            this.checkBox_LogAllPackets.UseVisualStyleBackColor = true;
            // 
            // checkBox_EnableLogging
            // 
            this.checkBox_EnableLogging.AutoSize = true;
            this.checkBox_EnableLogging.Checked = true;
            this.checkBox_EnableLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EnableLogging.Location = new System.Drawing.Point(15, 50);
            this.checkBox_EnableLogging.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_EnableLogging.Name = "checkBox_EnableLogging";
            this.checkBox_EnableLogging.Size = new System.Drawing.Size(125, 20);
            this.checkBox_EnableLogging.TabIndex = 2;
            this.checkBox_EnableLogging.Text = "Write Log to File";
            this.checkBox_EnableLogging.UseVisualStyleBackColor = true;
            // 
            // checkBox_EnableVoiceReadout
            // 
            this.checkBox_EnableVoiceReadout.AutoSize = true;
            this.checkBox_EnableVoiceReadout.Checked = true;
            this.checkBox_EnableVoiceReadout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EnableVoiceReadout.Location = new System.Drawing.Point(15, 23);
            this.checkBox_EnableVoiceReadout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_EnableVoiceReadout.Name = "checkBox_EnableVoiceReadout";
            this.checkBox_EnableVoiceReadout.Size = new System.Drawing.Size(165, 20);
            this.checkBox_EnableVoiceReadout.TabIndex = 1;
            this.checkBox_EnableVoiceReadout.Text = "Enable Voice Readout";
            this.checkBox_EnableVoiceReadout.UseVisualStyleBackColor = true;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(4, 499);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(127, 28);
            this.button_Connect.TabIndex = 6;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Connect_MouseUp);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(139, 499);
            this.button_Disconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(127, 28);
            this.button_Disconnect.TabIndex = 7;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.45249F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Console, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.35426F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.64574F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_Console
            // 
            this.textBox_Console.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Console.Location = new System.Drawing.Point(293, 420);
            this.textBox_Console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Console.Size = new System.Drawing.Size(875, 114);
            this.textBox_Console.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(293, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.0099F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.9901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 404);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label_Altitude);
            this.flowLayoutPanel2.Controls.Add(this.label_MaxAltitude);
            this.flowLayoutPanel2.Controls.Add(this.label_PositionLatitude);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(432, 293);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label_Altitude
            // 
            this.label_Altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label_Altitude.ForeColor = System.Drawing.Color.White;
            this.label_Altitude.Location = new System.Drawing.Point(4, 0);
            this.label_Altitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Altitude.Name = "label_Altitude";
            this.label_Altitude.Size = new System.Drawing.Size(428, 96);
            this.label_Altitude.TabIndex = 0;
            this.label_Altitude.Text = "0 FT";
            this.label_Altitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_MaxAltitude
            // 
            this.label_MaxAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label_MaxAltitude.ForeColor = System.Drawing.Color.White;
            this.label_MaxAltitude.Location = new System.Drawing.Point(4, 96);
            this.label_MaxAltitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaxAltitude.Name = "label_MaxAltitude";
            this.label_MaxAltitude.Size = new System.Drawing.Size(428, 96);
            this.label_MaxAltitude.TabIndex = 3;
            this.label_MaxAltitude.Text = "0 FT";
            this.label_MaxAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PositionLatitude
            // 
            this.label_PositionLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PositionLatitude.ForeColor = System.Drawing.Color.White;
            this.label_PositionLatitude.Location = new System.Drawing.Point(4, 192);
            this.label_PositionLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PositionLatitude.Name = "label_PositionLatitude";
            this.label_PositionLatitude.Size = new System.Drawing.Size(428, 96);
            this.label_PositionLatitude.TabIndex = 2;
            this.label_PositionLatitude.Text = "00° 00\' 00.00\" N";
            this.label_PositionLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label_Speed);
            this.flowLayoutPanel3.Controls.Add(this.label_MaxSpeed);
            this.flowLayoutPanel3.Controls.Add(this.label_PositionLongitude);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(441, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(429, 293);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // label_Speed
            // 
            this.label_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label_Speed.ForeColor = System.Drawing.Color.White;
            this.label_Speed.Location = new System.Drawing.Point(0, 0);
            this.label_Speed.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(431, 96);
            this.label_Speed.TabIndex = 1;
            this.label_Speed.Text = "0 MPH";
            this.label_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_MaxSpeed
            // 
            this.label_MaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label_MaxSpeed.ForeColor = System.Drawing.Color.White;
            this.label_MaxSpeed.Location = new System.Drawing.Point(0, 96);
            this.label_MaxSpeed.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label_MaxSpeed.Name = "label_MaxSpeed";
            this.label_MaxSpeed.Size = new System.Drawing.Size(431, 96);
            this.label_MaxSpeed.TabIndex = 4;
            this.label_MaxSpeed.Text = "0 MPH";
            this.label_MaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PositionLongitude
            // 
            this.label_PositionLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PositionLongitude.ForeColor = System.Drawing.Color.White;
            this.label_PositionLongitude.Location = new System.Drawing.Point(0, 192);
            this.label_PositionLongitude.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label_PositionLongitude.Name = "label_PositionLongitude";
            this.label_PositionLongitude.Size = new System.Drawing.Size(431, 96);
            this.label_PositionLongitude.TabIndex = 3;
            this.label_PositionLongitude.Text = "000° 00\' 00.00\" W";
            this.label_PositionLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.label_DrogueEvent);
            this.flowLayoutPanel4.Controls.Add(this.label_MainEvent);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 301);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(868, 96);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // label_DrogueEvent
            // 
            this.label_DrogueEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label_DrogueEvent.ForeColor = System.Drawing.Color.Red;
            this.label_DrogueEvent.Location = new System.Drawing.Point(4, 0);
            this.label_DrogueEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DrogueEvent.Name = "label_DrogueEvent";
            this.label_DrogueEvent.Size = new System.Drawing.Size(227, 96);
            this.label_DrogueEvent.TabIndex = 0;
            this.label_DrogueEvent.Text = "DROGUE";
            this.label_DrogueEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_MainEvent
            // 
            this.label_MainEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label_MainEvent.ForeColor = System.Drawing.Color.Red;
            this.label_MainEvent.Location = new System.Drawing.Point(239, 0);
            this.label_MainEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MainEvent.Name = "label_MainEvent";
            this.label_MainEvent.Size = new System.Drawing.Size(141, 96);
            this.label_MainEvent.TabIndex = 1;
            this.label_MainEvent.Text = "MAIN";
            this.label_MainEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label_LinkStatus);
            this.flowLayoutPanel5.Controls.Add(this.label_GPSStatus);
            this.flowLayoutPanel5.Controls.Add(this.label_AltimeterStatus);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(387, 2);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(167, 96);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // label_LinkStatus
            // 
            this.label_LinkStatus.AutoSize = true;
            this.label_LinkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LinkStatus.ForeColor = System.Drawing.Color.Red;
            this.label_LinkStatus.Location = new System.Drawing.Point(3, 10);
            this.label_LinkStatus.Name = "label_LinkStatus";
            this.label_LinkStatus.Size = new System.Drawing.Size(107, 25);
            this.label_LinkStatus.TabIndex = 0;
            this.label_LinkStatus.Text = "Link Active";
            // 
            // label_GPSStatus
            // 
            this.label_GPSStatus.AutoSize = true;
            this.label_GPSStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_GPSStatus.ForeColor = System.Drawing.Color.Red;
            this.label_GPSStatus.Location = new System.Drawing.Point(3, 35);
            this.label_GPSStatus.Name = "label_GPSStatus";
            this.label_GPSStatus.Size = new System.Drawing.Size(103, 25);
            this.label_GPSStatus.TabIndex = 1;
            this.label_GPSStatus.Text = "GPS Valid";
            // 
            // label_AltimeterStatus
            // 
            this.label_AltimeterStatus.AutoSize = true;
            this.label_AltimeterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_AltimeterStatus.ForeColor = System.Drawing.Color.Red;
            this.label_AltimeterStatus.Location = new System.Drawing.Point(3, 60);
            this.label_AltimeterStatus.Name = "label_AltimeterStatus";
            this.label_AltimeterStatus.Size = new System.Drawing.Size(147, 25);
            this.label_AltimeterStatus.TabIndex = 2;
            this.label_AltimeterStatus.Text = "Altimeter UART";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label_LaunchDetected);
            this.flowLayoutPanel6.Controls.Add(this.label_LandingDetected);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(560, 2);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(197, 96);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // label_LaunchDetected
            // 
            this.label_LaunchDetected.AutoSize = true;
            this.label_LaunchDetected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LaunchDetected.ForeColor = System.Drawing.Color.Red;
            this.label_LaunchDetected.Location = new System.Drawing.Point(3, 10);
            this.label_LaunchDetected.Name = "label_LaunchDetected";
            this.label_LaunchDetected.Size = new System.Drawing.Size(160, 25);
            this.label_LaunchDetected.TabIndex = 1;
            this.label_LaunchDetected.Text = "Launch Detected";
            // 
            // label_LandingDetected
            // 
            this.label_LandingDetected.AutoSize = true;
            this.label_LandingDetected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LandingDetected.ForeColor = System.Drawing.Color.Red;
            this.label_LandingDetected.Location = new System.Drawing.Point(3, 35);
            this.label_LandingDetected.Name = "label_LandingDetected";
            this.label_LandingDetected.Size = new System.Drawing.Size(165, 25);
            this.label_LandingDetected.TabIndex = 2;
            this.label_LandingDetected.Text = "Landing Detected";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label_BatteryVoltage);
            this.flowLayoutPanel7.Controls.Add(this.label_Temperature);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(763, 2);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel7.Size = new System.Drawing.Size(99, 96);
            this.flowLayoutPanel7.TabIndex = 4;
            // 
            // label_BatteryVoltage
            // 
            this.label_BatteryVoltage.AutoSize = true;
            this.label_BatteryVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_BatteryVoltage.ForeColor = System.Drawing.Color.White;
            this.label_BatteryVoltage.Location = new System.Drawing.Point(3, 10);
            this.label_BatteryVoltage.Name = "label_BatteryVoltage";
            this.label_BatteryVoltage.Size = new System.Drawing.Size(69, 25);
            this.label_BatteryVoltage.TabIndex = 3;
            this.label_BatteryVoltage.Text = "0.00 V";
            // 
            // label_Temperature
            // 
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Temperature.ForeColor = System.Drawing.Color.White;
            this.label_Temperature.Location = new System.Drawing.Point(3, 35);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(70, 25);
            this.label_Temperature.TabIndex = 4;
            this.label_Temperature.Text = "0.00 C";
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ReceivedPacketCount});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 555);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip_Main.Size = new System.Drawing.Size(1176, 26);
            this.statusStrip_Main.SizingGrip = false;
            this.statusStrip_Main.TabIndex = 1;
            // 
            // toolStripStatusLabel_ReceivedPacketCount
            // 
            this.toolStripStatusLabel_ReceivedPacketCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_ReceivedPacketCount.Name = "toolStripStatusLabel_ReceivedPacketCount";
            this.toolStripStatusLabel_ReceivedPacketCount.Size = new System.Drawing.Size(31, 20);
            this.toolStripStatusLabel_ReceivedPacketCount.Text = "0/0";
            // 
            // timer_TestDatasetPlayback
            // 
            this.timer_TestDatasetPlayback.Interval = 500;
            this.timer_TestDatasetPlayback.Tick += new System.EventHandler(this.timer_TestDatasetPlayback_Tick);
            // 
            // openFileDialog_TestDatset
            // 
            this.openFileDialog_TestDatset.DefaultExt = "txt";
            this.openFileDialog_TestDatset.Filter = "RockTelem Test Datasets|*.csv";
            this.openFileDialog_TestDatset.Title = "Select a RockTelem test dataset file";
            // 
            // timer_LinkWatchdog
            // 
            this.timer_LinkWatchdog.Interval = 17500;
            this.timer_LinkWatchdog.Tick += new System.EventHandler(this.timer_LinkWatchdog_Tick);
            // 
            // RockTelemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 581);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1194, 628);
            this.MinimumSize = new System.Drawing.Size(1194, 628);
            this.Name = "RockTelemForm";
            this.Text = "RockTelem v0.1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox_APRSStation.ResumeLayout(false);
            this.groupBox_APRSStation.PerformLayout();
            this.groupBox_KISSTNCControl.ResumeLayout(false);
            this.groupBox_KISSTNCControl.PerformLayout();
            this.groupBox_RockTelemControl.ResumeLayout(false);
            this.groupBox_RockTelemControl.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_APRSStation;
        private System.Windows.Forms.TextBox textBox_SSID;
        private System.Windows.Forms.Label label_SSID;
        private System.Windows.Forms.TextBox textBox_Callsign;
        private System.Windows.Forms.Label label_Callsign;
        private System.Windows.Forms.GroupBox groupBox_KISSTNCControl;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_IPAddress;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_IPAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.GroupBox groupBox_RockTelemControl;
        private System.Windows.Forms.CheckBox checkBox_EnableVoiceReadout;
        private System.Windows.Forms.CheckBox checkBox_EnableLogging;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_PositionLongitude;
        private System.Windows.Forms.Label label_PositionLatitude;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label label_Altitude;
        private System.Windows.Forms.Label label_MainEvent;
        private System.Windows.Forms.Label label_DrogueEvent;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.CheckBox checkBox_LogAllPackets;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ReceivedPacketCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label_MaxAltitude;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label_MaxSpeed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label_LinkStatus;
        private System.Windows.Forms.Label label_GPSStatus;
        private System.Windows.Forms.Label label_AltimeterStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label_LaunchDetected;
        private System.Windows.Forms.Label label_LandingDetected;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label_BatteryVoltage;
        private System.Windows.Forms.Label label_Temperature;
        private System.Windows.Forms.Timer timer_TestDatasetPlayback;
        private System.Windows.Forms.OpenFileDialog openFileDialog_TestDatset;
        private System.Windows.Forms.Timer timer_LinkWatchdog;
    }
}

