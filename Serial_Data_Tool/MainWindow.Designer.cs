namespace Serial_Data_Tool
{
    partial class MainWindow
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
            this.connectionSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectionSettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.SerialPortsListBox = new System.Windows.Forms.ListBox();
            this.BaudListBox = new System.Windows.Forms.ListBox();
            this.ReScanButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendProgressBar = new System.Windows.Forms.ProgressBar();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.fileAdressTextBox = new System.Windows.Forms.TextBox();
            this.MessageDisplayBox = new System.Windows.Forms.TextBox();
            this.clearMsgWindowButton = new System.Windows.Forms.Button();
            this.dataSendTimer = new System.Windows.Forms.Timer(this.components);
            this.stopTransmissionButton = new System.Windows.Forms.Button();
            this.measurementTimeLabel = new System.Windows.Forms.Label();
            this.measurementTimeValueBox = new System.Windows.Forms.TextBox();
            this.connectionSettingsGroupBox.SuspendLayout();
            this.ConnectionSettingsTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionSettingsGroupBox
            // 
            this.connectionSettingsGroupBox.Controls.Add(this.ConnectionSettingsTableLayoutPanel);
            this.connectionSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionSettingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.connectionSettingsGroupBox.Name = "connectionSettingsGroupBox";
            this.connectionSettingsGroupBox.Size = new System.Drawing.Size(991, 222);
            this.connectionSettingsGroupBox.TabIndex = 1;
            this.connectionSettingsGroupBox.TabStop = false;
            this.connectionSettingsGroupBox.Text = "Connection Settings";
            // 
            // ConnectionSettingsTableLayoutPanel
            // 
            this.ConnectionSettingsTableLayoutPanel.ColumnCount = 3;
            this.ConnectionSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ConnectionSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.ConnectionSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ConnectionSettingsTableLayoutPanel.Controls.Add(this.PortNameLabel, 0, 0);
            this.ConnectionSettingsTableLayoutPanel.Controls.Add(this.BaudRateLabel, 0, 1);
            this.ConnectionSettingsTableLayoutPanel.Controls.Add(this.SerialPortsListBox, 1, 0);
            this.ConnectionSettingsTableLayoutPanel.Controls.Add(this.BaudListBox, 1, 1);
            this.ConnectionSettingsTableLayoutPanel.Controls.Add(this.ReScanButton, 2, 0);
            this.ConnectionSettingsTableLayoutPanel.Controls.Add(this.ConnectButton, 1, 2);
            this.ConnectionSettingsTableLayoutPanel.Controls.Add(this.DisconnectButton, 2, 2);
            this.ConnectionSettingsTableLayoutPanel.Location = new System.Drawing.Point(0, 19);
            this.ConnectionSettingsTableLayoutPanel.Name = "ConnectionSettingsTableLayoutPanel";
            this.ConnectionSettingsTableLayoutPanel.RowCount = 3;
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConnectionSettingsTableLayoutPanel.Size = new System.Drawing.Size(478, 201);
            this.ConnectionSettingsTableLayoutPanel.TabIndex = 1;
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortNameLabel.Location = new System.Drawing.Point(3, 0);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(94, 60);
            this.PortNameLabel.TabIndex = 0;
            this.PortNameLabel.Text = "Serial Port:";
            this.PortNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BaudRateLabel.Location = new System.Drawing.Point(3, 60);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(94, 101);
            this.BaudRateLabel.TabIndex = 1;
            this.BaudRateLabel.Text = "Baud Rate:";
            this.BaudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialPortsListBox
            // 
            this.SerialPortsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerialPortsListBox.FormattingEnabled = true;
            this.SerialPortsListBox.Location = new System.Drawing.Point(103, 3);
            this.SerialPortsListBox.Name = "SerialPortsListBox";
            this.SerialPortsListBox.Size = new System.Drawing.Size(194, 54);
            this.SerialPortsListBox.TabIndex = 2;
            // 
            // BaudListBox
            // 
            this.BaudListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaudListBox.FormattingEnabled = true;
            this.BaudListBox.Location = new System.Drawing.Point(103, 63);
            this.BaudListBox.Name = "BaudListBox";
            this.BaudListBox.Size = new System.Drawing.Size(194, 95);
            this.BaudListBox.TabIndex = 3;
            // 
            // ReScanButton
            // 
            this.ReScanButton.Location = new System.Drawing.Point(303, 3);
            this.ReScanButton.Name = "ReScanButton";
            this.ReScanButton.Size = new System.Drawing.Size(94, 34);
            this.ReScanButton.TabIndex = 4;
            this.ReScanButton.Text = "Re-Scan Ports";
            this.ReScanButton.UseVisualStyleBackColor = true;
            this.ReScanButton.Click += new System.EventHandler(this.ReScanButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConnectButton.Location = new System.Drawing.Point(103, 164);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(155, 34);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Apply Settings and Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Location = new System.Drawing.Point(303, 164);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 34);
            this.DisconnectButton.TabIndex = 6;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.measurementTimeValueBox);
            this.panel1.Controls.Add(this.measurementTimeLabel);
            this.panel1.Controls.Add(this.stopTransmissionButton);
            this.panel1.Controls.Add(this.sendProgressBar);
            this.panel1.Controls.Add(this.sendFileButton);
            this.panel1.Controls.Add(this.openFileDialogButton);
            this.panel1.Controls.Add(this.fileAdressTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 81);
            this.panel1.TabIndex = 2;
            // 
            // sendProgressBar
            // 
            this.sendProgressBar.Location = new System.Drawing.Point(13, 46);
            this.sendProgressBar.Name = "sendProgressBar";
            this.sendProgressBar.Size = new System.Drawing.Size(100, 23);
            this.sendProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.sendProgressBar.TabIndex = 3;
            this.sendProgressBar.Visible = false;
            // 
            // sendFileButton
            // 
            this.sendFileButton.Location = new System.Drawing.Point(484, 6);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(113, 23);
            this.sendFileButton.TabIndex = 2;
            this.sendFileButton.Text = "Send File Message";
            this.sendFileButton.UseVisualStyleBackColor = true;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(451, 6);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(27, 23);
            this.openFileDialogButton.TabIndex = 1;
            this.openFileDialogButton.Text = "...";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // fileAdressTextBox
            // 
            this.fileAdressTextBox.Location = new System.Drawing.Point(13, 7);
            this.fileAdressTextBox.Name = "fileAdressTextBox";
            this.fileAdressTextBox.Size = new System.Drawing.Size(432, 20);
            this.fileAdressTextBox.TabIndex = 0;
            this.fileAdressTextBox.TextChanged += new System.EventHandler(this.fileAdressTextBox_TextChanged);
            // 
            // MessageDisplayBox
            // 
            this.MessageDisplayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageDisplayBox.Location = new System.Drawing.Point(0, 222);
            this.MessageDisplayBox.Multiline = true;
            this.MessageDisplayBox.Name = "MessageDisplayBox";
            this.MessageDisplayBox.ReadOnly = true;
            this.MessageDisplayBox.Size = new System.Drawing.Size(991, 225);
            this.MessageDisplayBox.TabIndex = 3;
            // 
            // clearMsgWindowButton
            // 
            this.clearMsgWindowButton.Location = new System.Drawing.Point(883, 409);
            this.clearMsgWindowButton.Name = "clearMsgWindowButton";
            this.clearMsgWindowButton.Size = new System.Drawing.Size(96, 23);
            this.clearMsgWindowButton.TabIndex = 0;
            this.clearMsgWindowButton.Text = "Clear Window";
            this.clearMsgWindowButton.UseVisualStyleBackColor = true;
            this.clearMsgWindowButton.Click += new System.EventHandler(this.clearMsgWindowButton_Click);
            // 
            // dataSendTimer
            // 
            this.dataSendTimer.Interval = 5;
            this.dataSendTimer.Tick += new System.EventHandler(this.dataSendTimer_Tick);
            // 
            // stopTransmissionButton
            // 
            this.stopTransmissionButton.Enabled = false;
            this.stopTransmissionButton.Location = new System.Drawing.Point(603, 6);
            this.stopTransmissionButton.Name = "stopTransmissionButton";
            this.stopTransmissionButton.Size = new System.Drawing.Size(105, 23);
            this.stopTransmissionButton.TabIndex = 4;
            this.stopTransmissionButton.Text = "Stop Transmission";
            this.stopTransmissionButton.UseVisualStyleBackColor = true;
            this.stopTransmissionButton.Click += new System.EventHandler(this.stopTransmissionButton_Click);
            // 
            // measurementTimeLabel
            // 
            this.measurementTimeLabel.AutoSize = true;
            this.measurementTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.measurementTimeLabel.Location = new System.Drawing.Point(132, 46);
            this.measurementTimeLabel.Name = "measurementTimeLabel";
            this.measurementTimeLabel.Size = new System.Drawing.Size(245, 16);
            this.measurementTimeLabel.TabIndex = 5;
            this.measurementTimeLabel.Text = "Measurement transmission time interval:";
            // 
            // measurementTimeValueBox
            // 
            this.measurementTimeValueBox.Location = new System.Drawing.Point(383, 45);
            this.measurementTimeValueBox.Name = "measurementTimeValueBox";
            this.measurementTimeValueBox.ReadOnly = true;
            this.measurementTimeValueBox.Size = new System.Drawing.Size(131, 20);
            this.measurementTimeValueBox.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 528);
            this.Controls.Add(this.clearMsgWindowButton);
            this.Controls.Add(this.MessageDisplayBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.connectionSettingsGroupBox);
            this.Name = "MainWindow";
            this.Text = "Serial Data Tool";
            this.connectionSettingsGroupBox.ResumeLayout(false);
            this.ConnectionSettingsTableLayoutPanel.ResumeLayout(false);
            this.ConnectionSettingsTableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox connectionSettingsGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel ConnectionSettingsTableLayoutPanel;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ListBox SerialPortsListBox;
        private System.Windows.Forms.ListBox BaudListBox;
        private System.Windows.Forms.Button ReScanButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox MessageDisplayBox;
        private System.Windows.Forms.Button clearMsgWindowButton;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.TextBox fileAdressTextBox;
        private System.Windows.Forms.Button sendFileButton;
        private System.Windows.Forms.Timer dataSendTimer;
        private System.Windows.Forms.ProgressBar sendProgressBar;
        private System.Windows.Forms.Button stopTransmissionButton;
        private System.Windows.Forms.Label measurementTimeLabel;
        private System.Windows.Forms.TextBox measurementTimeValueBox;
    }
}

