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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.connectionSettingsTabPage = new System.Windows.Forms.TabPage();
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainWindowTabControl
            // 
            this.mainWindowTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainWindowTabControl.Controls.Add(this.recorderViewTabPage);
            this.mainWindowTabControl.Controls.Add(this.communicationTabPage);
            this.mainWindowTabControl.Controls.Add(this.connectionSettingsTabPage);
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
            chartArea15.Name = "ChartArea1";
            this.signalTimeChart.ChartAreas.Add(chartArea15);
            this.signalTimeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalTimeChart.Enabled = false;
            legend15.Name = "Legend1";
            this.signalTimeChart.Legends.Add(legend15);
            this.signalTimeChart.Location = new System.Drawing.Point(0, 0);
            this.signalTimeChart.Name = "signalTimeChart";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.signalTimeChart.Series.Add(series15);
            this.signalTimeChart.Size = new System.Drawing.Size(878, 308);
            this.signalTimeChart.TabIndex = 4;
            this.signalTimeChart.Text = "signalTimeChart";
            // 
            // signalFrequencyChart
            // 
            this.signalFrequencyChart.BackColor = System.Drawing.Color.ForestGreen;
            chartArea16.Name = "ChartArea1";
            this.signalFrequencyChart.ChartAreas.Add(chartArea16);
            this.signalFrequencyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalFrequencyChart.Enabled = false;
            legend16.Name = "Legend1";
            this.signalFrequencyChart.Legends.Add(legend16);
            this.signalFrequencyChart.Location = new System.Drawing.Point(0, 0);
            this.signalFrequencyChart.Name = "signalFrequencyChart";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.signalFrequencyChart.Series.Add(series16);
            this.signalFrequencyChart.Size = new System.Drawing.Size(878, 304);
            this.signalFrequencyChart.TabIndex = 5;
            this.signalFrequencyChart.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel2.Controls.Add(this.newMeasureButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.openMeasureButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveMeasureButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.startStopMeasureButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitter1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.showFrequencyChartButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.showSignalsChartButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitter2, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.signalsChooseCheckedListBox, 8, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
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
            this.newMeasureButton.Size = new System.Drawing.Size(59, 76);
            this.newMeasureButton.TabIndex = 0;
            this.newMeasureButton.Text = "newMeasureButton";
            this.newMeasureButton.UseVisualStyleBackColor = true;
            // 
            // openMeasureButton
            // 
            this.openMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openMeasureButton.Location = new System.Drawing.Point(68, 3);
            this.openMeasureButton.Name = "openMeasureButton";
            this.openMeasureButton.Size = new System.Drawing.Size(62, 76);
            this.openMeasureButton.TabIndex = 1;
            this.openMeasureButton.Text = "openMeasureButton";
            this.openMeasureButton.UseVisualStyleBackColor = true;
            // 
            // saveMeasureButton
            // 
            this.saveMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMeasureButton.Location = new System.Drawing.Point(136, 3);
            this.saveMeasureButton.Name = "saveMeasureButton";
            this.saveMeasureButton.Size = new System.Drawing.Size(55, 76);
            this.saveMeasureButton.TabIndex = 2;
            this.saveMeasureButton.Text = "saveMeasureButton";
            this.saveMeasureButton.UseVisualStyleBackColor = true;
            // 
            // startStopMeasureButton
            // 
            this.startStopMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startStopMeasureButton.Location = new System.Drawing.Point(205, 3);
            this.startStopMeasureButton.Name = "startStopMeasureButton";
            this.startStopMeasureButton.Size = new System.Drawing.Size(68, 76);
            this.startStopMeasureButton.TabIndex = 3;
            this.startStopMeasureButton.Text = "startStopMeasure";
            this.startStopMeasureButton.UseVisualStyleBackColor = true;
            this.startStopMeasureButton.Click += new System.EventHandler(this.startStopMeasureButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(197, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 76);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // showFrequencyChartButton
            // 
            this.showFrequencyChartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showFrequencyChartButton.Location = new System.Drawing.Point(279, 3);
            this.showFrequencyChartButton.Name = "showFrequencyChartButton";
            this.showFrequencyChartButton.Size = new System.Drawing.Size(61, 76);
            this.showFrequencyChartButton.TabIndex = 5;
            this.showFrequencyChartButton.Text = "showFrequencyChart";
            this.showFrequencyChartButton.UseVisualStyleBackColor = true;
            this.showFrequencyChartButton.Click += new System.EventHandler(this.showFrequencyChartButton_Click);
            // 
            // showSignalsChartButton
            // 
            this.showSignalsChartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showSignalsChartButton.Location = new System.Drawing.Point(346, 3);
            this.showSignalsChartButton.Name = "showSignalsChartButton";
            this.showSignalsChartButton.Size = new System.Drawing.Size(65, 76);
            this.showSignalsChartButton.TabIndex = 6;
            this.showSignalsChartButton.Text = "showSignalsChart";
            this.showSignalsChartButton.UseVisualStyleBackColor = true;
            this.showSignalsChartButton.Click += new System.EventHandler(this.showSignalsChartButton_Click);
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter2.Location = new System.Drawing.Point(417, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 76);
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
            this.signalsChooseCheckedListBox.Location = new System.Drawing.Point(425, 3);
            this.signalsChooseCheckedListBox.Name = "signalsChooseCheckedListBox";
            this.signalsChooseCheckedListBox.Size = new System.Drawing.Size(167, 76);
            this.signalsChooseCheckedListBox.TabIndex = 9;
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
            this.communicationTabPage.Location = new System.Drawing.Point(104, 4);
            this.communicationTabPage.Name = "communicationTabPage";
            this.communicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.communicationTabPage.Size = new System.Drawing.Size(884, 730);
            this.communicationTabPage.TabIndex = 1;
            this.communicationTabPage.Text = "communicationTabPage";
            this.communicationTabPage.UseVisualStyleBackColor = true;
            // 
            // connectionSettingsTabPage
            // 
            this.connectionSettingsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.connectionSettingsTabPage.Location = new System.Drawing.Point(104, 4);
            this.connectionSettingsTabPage.Name = "connectionSettingsTabPage";
            this.connectionSettingsTabPage.Size = new System.Drawing.Size(884, 730);
            this.connectionSettingsTabPage.TabIndex = 2;
            this.connectionSettingsTabPage.Text = "connectionSettingsTabPage";
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
            this.chartsRefreshingTimer.Interval = 20;
            this.chartsRefreshingTimer.Tick += new System.EventHandler(this.chartsRefreshingTimer_Tick);
            // 
            // dataChartsTimer
            // 
            this.dataChartsTimer.Interval = 1;
            this.dataChartsTimer.Tick += new System.EventHandler(this.dataChartsTimer_Tick);
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
        private System.Windows.Forms.TabPage connectionSettingsTabPage;
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
    }
}

