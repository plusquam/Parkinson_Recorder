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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.startStopMeasureButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.showFrequencyChartButton = new System.Windows.Forms.Button();
            this.showSignalsChartButton = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.signalsChooseCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.saveMeasureButton = new System.Windows.Forms.Button();
            this.openMeasureButton = new System.Windows.Forms.Button();
            this.fftChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.fftZRadioButton = new System.Windows.Forms.RadioButton();
            this.fftYRadioButton = new System.Windows.Forms.RadioButton();
            this.fftXRadioButton = new System.Windows.Forms.RadioButton();
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
            this.patientTabPage = new System.Windows.Forms.TabPage();
            this.patientDataGroupBox = new System.Windows.Forms.GroupBox();
            this.patientDataTable = new System.Windows.Forms.TableLayoutPanel();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patientBirthDateLabel = new System.Windows.Forms.Label();
            this.patientSexLabel = new System.Windows.Forms.Label();
            this.patientSurnameLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.genderListBox = new System.Windows.Forms.ListBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripConnectionStatusIcon = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.fftChoiceGroupBox.SuspendLayout();
            this.communicationTabPage.SuspendLayout();
            this.ConnectionSettingsTableLayoutPanel.SuspendLayout();
            this.patientTabPage.SuspendLayout();
            this.patientDataGroupBox.SuspendLayout();
            this.patientDataTable.SuspendLayout();
            this.mainWindowStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
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
            this.mainWindowTabControl.Controls.Add(this.patientTabPage);
            this.mainWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowTabControl.ImageList = this.tabControlImageList;
            this.mainWindowTabControl.ItemSize = new System.Drawing.Size(70, 70);
            this.mainWindowTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainWindowTabControl.Multiline = true;
            this.mainWindowTabControl.Name = "mainWindowTabControl";
            this.mainWindowTabControl.SelectedIndex = 0;
            this.mainWindowTabControl.ShowToolTips = true;
            this.mainWindowTabControl.Size = new System.Drawing.Size(1008, 684);
            this.mainWindowTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainWindowTabControl.TabIndex = 1;
            // 
            // recorderViewTabPage
            // 
            this.recorderViewTabPage.Controls.Add(this.chartsSplitContainer);
            this.recorderViewTabPage.Controls.Add(this.tableLayoutPanel2);
            this.recorderViewTabPage.Controls.Add(this.tableLayoutPanel1);
            this.recorderViewTabPage.ImageIndex = 0;
            this.recorderViewTabPage.Location = new System.Drawing.Point(74, 4);
            this.recorderViewTabPage.Name = "recorderViewTabPage";
            this.recorderViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recorderViewTabPage.Size = new System.Drawing.Size(930, 676);
            this.recorderViewTabPage.TabIndex = 0;
            this.recorderViewTabPage.ToolTipText = "test";
            this.recorderViewTabPage.UseVisualStyleBackColor = true;
            // 
            // chartsSplitContainer
            // 
            this.chartsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartsSplitContainer.Location = new System.Drawing.Point(3, 91);
            this.chartsSplitContainer.Name = "chartsSplitContainer";
            this.chartsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // chartsSplitContainer.Panel1
            // 
            this.chartsSplitContainer.Panel1.Controls.Add(this.signalTimeChart);
            this.chartsSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // chartsSplitContainer.Panel2
            // 
            this.chartsSplitContainer.Panel2.Controls.Add(this.signalFrequencyChart);
            this.chartsSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chartsSplitContainer.Size = new System.Drawing.Size(924, 582);
            this.chartsSplitContainer.SplitterDistance = 291;
            this.chartsSplitContainer.TabIndex = 2;
            // 
            // signalTimeChart
            // 
            this.signalTimeChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Czas pomiaru [h.min.s.ms]";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "Przyspieszenie [mg]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.Name = "ChartArea1";
            this.signalTimeChart.ChartAreas.Add(chartArea1);
            this.signalTimeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalTimeChart.Enabled = false;
            legend1.Name = "Legend1";
            this.signalTimeChart.Legends.Add(legend1);
            this.signalTimeChart.Location = new System.Drawing.Point(0, 0);
            this.signalTimeChart.Name = "signalTimeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "XAxis";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "YAxis";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "ZAxis";
            this.signalTimeChart.Series.Add(series1);
            this.signalTimeChart.Series.Add(series2);
            this.signalTimeChart.Series.Add(series3);
            this.signalTimeChart.Size = new System.Drawing.Size(924, 291);
            this.signalTimeChart.TabIndex = 4;
            this.signalTimeChart.Text = "signalTimeChart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "TimeChartTitle";
            title1.Text = "Przebieg czasowy pomiaru";
            this.signalTimeChart.Titles.Add(title1);
            // 
            // signalFrequencyChart
            // 
            this.signalFrequencyChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Interval = 3D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffset = 1D;
            chartArea2.AxisX.MaximumAutoSize = 100F;
            chartArea2.AxisX.Minimum = -1D;
            chartArea2.AxisX.Title = "Częstotliwość [Hz]";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea2.AxisY.MaximumAutoSize = 100F;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea2.AxisY.Title = "Amplituda [mg]";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea2.Name = "ChartArea1";
            this.signalFrequencyChart.ChartAreas.Add(chartArea2);
            this.signalFrequencyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalFrequencyChart.Enabled = false;
            legend2.Name = "Legend1";
            this.signalFrequencyChart.Legends.Add(legend2);
            this.signalFrequencyChart.Location = new System.Drawing.Point(0, 0);
            this.signalFrequencyChart.Name = "signalFrequencyChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "XAxis";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "YAxis";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "ZAxis";
            this.signalFrequencyChart.Series.Add(series4);
            this.signalFrequencyChart.Series.Add(series5);
            this.signalFrequencyChart.Series.Add(series6);
            this.signalFrequencyChart.Size = new System.Drawing.Size(924, 287);
            this.signalFrequencyChart.TabIndex = 5;
            this.signalFrequencyChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "FreqChartTitle";
            title2.Text = "Widmo częstotliwościowe sygnałów";
            this.signalFrequencyChart.Titles.Add(title2);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel2.Controls.Add(this.newMeasureButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.startStopMeasureButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitter1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.showFrequencyChartButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.showSignalsChartButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitter2, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.signalsChooseCheckedListBox, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveMeasureButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.openMeasureButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.fftChoiceGroupBox, 9, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(924, 88);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // newMeasureButton
            // 
            this.newMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeasureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.newMeasureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMeasureButton.ForeColor = System.Drawing.Color.White;
            this.newMeasureButton.Image = global::Parkinson_Recorder.Properties.Resources.new_file_64;
            this.newMeasureButton.Location = new System.Drawing.Point(3, 3);
            this.newMeasureButton.Name = "newMeasureButton";
            this.newMeasureButton.Size = new System.Drawing.Size(69, 69);
            this.newMeasureButton.TabIndex = 0;
            this.newMeasureButton.UseVisualStyleBackColor = true;
            this.newMeasureButton.Click += new System.EventHandler(this.newMeasureButton_Click);
            // 
            // startStopMeasureButton
            // 
            this.startStopMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startStopMeasureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.startStopMeasureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startStopMeasureButton.ForeColor = System.Drawing.Color.White;
            this.startStopMeasureButton.Image = global::Parkinson_Recorder.Properties.Resources.record_64;
            this.startStopMeasureButton.Location = new System.Drawing.Point(236, 3);
            this.startStopMeasureButton.Name = "startStopMeasureButton";
            this.startStopMeasureButton.Size = new System.Drawing.Size(69, 69);
            this.startStopMeasureButton.TabIndex = 3;
            this.startStopMeasureButton.UseVisualStyleBackColor = true;
            this.startStopMeasureButton.Click += new System.EventHandler(this.StartStopMeasureButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(228, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 69);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // showFrequencyChartButton
            // 
            this.showFrequencyChartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showFrequencyChartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.showFrequencyChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showFrequencyChartButton.ForeColor = System.Drawing.Color.White;
            this.showFrequencyChartButton.Image = global::Parkinson_Recorder.Properties.Resources.bar_chart_64;
            this.showFrequencyChartButton.Location = new System.Drawing.Point(311, 3);
            this.showFrequencyChartButton.Name = "showFrequencyChartButton";
            this.showFrequencyChartButton.Size = new System.Drawing.Size(69, 69);
            this.showFrequencyChartButton.TabIndex = 5;
            this.showFrequencyChartButton.UseVisualStyleBackColor = true;
            this.showFrequencyChartButton.Click += new System.EventHandler(this.ShowFrequencyChartButton_Click);
            // 
            // showSignalsChartButton
            // 
            this.showSignalsChartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showSignalsChartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.showSignalsChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSignalsChartButton.ForeColor = System.Drawing.Color.White;
            this.showSignalsChartButton.Image = global::Parkinson_Recorder.Properties.Resources.line_graph_64;
            this.showSignalsChartButton.Location = new System.Drawing.Point(386, 3);
            this.showSignalsChartButton.Name = "showSignalsChartButton";
            this.showSignalsChartButton.Size = new System.Drawing.Size(69, 69);
            this.showSignalsChartButton.TabIndex = 6;
            this.showSignalsChartButton.UseVisualStyleBackColor = true;
            this.showSignalsChartButton.Click += new System.EventHandler(this.ShowSignalsChartButton_Click);
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter2.Location = new System.Drawing.Point(461, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 69);
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
            this.signalsChooseCheckedListBox.Location = new System.Drawing.Point(469, 3);
            this.signalsChooseCheckedListBox.Name = "signalsChooseCheckedListBox";
            this.signalsChooseCheckedListBox.Size = new System.Drawing.Size(167, 69);
            this.signalsChooseCheckedListBox.TabIndex = 9;
            // 
            // saveMeasureButton
            // 
            this.saveMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMeasureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.saveMeasureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMeasureButton.ForeColor = System.Drawing.Color.White;
            this.saveMeasureButton.Image = global::Parkinson_Recorder.Properties.Resources.save_file_option_64;
            this.saveMeasureButton.Location = new System.Drawing.Point(78, 3);
            this.saveMeasureButton.Name = "saveMeasureButton";
            this.saveMeasureButton.Size = new System.Drawing.Size(69, 69);
            this.saveMeasureButton.TabIndex = 2;
            this.saveMeasureButton.UseVisualStyleBackColor = true;
            this.saveMeasureButton.Click += new System.EventHandler(this.saveMeasureButton_Click);
            // 
            // openMeasureButton
            // 
            this.openMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openMeasureButton.Enabled = false;
            this.openMeasureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.openMeasureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMeasureButton.ForeColor = System.Drawing.Color.White;
            this.openMeasureButton.Image = global::Parkinson_Recorder.Properties.Resources.open_folder_outline_64;
            this.openMeasureButton.Location = new System.Drawing.Point(153, 3);
            this.openMeasureButton.Name = "openMeasureButton";
            this.openMeasureButton.Size = new System.Drawing.Size(69, 69);
            this.openMeasureButton.TabIndex = 1;
            this.openMeasureButton.UseVisualStyleBackColor = true;
            this.openMeasureButton.Visible = false;
            this.openMeasureButton.Click += new System.EventHandler(this.openMeasureButton_Click);
            // 
            // fftChoiceGroupBox
            // 
            this.fftChoiceGroupBox.Controls.Add(this.fftZRadioButton);
            this.fftChoiceGroupBox.Controls.Add(this.fftYRadioButton);
            this.fftChoiceGroupBox.Controls.Add(this.fftXRadioButton);
            this.fftChoiceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fftChoiceGroupBox.Location = new System.Drawing.Point(642, 3);
            this.fftChoiceGroupBox.Name = "fftChoiceGroupBox";
            this.fftChoiceGroupBox.Size = new System.Drawing.Size(279, 69);
            this.fftChoiceGroupBox.TabIndex = 10;
            this.fftChoiceGroupBox.TabStop = false;
            this.fftChoiceGroupBox.Text = "FFT Axis Display";
            // 
            // fftZRadioButton
            // 
            this.fftZRadioButton.AutoSize = true;
            this.fftZRadioButton.Location = new System.Drawing.Point(97, 19);
            this.fftZRadioButton.Name = "fftZRadioButton";
            this.fftZRadioButton.Size = new System.Drawing.Size(54, 17);
            this.fftZRadioButton.TabIndex = 2;
            this.fftZRadioButton.Text = "Z Axis";
            this.fftZRadioButton.UseVisualStyleBackColor = true;
            this.fftZRadioButton.CheckedChanged += new System.EventHandler(this.fftZRadioButton_CheckedChanged);
            // 
            // fftYRadioButton
            // 
            this.fftYRadioButton.AutoSize = true;
            this.fftYRadioButton.Location = new System.Drawing.Point(6, 41);
            this.fftYRadioButton.Name = "fftYRadioButton";
            this.fftYRadioButton.Size = new System.Drawing.Size(54, 17);
            this.fftYRadioButton.TabIndex = 1;
            this.fftYRadioButton.TabStop = true;
            this.fftYRadioButton.Text = "Y Axis";
            this.fftYRadioButton.UseVisualStyleBackColor = true;
            this.fftYRadioButton.CheckedChanged += new System.EventHandler(this.fftYRadioButton_CheckedChanged);
            // 
            // fftXRadioButton
            // 
            this.fftXRadioButton.AutoSize = true;
            this.fftXRadioButton.Checked = true;
            this.fftXRadioButton.Location = new System.Drawing.Point(6, 19);
            this.fftXRadioButton.Name = "fftXRadioButton";
            this.fftXRadioButton.Size = new System.Drawing.Size(54, 17);
            this.fftXRadioButton.TabIndex = 0;
            this.fftXRadioButton.TabStop = true;
            this.fftXRadioButton.Text = "X Axis";
            this.fftXRadioButton.UseVisualStyleBackColor = true;
            this.fftXRadioButton.CheckedChanged += new System.EventHandler(this.fftXRadioButton_CheckedChanged);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // communicationTabPage
            // 
            this.communicationTabPage.Controls.Add(this.ConnectionSettingsTableLayoutPanel);
            this.communicationTabPage.Controls.Add(this.connectionSettingsGroupBox);
            this.communicationTabPage.ImageIndex = 1;
            this.communicationTabPage.Location = new System.Drawing.Point(74, 4);
            this.communicationTabPage.Name = "communicationTabPage";
            this.communicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.communicationTabPage.Size = new System.Drawing.Size(930, 676);
            this.communicationTabPage.TabIndex = 1;
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
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectionSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConnectionSettingsTableLayoutPanel.Size = new System.Drawing.Size(478, 301);
            this.ConnectionSettingsTableLayoutPanel.TabIndex = 0;
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortNameLabel.Location = new System.Drawing.Point(3, 0);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(94, 123);
            this.PortNameLabel.TabIndex = 0;
            this.PortNameLabel.Text = "Serial Port:";
            this.PortNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BaudRateLabel.Location = new System.Drawing.Point(3, 123);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(94, 138);
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
            this.SerialPortsListBox.Size = new System.Drawing.Size(194, 117);
            this.SerialPortsListBox.TabIndex = 2;
            // 
            // BaudListBox
            // 
            this.BaudListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaudListBox.FormattingEnabled = true;
            this.BaudListBox.Location = new System.Drawing.Point(103, 126);
            this.BaudListBox.Name = "BaudListBox";
            this.BaudListBox.Size = new System.Drawing.Size(194, 132);
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
            this.ConnectButton.Location = new System.Drawing.Point(103, 264);
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
            this.DisconnectButton.Location = new System.Drawing.Point(303, 264);
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
            this.connectionSettingsGroupBox.Size = new System.Drawing.Size(924, 670);
            this.connectionSettingsGroupBox.TabIndex = 0;
            this.connectionSettingsGroupBox.TabStop = false;
            this.connectionSettingsGroupBox.Text = "Connection Settings";
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.patientDataGroupBox);
            this.patientTabPage.ImageIndex = 2;
            this.patientTabPage.Location = new System.Drawing.Point(74, 4);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Size = new System.Drawing.Size(930, 676);
            this.patientTabPage.TabIndex = 2;
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // patientDataGroupBox
            // 
            this.patientDataGroupBox.Controls.Add(this.patientDataTable);
            this.patientDataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientDataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.patientDataGroupBox.Name = "patientDataGroupBox";
            this.patientDataGroupBox.Size = new System.Drawing.Size(930, 676);
            this.patientDataGroupBox.TabIndex = 0;
            this.patientDataGroupBox.TabStop = false;
            this.patientDataGroupBox.Text = "Dane Badanego";
            // 
            // patientDataTable
            // 
            this.patientDataTable.ColumnCount = 2;
            this.patientDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.patientDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.patientDataTable.Controls.Add(this.surnameTextBox, 1, 1);
            this.patientDataTable.Controls.Add(this.patientBirthDateLabel, 0, 3);
            this.patientDataTable.Controls.Add(this.patientSexLabel, 0, 2);
            this.patientDataTable.Controls.Add(this.patientSurnameLabel, 0, 1);
            this.patientDataTable.Controls.Add(this.patientNameLabel, 0, 0);
            this.patientDataTable.Controls.Add(this.genderListBox, 1, 2);
            this.patientDataTable.Controls.Add(this.birthDateTimePicker, 1, 3);
            this.patientDataTable.Controls.Add(this.nameTextBox, 1, 0);
            this.patientDataTable.Location = new System.Drawing.Point(6, 19);
            this.patientDataTable.Name = "patientDataTable";
            this.patientDataTable.RowCount = 4;
            this.patientDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.patientDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.patientDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.patientDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.patientDataTable.Size = new System.Drawing.Size(402, 145);
            this.patientDataTable.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surnameTextBox.Location = new System.Drawing.Point(153, 38);
            this.surnameTextBox.MaxLength = 100;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(246, 20);
            this.surnameTextBox.TabIndex = 9;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.PatientDataChanged);
            // 
            // patientBirthDateLabel
            // 
            this.patientBirthDateLabel.AutoSize = true;
            this.patientBirthDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientBirthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientBirthDateLabel.Location = new System.Drawing.Point(3, 114);
            this.patientBirthDateLabel.Name = "patientBirthDateLabel";
            this.patientBirthDateLabel.Size = new System.Drawing.Size(144, 20);
            this.patientBirthDateLabel.TabIndex = 6;
            this.patientBirthDateLabel.Text = "Data urodzenia";
            // 
            // patientSexLabel
            // 
            this.patientSexLabel.AutoSize = true;
            this.patientSexLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientSexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientSexLabel.Location = new System.Drawing.Point(3, 70);
            this.patientSexLabel.Name = "patientSexLabel";
            this.patientSexLabel.Size = new System.Drawing.Size(144, 20);
            this.patientSexLabel.TabIndex = 4;
            this.patientSexLabel.Text = "Płeć";
            // 
            // patientSurnameLabel
            // 
            this.patientSurnameLabel.AutoSize = true;
            this.patientSurnameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientSurnameLabel.Location = new System.Drawing.Point(3, 35);
            this.patientSurnameLabel.Name = "patientSurnameLabel";
            this.patientSurnameLabel.Size = new System.Drawing.Size(144, 20);
            this.patientSurnameLabel.TabIndex = 2;
            this.patientSurnameLabel.Text = "Nazwisko";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientNameLabel.Location = new System.Drawing.Point(3, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(144, 20);
            this.patientNameLabel.TabIndex = 0;
            this.patientNameLabel.Text = "Imię";
            // 
            // genderListBox
            // 
            this.genderListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.genderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genderListBox.FormattingEnabled = true;
            this.genderListBox.ItemHeight = 16;
            this.genderListBox.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.genderListBox.Location = new System.Drawing.Point(153, 73);
            this.genderListBox.Name = "genderListBox";
            this.genderListBox.Size = new System.Drawing.Size(246, 36);
            this.genderListBox.TabIndex = 5;
            this.genderListBox.SelectedValueChanged += new System.EventHandler(this.PatientDataChanged);
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthDateTimePicker.Location = new System.Drawing.Point(153, 117);
            this.birthDateTimePicker.MaxDate = new System.DateTime(2019, 2, 15, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(246, 20);
            this.birthDateTimePicker.TabIndex = 7;
            this.birthDateTimePicker.Value = new System.DateTime(2018, 8, 8, 20, 50, 25, 857);
            this.birthDateTimePicker.ValueChanged += new System.EventHandler(this.PatientDataChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(153, 3);
            this.nameTextBox.MaxLength = 100;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.PatientDataChanged);
            // 
            // tabControlImageList
            // 
            this.tabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabControlImageList.ImageStream")));
            this.tabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabControlImageList.Images.SetKeyName(0, "measurement_tab_icon.png");
            this.tabControlImageList.Images.SetKeyName(1, "settings_tab_icon.png");
            this.tabControlImageList.Images.SetKeyName(2, "man_tab_icon.png");
            // 
            // mainWindowStatusStrip
            // 
            this.mainWindowStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnectionStatusLabel,
            this.toolStripConnectionStatusIcon});
            this.mainWindowStatusStrip.Location = new System.Drawing.Point(0, 708);
            this.mainWindowStatusStrip.Name = "mainWindowStatusStrip";
            this.mainWindowStatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.mainWindowStatusStrip.TabIndex = 2;
            this.mainWindowStatusStrip.Text = "statusStrip1";
            // 
            // toolStripConnectionStatusLabel
            // 
            this.toolStripConnectionStatusLabel.Name = "toolStripConnectionStatusLabel";
            this.toolStripConnectionStatusLabel.Size = new System.Drawing.Size(103, 17);
            this.toolStripConnectionStatusLabel.Text = "Connection status";
            // 
            // toolStripConnectionStatusIcon
            // 
            this.toolStripConnectionStatusIcon.BackgroundImage = global::Parkinson_Recorder.Properties.Resources.red_dot_17x17;
            this.toolStripConnectionStatusIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripConnectionStatusIcon.Name = "toolStripConnectionStatusIcon";
            this.toolStripConnectionStatusIcon.Size = new System.Drawing.Size(19, 17);
            this.toolStripConnectionStatusIcon.Text = "    ";
            // 
            // ProgramMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.mainWindowTabControl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.mainWindowStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProgramMainWindow";
            this.Text = "Parkinson Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramMainWindow_FormClosing);
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
            this.fftChoiceGroupBox.ResumeLayout(false);
            this.fftChoiceGroupBox.PerformLayout();
            this.communicationTabPage.ResumeLayout(false);
            this.ConnectionSettingsTableLayoutPanel.ResumeLayout(false);
            this.ConnectionSettingsTableLayoutPanel.PerformLayout();
            this.patientTabPage.ResumeLayout(false);
            this.patientDataGroupBox.ResumeLayout(false);
            this.patientDataTable.ResumeLayout(false);
            this.patientDataTable.PerformLayout();
            this.mainWindowStatusStrip.ResumeLayout(false);
            this.mainWindowStatusStrip.PerformLayout();
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
        private System.Windows.Forms.GroupBox connectionSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel ConnectionSettingsTableLayoutPanel;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ListBox SerialPortsListBox;
        private System.Windows.Forms.Button ReScanButton;
        private System.Windows.Forms.ListBox BaudListBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.SplitContainer chartsSplitContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart signalTimeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart signalFrequencyChart;
        private System.Windows.Forms.TabPage patientTabPage;
        private System.Windows.Forms.GroupBox patientDataGroupBox;
        private System.Windows.Forms.TableLayoutPanel patientDataTable;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientSurnameLabel;
        private System.Windows.Forms.Label patientSexLabel;
        private System.Windows.Forms.ListBox genderListBox;
        private System.Windows.Forms.Label patientBirthDateLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.ToolStripStatusLabel toolStripConnectionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripConnectionStatusIcon;
        private System.Windows.Forms.GroupBox fftChoiceGroupBox;
        private System.Windows.Forms.RadioButton fftZRadioButton;
        private System.Windows.Forms.RadioButton fftYRadioButton;
        private System.Windows.Forms.RadioButton fftXRadioButton;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

