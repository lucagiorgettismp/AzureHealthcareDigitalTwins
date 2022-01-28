
namespace Simulator.src
{
    partial class SimulationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.HeartFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BreathFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SaturationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BloodPressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TableDateHour = new System.Windows.Forms.TableLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MonitorLabel = new System.Windows.Forms.Label();
            this.TableValuesHeartFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.TableUpHeartFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.ValueHeartFrequency = new System.Windows.Forms.Label();
            this.PictureHeart = new System.Windows.Forms.PictureBox();
            this.TableTemperature = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTemperature = new System.Windows.Forms.Label();
            this.LabelUnitTemperature = new System.Windows.Forms.Label();
            this.ValueTemperatureLabel = new System.Windows.Forms.Label();
            this.TableSaturation = new System.Windows.Forms.TableLayoutPanel();
            this.ValueSaturationLabel = new System.Windows.Forms.Label();
            this.LabelUnitSaturation = new System.Windows.Forms.Label();
            this.LabelPatientMonitor = new System.Windows.Forms.Label();
            this.TableBloodPressure = new System.Windows.Forms.TableLayoutPanel();
            this.ValueBloodPressureLabel = new System.Windows.Forms.Label();
            this.LabelUnitBloodPressure = new System.Windows.Forms.Label();
            this.TableBreathFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.ValueBreathFrequencyLabel = new System.Windows.Forms.Label();
            this.LabelBreathFrequency = new System.Windows.Forms.Label();
            this.TableBattery = new System.Windows.Forms.TableLayoutPanel();
            this.BatteryLabel = new System.Windows.Forms.Label();
            this.ValueBatteryLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeartFrequencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodPressureChart)).BeginInit();
            this.TableDateHour.SuspendLayout();
            this.TableValuesHeartFrequency.SuspendLayout();
            this.TableUpHeartFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeart)).BeginInit();
            this.TableTemperature.SuspendLayout();
            this.TableSaturation.SuspendLayout();
            this.TableBloodPressure.SuspendLayout();
            this.TableBreathFrequency.SuspendLayout();
            this.TableBattery.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 641F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.MainTable.Controls.Add(this.HeartFrequencyChart, 0, 1);
            this.MainTable.Controls.Add(this.BreathFrequencyChart, 0, 2);
            this.MainTable.Controls.Add(this.SaturationChart, 0, 3);
            this.MainTable.Controls.Add(this.BloodPressureChart, 0, 4);
            this.MainTable.Controls.Add(this.TableDateHour, 1, 0);
            this.MainTable.Controls.Add(this.MonitorLabel, 0, 0);
            this.MainTable.Controls.Add(this.TableValuesHeartFrequency, 1, 1);
            this.MainTable.Controls.Add(this.TableSaturation, 1, 3);
            this.MainTable.Controls.Add(this.LabelPatientMonitor, 0, 5);
            this.MainTable.Controls.Add(this.TableBloodPressure, 1, 4);
            this.MainTable.Controls.Add(this.TableBreathFrequency, 1, 2);
            this.MainTable.Controls.Add(this.TableBattery, 1, 5);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 6;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.479733F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.479733F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // HeartFrequencyChart
            // 
            this.HeartFrequencyChart.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "HeartFrequencyChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.HeartFrequencyChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.HeartFrequencyChart.Legends.Add(legend1);
            this.HeartFrequencyChart.Location = new System.Drawing.Point(3, 27);
            this.HeartFrequencyChart.Name = "HeartFrequencyChart";
            this.HeartFrequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "HeartFrequencyChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Heart Frequency";
            series1.ShadowColor = System.Drawing.Color.Gray;
            this.HeartFrequencyChart.Series.Add(series1);
            this.HeartFrequencyChart.Size = new System.Drawing.Size(635, 94);
            this.HeartFrequencyChart.TabIndex = 0;
            this.HeartFrequencyChart.Text = "Heart Frequency";
            // 
            // BreathFrequencyChart
            // 
            this.BreathFrequencyChart.BackColor = System.Drawing.Color.Black;
            this.BreathFrequencyChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsMarksNextToAxis = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "BreathFrequencyChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.BreathFrequencyChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.BreathFrequencyChart.Legends.Add(legend2);
            this.BreathFrequencyChart.Location = new System.Drawing.Point(3, 127);
            this.BreathFrequencyChart.Name = "BreathFrequencyChart";
            this.BreathFrequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 3;
            series2.ChartArea = "BreathFrequencyChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Breath Frequency";
            this.BreathFrequencyChart.Series.Add(series2);
            this.BreathFrequencyChart.Size = new System.Drawing.Size(635, 94);
            this.BreathFrequencyChart.TabIndex = 1;
            this.BreathFrequencyChart.Text = "Breath Frequency";
            // 
            // SaturationChart
            // 
            this.SaturationChart.BackColor = System.Drawing.Color.Black;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "SaturationChartArea";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 100F;
            this.SaturationChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.SaturationChart.Legends.Add(legend3);
            this.SaturationChart.Location = new System.Drawing.Point(3, 227);
            this.SaturationChart.Name = "SaturationChart";
            this.SaturationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderWidth = 3;
            series3.ChartArea = "SaturationChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.LabelBackColor = System.Drawing.Color.Black;
            series3.LabelBorderColor = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Saturation";
            this.SaturationChart.Series.Add(series3);
            this.SaturationChart.Size = new System.Drawing.Size(635, 94);
            this.SaturationChart.TabIndex = 2;
            this.SaturationChart.Text = "Saturation";
            // 
            // BloodPressureChart
            // 
            this.BloodPressureChart.BackColor = System.Drawing.Color.Black;
            this.BloodPressureChart.BorderlineColor = System.Drawing.Color.Black;
            this.BloodPressureChart.BorderSkin.PageColor = System.Drawing.Color.Turquoise;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "BloodPressureChartArea";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 100F;
            this.BloodPressureChart.ChartAreas.Add(chartArea4);
            this.BloodPressureChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.BloodPressureChart.Legends.Add(legend4);
            this.BloodPressureChart.Location = new System.Drawing.Point(3, 327);
            this.BloodPressureChart.Name = "BloodPressureChart";
            this.BloodPressureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.BorderWidth = 3;
            series4.ChartArea = "BloodPressureChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Yellow;
            series4.Legend = "Legend1";
            series4.Name = "Blood Pressure";
            this.BloodPressureChart.Series.Add(series4);
            this.BloodPressureChart.Size = new System.Drawing.Size(635, 94);
            this.BloodPressureChart.TabIndex = 3;
            this.BloodPressureChart.Text = "Blood Pressure";
            // 
            // TableDateHour
            // 
            this.TableDateHour.ColumnCount = 2;
            this.TableDateHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableDateHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableDateHour.Controls.Add(this.DateLabel, 0, 0);
            this.TableDateHour.Controls.Add(this.HourLabel, 1, 0);
            this.TableDateHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDateHour.Location = new System.Drawing.Point(641, 0);
            this.TableDateHour.Margin = new System.Windows.Forms.Padding(0);
            this.TableDateHour.Name = "TableDateHour";
            this.TableDateHour.RowCount = 1;
            this.TableDateHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableDateHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableDateHour.Size = new System.Drawing.Size(159, 24);
            this.TableDateHour.TabIndex = 4;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DateLabel.Location = new System.Drawing.Point(2, 2);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(75, 20);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.HourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.HourLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HourLabel.Location = new System.Drawing.Point(81, 2);
            this.HourLabel.Margin = new System.Windows.Forms.Padding(2);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(76, 20);
            this.HourLabel.TabIndex = 1;
            this.HourLabel.Text = "Hour";
            this.HourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonitorLabel
            // 
            this.MonitorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MonitorLabel.AutoSize = true;
            this.MonitorLabel.BackColor = System.Drawing.Color.Black;
            this.MonitorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorLabel.ForeColor = System.Drawing.Color.White;
            this.MonitorLabel.Location = new System.Drawing.Point(278, 0);
            this.MonitorLabel.Name = "MonitorLabel";
            this.MonitorLabel.Size = new System.Drawing.Size(84, 24);
            this.MonitorLabel.TabIndex = 5;
            this.MonitorLabel.Text = "Monitor";
            this.MonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableValuesHeartFrequency
            // 
            this.TableValuesHeartFrequency.ColumnCount = 1;
            this.TableValuesHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableValuesHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableValuesHeartFrequency.Controls.Add(this.TableUpHeartFrequency, 0, 0);
            this.TableValuesHeartFrequency.Controls.Add(this.TableTemperature, 0, 1);
            this.TableValuesHeartFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableValuesHeartFrequency.Location = new System.Drawing.Point(644, 27);
            this.TableValuesHeartFrequency.Name = "TableValuesHeartFrequency";
            this.TableValuesHeartFrequency.RowCount = 2;
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.31915F));
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.68085F));
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableValuesHeartFrequency.Size = new System.Drawing.Size(153, 94);
            this.TableValuesHeartFrequency.TabIndex = 6;
            // 
            // TableUpHeartFrequency
            // 
            this.TableUpHeartFrequency.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableUpHeartFrequency.ColumnCount = 2;
            this.TableUpHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.25504F));
            this.TableUpHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.74496F));
            this.TableUpHeartFrequency.Controls.Add(this.ValueHeartFrequency, 1, 0);
            this.TableUpHeartFrequency.Controls.Add(this.PictureHeart, 0, 0);
            this.TableUpHeartFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableUpHeartFrequency.Location = new System.Drawing.Point(2, 2);
            this.TableUpHeartFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.TableUpHeartFrequency.Name = "TableUpHeartFrequency";
            this.TableUpHeartFrequency.RowCount = 1;
            this.TableUpHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableUpHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableUpHeartFrequency.Size = new System.Drawing.Size(149, 48);
            this.TableUpHeartFrequency.TabIndex = 0;
            // 
            // ValueHeartFrequency
            // 
            this.ValueHeartFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueHeartFrequency.AutoSize = true;
            this.ValueHeartFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueHeartFrequency.ForeColor = System.Drawing.Color.Green;
            this.ValueHeartFrequency.Location = new System.Drawing.Point(60, 0);
            this.ValueHeartFrequency.Name = "ValueHeartFrequency";
            this.ValueHeartFrequency.Size = new System.Drawing.Size(86, 48);
            this.ValueHeartFrequency.TabIndex = 0;
            this.ValueHeartFrequency.Text = "Value";
            this.ValueHeartFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureHeart
            // 
            this.PictureHeart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureHeart.Image = ((System.Drawing.Image)(resources.GetObject("PictureHeart.Image")));
            this.PictureHeart.InitialImage = null;
            this.PictureHeart.Location = new System.Drawing.Point(3, 22);
            this.PictureHeart.Name = "PictureHeart";
            this.PictureHeart.Size = new System.Drawing.Size(25, 23);
            this.PictureHeart.TabIndex = 1;
            this.PictureHeart.TabStop = false;
            // 
            // TableTemperature
            // 
            this.TableTemperature.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableTemperature.ColumnCount = 2;
            this.TableTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.TableTemperature.Controls.Add(this.LabelTemperature, 0, 0);
            this.TableTemperature.Controls.Add(this.LabelUnitTemperature, 0, 1);
            this.TableTemperature.Controls.Add(this.ValueTemperatureLabel, 1, 0);
            this.TableTemperature.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableTemperature.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableTemperature.Location = new System.Drawing.Point(2, 54);
            this.TableTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.TableTemperature.Name = "TableTemperature";
            this.TableTemperature.RowCount = 2;
            this.TableTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.TableTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.TableTemperature.Size = new System.Drawing.Size(149, 38);
            this.TableTemperature.TabIndex = 1;
            // 
            // LabelTemperature
            // 
            this.LabelTemperature.AutoSize = true;
            this.LabelTemperature.BackColor = System.Drawing.SystemColors.Desktop;
            this.LabelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTemperature.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelTemperature.Location = new System.Drawing.Point(3, 0);
            this.LabelTemperature.Name = "LabelTemperature";
            this.LabelTemperature.Size = new System.Drawing.Size(50, 17);
            this.LabelTemperature.TabIndex = 0;
            this.LabelTemperature.Text = "TEMP";
            // 
            // LabelUnitTemperature
            // 
            this.LabelUnitTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelUnitTemperature.AutoSize = true;
            this.LabelUnitTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitTemperature.Location = new System.Drawing.Point(3, 23);
            this.LabelUnitTemperature.Name = "LabelUnitTemperature";
            this.LabelUnitTemperature.Size = new System.Drawing.Size(25, 15);
            this.LabelUnitTemperature.TabIndex = 1;
            this.LabelUnitTemperature.Text = "°C";
            // 
            // ValueTemperatureLabel
            // 
            this.ValueTemperatureLabel.AutoSize = true;
            this.ValueTemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTemperatureLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ValueTemperatureLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ValueTemperatureLabel.Location = new System.Drawing.Point(60, 0);
            this.ValueTemperatureLabel.Name = "ValueTemperatureLabel";
            this.ValueTemperatureLabel.Size = new System.Drawing.Size(86, 23);
            this.ValueTemperatureLabel.TabIndex = 2;
            this.ValueTemperatureLabel.Text = "Value";
            this.ValueTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableSaturation
            // 
            this.TableSaturation.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableSaturation.ColumnCount = 2;
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.TableSaturation.Controls.Add(this.ValueSaturationLabel, 1, 0);
            this.TableSaturation.Controls.Add(this.LabelUnitSaturation, 0, 0);
            this.TableSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableSaturation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableSaturation.Location = new System.Drawing.Point(644, 227);
            this.TableSaturation.Name = "TableSaturation";
            this.TableSaturation.RowCount = 1;
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableSaturation.Size = new System.Drawing.Size(153, 94);
            this.TableSaturation.TabIndex = 7;
            // 
            // ValueSaturationLabel
            // 
            this.ValueSaturationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueSaturationLabel.AutoSize = true;
            this.ValueSaturationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueSaturationLabel.ForeColor = System.Drawing.Color.Red;
            this.ValueSaturationLabel.Location = new System.Drawing.Point(63, 0);
            this.ValueSaturationLabel.Name = "ValueSaturationLabel";
            this.ValueSaturationLabel.Size = new System.Drawing.Size(87, 94);
            this.ValueSaturationLabel.TabIndex = 0;
            this.ValueSaturationLabel.Text = "Value";
            this.ValueSaturationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUnitSaturation
            // 
            this.LabelUnitSaturation.AutoSize = true;
            this.LabelUnitSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitSaturation.Location = new System.Drawing.Point(3, 0);
            this.LabelUnitSaturation.Name = "LabelUnitSaturation";
            this.LabelUnitSaturation.Size = new System.Drawing.Size(48, 17);
            this.LabelUnitSaturation.TabIndex = 1;
            this.LabelUnitSaturation.Text = "SpO2";
            // 
            // LabelPatientMonitor
            // 
            this.LabelPatientMonitor.AutoSize = true;
            this.LabelPatientMonitor.BackColor = System.Drawing.SystemColors.Desktop;
            this.LabelPatientMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPatientMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPatientMonitor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelPatientMonitor.Location = new System.Drawing.Point(3, 424);
            this.LabelPatientMonitor.Name = "LabelPatientMonitor";
            this.LabelPatientMonitor.Size = new System.Drawing.Size(635, 26);
            this.LabelPatientMonitor.TabIndex = 8;
            this.LabelPatientMonitor.Text = "Patient Monitor";
            this.LabelPatientMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPatientMonitor.UseMnemonic = false;
            // 
            // TableBloodPressure
            // 
            this.TableBloodPressure.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableBloodPressure.ColumnCount = 2;
            this.TableBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.56209F));
            this.TableBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.43791F));
            this.TableBloodPressure.Controls.Add(this.ValueBloodPressureLabel, 1, 0);
            this.TableBloodPressure.Controls.Add(this.LabelUnitBloodPressure, 0, 0);
            this.TableBloodPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBloodPressure.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TableBloodPressure.Location = new System.Drawing.Point(644, 327);
            this.TableBloodPressure.Name = "TableBloodPressure";
            this.TableBloodPressure.RowCount = 1;
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableBloodPressure.Size = new System.Drawing.Size(153, 94);
            this.TableBloodPressure.TabIndex = 9;
            // 
            // ValueBloodPressureLabel
            // 
            this.ValueBloodPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBloodPressureLabel.AutoSize = true;
            this.ValueBloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBloodPressureLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ValueBloodPressureLabel.Location = new System.Drawing.Point(62, 0);
            this.ValueBloodPressureLabel.Name = "ValueBloodPressureLabel";
            this.ValueBloodPressureLabel.Size = new System.Drawing.Size(88, 94);
            this.ValueBloodPressureLabel.TabIndex = 0;
            this.ValueBloodPressureLabel.Text = "Value";
            this.ValueBloodPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUnitBloodPressure
            // 
            this.LabelUnitBloodPressure.AutoSize = true;
            this.LabelUnitBloodPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitBloodPressure.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelUnitBloodPressure.Location = new System.Drawing.Point(3, 0);
            this.LabelUnitBloodPressure.Name = "LabelUnitBloodPressure";
            this.LabelUnitBloodPressure.Size = new System.Drawing.Size(52, 17);
            this.LabelUnitBloodPressure.TabIndex = 1;
            this.LabelUnitBloodPressure.Text = "mmHg";
            // 
            // TableBreathFrequency
            // 
            this.TableBreathFrequency.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableBreathFrequency.ColumnCount = 2;
            this.TableBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.TableBreathFrequency.Controls.Add(this.ValueBreathFrequencyLabel, 1, 0);
            this.TableBreathFrequency.Controls.Add(this.LabelBreathFrequency, 0, 0);
            this.TableBreathFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBreathFrequency.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableBreathFrequency.Location = new System.Drawing.Point(644, 127);
            this.TableBreathFrequency.Name = "TableBreathFrequency";
            this.TableBreathFrequency.RowCount = 1;
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableBreathFrequency.Size = new System.Drawing.Size(153, 94);
            this.TableBreathFrequency.TabIndex = 10;
            // 
            // ValueBreathFrequencyLabel
            // 
            this.ValueBreathFrequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBreathFrequencyLabel.AutoSize = true;
            this.ValueBreathFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBreathFrequencyLabel.ForeColor = System.Drawing.Color.Green;
            this.ValueBreathFrequencyLabel.Location = new System.Drawing.Point(63, 0);
            this.ValueBreathFrequencyLabel.Name = "ValueBreathFrequencyLabel";
            this.ValueBreathFrequencyLabel.Size = new System.Drawing.Size(87, 94);
            this.ValueBreathFrequencyLabel.TabIndex = 0;
            this.ValueBreathFrequencyLabel.Text = "Value";
            this.ValueBreathFrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBreathFrequency
            // 
            this.LabelBreathFrequency.AutoSize = true;
            this.LabelBreathFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBreathFrequency.Location = new System.Drawing.Point(3, 0);
            this.LabelBreathFrequency.Name = "LabelBreathFrequency";
            this.LabelBreathFrequency.Size = new System.Drawing.Size(41, 17);
            this.LabelBreathFrequency.TabIndex = 1;
            this.LabelBreathFrequency.Text = "RPM";
            // 
            // TableBattery
            // 
            this.TableBattery.ColumnCount = 2;
            this.TableBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.52288F));
            this.TableBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.47712F));
            this.TableBattery.Controls.Add(this.BatteryLabel, 0, 0);
            this.TableBattery.Controls.Add(this.ValueBatteryLabel, 1, 0);
            this.TableBattery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBattery.Location = new System.Drawing.Point(644, 427);
            this.TableBattery.Name = "TableBattery";
            this.TableBattery.RowCount = 1;
            this.TableBattery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBattery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableBattery.Size = new System.Drawing.Size(153, 20);
            this.TableBattery.TabIndex = 11;
            // 
            // BatteryLabel
            // 
            this.BatteryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatteryLabel.AutoSize = true;
            this.BatteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BatteryLabel.Location = new System.Drawing.Point(3, 0);
            this.BatteryLabel.Name = "BatteryLabel";
            this.BatteryLabel.Size = new System.Drawing.Size(56, 20);
            this.BatteryLabel.TabIndex = 0;
            this.BatteryLabel.Text = "Battery";
            this.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValueBatteryLabel
            // 
            this.ValueBatteryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBatteryLabel.AutoSize = true;
            this.ValueBatteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBatteryLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ValueBatteryLabel.Location = new System.Drawing.Point(65, 0);
            this.ValueBatteryLabel.Name = "ValueBatteryLabel";
            this.ValueBatteryLabel.Size = new System.Drawing.Size(85, 20);
            this.ValueBatteryLabel.TabIndex = 1;
            this.ValueBatteryLabel.Text = "Value";
            this.ValueBatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTable);
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.Load += new System.EventHandler(this.SimulationForm_Load);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeartFrequencyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequencyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodPressureChart)).EndInit();
            this.TableDateHour.ResumeLayout(false);
            this.TableDateHour.PerformLayout();
            this.TableValuesHeartFrequency.ResumeLayout(false);
            this.TableUpHeartFrequency.ResumeLayout(false);
            this.TableUpHeartFrequency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeart)).EndInit();
            this.TableTemperature.ResumeLayout(false);
            this.TableTemperature.PerformLayout();
            this.TableSaturation.ResumeLayout(false);
            this.TableSaturation.PerformLayout();
            this.TableBloodPressure.ResumeLayout(false);
            this.TableBloodPressure.PerformLayout();
            this.TableBreathFrequency.ResumeLayout(false);
            this.TableBreathFrequency.PerformLayout();
            this.TableBattery.ResumeLayout(false);
            this.TableBattery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart HeartFrequencyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BreathFrequencyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SaturationChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BloodPressureChart;
        private System.Windows.Forms.TableLayoutPanel TableDateHour;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MonitorLabel;
        private System.Windows.Forms.TableLayoutPanel TableValuesHeartFrequency;
        private System.Windows.Forms.TableLayoutPanel TableUpHeartFrequency;
        private System.Windows.Forms.Label ValueHeartFrequency;
        private System.Windows.Forms.PictureBox PictureHeart;
        private System.Windows.Forms.TableLayoutPanel TableTemperature;
        private System.Windows.Forms.Label LabelTemperature;
        private System.Windows.Forms.Label LabelUnitTemperature;
        private System.Windows.Forms.Label ValueTemperatureLabel;
        private System.Windows.Forms.TableLayoutPanel TableSaturation;
        private System.Windows.Forms.Label ValueSaturationLabel;
        private System.Windows.Forms.Label LabelUnitSaturation;
        private System.Windows.Forms.Label LabelPatientMonitor;
        private System.Windows.Forms.TableLayoutPanel TableBloodPressure;
        private System.Windows.Forms.Label ValueBloodPressureLabel;
        private System.Windows.Forms.Label LabelUnitBloodPressure;
        private System.Windows.Forms.TableLayoutPanel TableBreathFrequency;
        private System.Windows.Forms.Label ValueBreathFrequencyLabel;
        private System.Windows.Forms.Label LabelBreathFrequency;
        private System.Windows.Forms.TableLayoutPanel TableBattery;
        private System.Windows.Forms.Label BatteryLabel;
        private System.Windows.Forms.Label ValueBatteryLabel;
    }
}