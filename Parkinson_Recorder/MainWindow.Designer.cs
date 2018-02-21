namespace Parkinson_Recorder
{
    partial class ProgramMainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramMainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowTabControl = new System.Windows.Forms.TabControl();
            this.recorderViewTabPage = new System.Windows.Forms.TabPage();
            this.chartsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.signalTimeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.signalFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.newMeasureButton = new System.Windows.Forms.Button();
            this.openMeasureButton = new System.Windows.Forms.Button();
            this.saveMeasureButton = new System.Windows.Forms.Button();
            this.startStopMeasureButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.showFrequencyChartButton = new System.Windows.Forms.Button();
            this.showSignalsChartButton = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.signalsChooseCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.communicationTabPage = new System.Windows.Forms.TabPage();
            this.ConnectionSettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.SerialPortsListBox = new System.Windows.Forms.ListBox();
            this.BaudListBox = new System.Windows.Forms.ListBox();
            this.ReScanButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.connectionSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.chartsRefreshingTimer = new System.Windows.Forms.Timer(this.components);
            this.dataChartsTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.mainWindowTabControl.SuspendLayout();
            this.recorderViewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartsSplitContainer)).BeginInit();
            this.chartsSplitContainer.Panel1.SuspendLayout();
            this.chartsSplitContainer.Panel2.SuspendLayout();
            this.chartsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalTimeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalFrequencyChart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.communicationTabPage.SuspendLayout();
            this.ConnectionSettingsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(992, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Wyjście";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // mainWindowTabControl
            // 
            this.mainWindowTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainWindowTabControl.Controls.Add(this.recorderViewTabPage);
            this.mainWindowTabControl.Controls.Add(this.communicationTabPage);
            this.mainWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowTabControl.ImageList = this.tabControlImageList;
            this.mainWindowTabControl.ItemSize = new System.Drawing.Size(100, 100);
            this.mainWindowTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainWindowTabControl.Multiline = true;
            this.mainWindowTabControl.Name = "mainWindowTabControl";
            this.mainWindowTabControl.SelectedIndex = 0;
            this.mainWindowTabControl.Size = new System.Drawing.Size(992, 738);
            this.mainWindowTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainWindowTabControl.TabIndex = 1;
            // 
            // recorderViewTabPage
            // 
            this.recorderViewTabPage.Controls.Add(this.chartsSplitContainer);
            this.recorderViewTabPage.Controls.Add(this.tableLayoutPanel2);
            this.recorderViewTabPage.Controls.Add(this.tableLayoutPanel1);
            this.recorderViewTabPage.Location = new System.Drawing.Point(104, 4);
            this.recorderViewTabPage.Name = "recorderViewTabPage";
            this.recorderViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recorderViewTabPage.Size = new System.Drawing.Size(884, 730);
            this.recorderViewTabPage.TabIndex = 0;
            this.recorderViewTabPage.Text = "recorderViewtabPage";
            this.recorderViewTabPage.UseVisualStyleBackColor = true;
            // 
            // chartsSplitContainer
            // 
            this.chartsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartsSplitContainer.Location = new System.Drawing.Point(3, 111);
            this.chartsSplitContainer.Name = "chartsSplitContainer";
            this.chartsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // chartsSplitContainer.Panel1
            // 
            this.chartsSplitContainer.Panel1.Controls.Add(this.signalTimeChart);
            // 
            // chartsSplitContainer.Panel2
            // 
            this.chartsSplitContainer.Panel2.Controls.Add(this.signalFrequencyChart);
            this.chartsSplitContainer.Size = new System.Drawing.Size(878, 616);
            this.chartsSplitContainer.SplitterDistance = 308;
            this.chartsSplitContainer.TabIndex = 2;
            // 
            // signalTimeChart
            // 
            this.signalTimeChart.BackColor = System.Drawing.Color.DarkRed;
            chartArea5.Name = "ChartArea1";
            this.signalTimeChart.ChartAreas.Add(chartArea5);
            this.signalTimeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalTimeChart.Enabled = false;
            legend5.Name = "Legend1";
            this.signalTimeChart.Legends.Add(legend5);
            this.signalTimeChart.Location = new System.Drawing.Point(0, 0);
            this.signalTimeChart.Name = "signalTimeChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.signalTimeChart.Series.Add(series5);
            this.signalTimeChart.Size = new System.Drawing.Size(878, 308);
            this.signalTimeChart.TabIndex = 4;
            this.signalTimeChart.Text = "signalTimeChart";
            // 
            // signalFrequencyChart
            // 
            this.signalFrequencyChart.BackColor = System.Drawing.Color.ForestGreen;
            chartArea6.Name = "ChartArea1";
            this.signalFrequencyChart.ChartAreas.Add(chartArea6);
            this.signalFrequencyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalFrequencyChart.Enabled = false;
            legend6.Name = "Legend1";
            this.signalFrequencyChart.Legends.Add(legend6);
            this.signalFrequencyChart.Location = new System.Drawing.Point(0, 0);
            this.signalFrequencyChart.Name = "signalFrequencyChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.signalFrequencyChart.Series.Add(series6);
            this.signalFrequencyChart.Size = new System.Drawing.Size(878, 304);
            this.signalFrequencyChart.TabIndex = 5;
            this.signalFrequencyChart.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel2.Controls.Add(this.newMeasureButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.startStopMeasureButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitter1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.showFrequencyChartButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.showSignalsChartButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitter2, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.signalsChooseCheckedListBox, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveMeasureButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.openMeasureButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 108);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // newMeasureButton
            // 
            this.newMeasureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeasureButton.ImageIndex = 0;
            this.newMeasureButton.Location = new System.Drawing.Point(3, 3);
            this.newMeasureButton.Name = "newMeasureButton";
            this.newMeasureButton.Size = new System.Drawing.Size(64, 64);
            this.newMeasureButton.TabIndex = 0;
            this.newMeasureButton.Text = "newMeasureButton";
            this.newMeasureButton.UseVisualStyleBackColor = true;
            this.newMeasureButton.Click += new System.EventHandler(this.newMeasureButton_Click);
            // 
            // openMeasureButton
            // 
            this.openMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openMeasureButton.Location = new System.Drawing.Point(143, 3);
            this.openMeasureButton.Name = "openMeasureButton";
            this.openMeasureButton.Size = new System.Drawing.Size(64, 64);
            this.openMeasureButton.TabIndex = 1;
            this.openMeasureButton.Text = "openMeasureButton";
            this.openMeasureButton.UseVisualStyleBackColor = true;
            this.openMeasureButton.Click += new System.EventHandler(this.openMeasureButton_Click);
            // 
            // saveMeasureButton
            // 
            this.saveMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMeasureButton.Location = new System.Drawing.Point(73, 3);
            this.saveMeasureButton.Name = "saveMeasureButton";
            this.saveMeasureButton.Size = new System.Drawing.Size(64, 64);
            this.saveMeasureButton.TabIndex = 2;
            this.saveMeasureButton.Text = "saveMeasureButton";
            this.saveMeasureButton.UseVisualStyleBackColor = true;
            this.saveMeasureButton.Click += new System.EventHandler(this.saveMeasureButton_Click);
            // 
            // startStopMeasureButton
            // 
            this.startStopMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startStopMeasureButton.Location = new System.Drawing.Point(221, 3);
            this.startStopMeasureButton.Name = "startStopMeasureButton";
            this.startStopMeasureButton.Size = new System.Drawing.Size(64, 64);
            this.startStopMeasureButton.TabIndex = 3;
            this.startStopMeasureButton.Text = "startStopMeasure";
            this.startStopMeasureButton.UseVisualStyleBackColor = true;
            this.startStopMeasureButton.Click += new System.EventHandler(this.StartStopMeasureButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(213, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 64);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // showFrequencyChartButton
            // 
            this.showFrequencyChartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showFrequencyChartButton.Location = new System.Drawing.Point(291, 3);
            this.showFrequencyChartButton.Name = "showFrequencyChartButton";
            this.showFrequencyChartButton.Size = new System.Drawing.Size(64, 64);
            this.showFrequencyChartButton.TabIndex = 5;
            this.showFrequencyChartButton.Text = "showFrequencyChart";
            this.showFrequencyChartButton.UseVisualStyleBackColor = true;
            this.showFrequencyChartButton.Click += new System.EventHandler(this.ShowFrequencyChartButton_Click);
            // 
            // showSignalsChartButton
            // 
            this.showSignalsChartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showSignalsChartButton.Location = new System.Drawing.Point(361, 3);
            this.showSignalsChartButton.Name = "showSignalsChartButton";
            this.showSignalsChartButton.Size = new System.Drawing.Size(64, 64);
            this.showSignalsChartButton.TabIndex = 6;
            this.showSignalsChartButton.Text = "showSignalsChart";
            this.showSignalsChartButton.UseVisualStyleBackColor = true;
            this.showSignalsChartButton.Click += new System.EventHandler(this.ShowSignalsChartButton_Click);
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter2.Location = new System.Drawing.Point(431, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 64);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // signalsChooseCheckedListBox
            // 
            this.signalsChooseCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalsChooseCheckedListBox.FormattingEnabled = true;
            this.signalsChooseCheckedListBox.Items.AddRange(new object[] {
            "signal0",
            "signal1"});
            this.signalsChooseCheckedListBox.Location = new System.Drawing.Point(439, 3);
            this.signalsChooseCheckedListBox.Name = "signalsChooseCheckedListBox";
            this.signalsChooseCheckedListBox.Size = new System.Drawing.Size(167, 64);
            this.signalsChooseCheckedListBox.TabIndex = 9;
            this.signalsChooseCheckedListBox.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // communicationTabPage
            // 
            this.communicationTabPage.Controls.Add(this.ConnectionSettingsTableLayoutPanel);
            this.communicationTabPage.Controls.Add(this.connectionSettingsGroupBox);
            this.communicationTabPage.Location = new System.Drawing.Point(104, 4);
            this.communicationTabPage.Name = "communicationTabPage";
            this.communicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.communicationTabPage.Size = new System.Drawing.Size(884, 730);
            this.communicationTabPage.TabIndex = 1;
            this.communicationTabPage.Text = "communicationTabPage";
            this.communicationTabPage.UseVisualStyleBackColor = true;
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
            this.ConnectionSettingsTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.ConnectionSettingsTableLayoutPanel.Name = "ConnectionSettingsTableLayoutPanel";
            this.ConnectionSettingsTableLayoutPanel.RowCount = 3;
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConnectionSettingsTableLayoutPanel.Size = new System.Drawing.Size(478, 201);
            this.ConnectionSettingsTableLayoutPanel.TabIndex = 0;
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
            // connectionSettingsGroupBox
            // 
            this.connectionSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionSettingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.connectionSettingsGroupBox.Name = "connectionSettingsGroupBox";
            this.connectionSettingsGroupBox.Size = new System.Drawing.Size(878, 724);
            this.connectionSettingsGroupBox.TabIndex = 0;
            this.connectionSettingsGroupBox.TabStop = false;
            this.connectionSettingsGroupBox.Text = "Connection Settings";
            // 
            // tabControlImageList
            // 
            this.tabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabControlImageList.ImageStream")));
            this.tabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabControlImageList.Images.SetKeyName(0, "Connect_Icon.png");
            this.tabControlImageList.Images.SetKeyName(1, "Disconnect_Icon.png");
            // 
            // mainWindowStatusStrip
            // 
            this.mainWindowStatusStrip.Location = new System.Drawing.Point(0, 740);
            this.mainWindowStatusStrip.Name = "mainWindowStatusStrip";
            this.mainWindowStatusStrip.Size = new System.Drawing.Size(992, 22);
            this.mainWindowStatusStrip.TabIndex = 2;
            this.mainWindowStatusStrip.Text = "statusStrip1";
            this.mainWindowStatusStrip.Visible = false;
            // 
            // chartsRefreshingTimer
            // 
            this.chartsRefreshingTimer.Interval = 500;
            this.chartsRefreshingTimer.Tick += new System.EventHandler(this.ChartsRefreshingTimer_Tick);
            // 
            // dataChartsTimer
            // 
            this.dataChartsTimer.Interval = 1;
            this.dataChartsTimer.Tick += new System.EventHandler(this.DataChartsTimer_Tick);
            // 
            // ProgramMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 762);
            this.Controls.Add(this.mainWindowStatusStrip);
            this.Controls.Add(this.mainWindowTabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProgramMainWindow";
            this.Text = "Parkinson Recorder";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainWindowTabControl.ResumeLayout(false);
            this.recorderViewTabPage.ResumeLayout(false);
            this.recorderViewTabPage.PerformLayout();
            this.chartsSplitContainer.Panel1.ResumeLayout(false);
            this.chartsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartsSplitContainer)).EndInit();
            this.chartsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signalTimeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalFrequencyChart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.communicationTabPage.ResumeLayout(false);
            this.ConnectionSettingsTableLayoutPanel.ResumeLayout(false);
            this.ConnectionSettingsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage recorderViewTabPage;
        private System.Windows.Forms.TabPage communicationTabPage;
        private System.Windows.Forms.TabControl mainWindowTabControl;
        private System.Windows.Forms.ImageList tabControlImageList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.StatusStrip mainWindowStatusStrip;
        private System.Windows.Forms.Button newMeasureButton;
        private System.Windows.Forms.Button openMeasureButton;
        private System.Windows.Forms.Button saveMeasureButton;
        private System.Windows.Forms.Button startStopMeasureButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button showFrequencyChartButton;
        private System.Windows.Forms.Button showSignalsChartButton;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.CheckedListBox signalsChooseCheckedListBox;
        private System.Windows.Forms.SplitContainer chartsSplitContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart signalTimeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart signalFrequencyChart;
        private System.Windows.Forms.Timer chartsRefreshingTimer;
        private System.Windows.Forms.Timer dataChartsTimer;
        private System.Windows.Forms.GroupBox connectionSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel ConnectionSettingsTableLayoutPanel;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ListBox SerialPortsListBox;
        private System.Windows.Forms.Button ReScanButton;
        private System.Windows.Forms.ListBox BaudListBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
    }
}

