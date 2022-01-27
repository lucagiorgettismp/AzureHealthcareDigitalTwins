
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
            this.HeartFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BreathFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Saturation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BloodPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.LabelValueSaturation = new System.Windows.Forms.Label();
            this.LabelUnitSaturation = new System.Windows.Forms.Label();
            this.LabelPatientMonitor = new System.Windows.Forms.Label();
            this.TableBloodPressure = new System.Windows.Forms.TableLayoutPanel();
            this.LabelValueBloodPressure = new System.Windows.Forms.Label();
            this.LabelUnitBloodPressure = new System.Windows.Forms.Label();
            this.TableBreathFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelBreathFrequency = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeartFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodPressure)).BeginInit();
            this.TableDateHour.SuspendLayout();
            this.TableValuesHeartFrequency.SuspendLayout();
            this.TableUpHeartFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeart)).BeginInit();
            this.TableTemperature.SuspendLayout();
            this.TableSaturation.SuspendLayout();
            this.TableBloodPressure.SuspendLayout();
            this.TableBreathFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 641F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.MainTable.Controls.Add(this.HeartFrequency, 0, 1);
            this.MainTable.Controls.Add(this.BreathFrequency, 0, 2);
            this.MainTable.Controls.Add(this.Saturation, 0, 3);
            this.MainTable.Controls.Add(this.BloodPressure, 0, 4);
            this.MainTable.Controls.Add(this.TableDateHour, 1, 0);
            this.MainTable.Controls.Add(this.MonitorLabel, 0, 0);
            this.MainTable.Controls.Add(this.TableValuesHeartFrequency, 1, 1);
            this.MainTable.Controls.Add(this.TableSaturation, 1, 3);
            this.MainTable.Controls.Add(this.LabelPatientMonitor, 0, 5);
            this.MainTable.Controls.Add(this.TableBloodPressure, 1, 4);
            this.MainTable.Controls.Add(this.TableBreathFrequency, 1, 2);
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
            // HeartFrequency
            // 
            chartArea1.Name = "ChartArea1";
            this.HeartFrequency.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HeartFrequency.Legends.Add(legend1);
            this.HeartFrequency.Location = new System.Drawing.Point(3, 27);
            this.HeartFrequency.Name = "HeartFrequency";
            this.HeartFrequency.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Heart Frequency";
            series1.ShadowColor = System.Drawing.Color.Gray;
            this.HeartFrequency.Series.Add(series1);
            this.HeartFrequency.Size = new System.Drawing.Size(635, 94);
            this.HeartFrequency.TabIndex = 0;
            this.HeartFrequency.Text = "Heart Frequency";
            // 
            // BreathFrequency
            // 
            chartArea2.Name = "ChartArea1";
            this.BreathFrequency.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.BreathFrequency.Legends.Add(legend2);
            this.BreathFrequency.Location = new System.Drawing.Point(3, 127);
            this.BreathFrequency.Name = "BreathFrequency";
            this.BreathFrequency.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Breath Frequency";
            this.BreathFrequency.Series.Add(series2);
            this.BreathFrequency.Size = new System.Drawing.Size(635, 94);
            this.BreathFrequency.TabIndex = 1;
            this.BreathFrequency.Text = "Breath Frequency";
            // 
            // Saturation
            // 
            chartArea3.Name = "ChartArea1";
            this.Saturation.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Saturation.Legends.Add(legend3);
            this.Saturation.Location = new System.Drawing.Point(3, 227);
            this.Saturation.Name = "Saturation";
            this.Saturation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.LabelBackColor = System.Drawing.Color.Black;
            series3.LabelBorderColor = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Saturation";
            this.Saturation.Series.Add(series3);
            this.Saturation.Size = new System.Drawing.Size(635, 94);
            this.Saturation.TabIndex = 2;
            this.Saturation.Text = "Saturation";
            // 
            // BloodPressure
            // 
            this.BloodPressure.BorderSkin.PageColor = System.Drawing.Color.Turquoise;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.BloodPressure.ChartAreas.Add(chartArea4);
            this.BloodPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.BloodPressure.Legends.Add(legend4);
            this.BloodPressure.Location = new System.Drawing.Point(3, 327);
            this.BloodPressure.Name = "BloodPressure";
            this.BloodPressure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Yellow;
            series4.Legend = "Legend1";
            series4.Name = "Blood Pressure";
            this.BloodPressure.Series.Add(series4);
            this.BloodPressure.Size = new System.Drawing.Size(635, 94);
            this.BloodPressure.TabIndex = 3;
            this.BloodPressure.Text = "Blood Pressure";
            this.BloodPressure.Visible = false;
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
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(2, 2);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(75, 20);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.HourLabel.Location = new System.Drawing.Point(81, 2);
            this.HourLabel.Margin = new System.Windows.Forms.Padding(2);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(76, 20);
            this.HourLabel.TabIndex = 1;
            this.HourLabel.Text = "Hour";
            this.HourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitorLabel
            // 
            this.MonitorLabel.AutoSize = true;
            this.MonitorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonitorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorLabel.Location = new System.Drawing.Point(3, 0);
            this.MonitorLabel.Name = "MonitorLabel";
            this.MonitorLabel.Size = new System.Drawing.Size(635, 24);
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
            this.TableTemperature.ColumnCount = 2;
            this.TableTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.TableTemperature.Controls.Add(this.LabelTemperature, 0, 0);
            this.TableTemperature.Controls.Add(this.LabelUnitTemperature, 0, 1);
            this.TableTemperature.Controls.Add(this.ValueTemperatureLabel, 1, 0);
            this.TableTemperature.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.LabelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ValueTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TableSaturation.ColumnCount = 2;
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.TableSaturation.Controls.Add(this.LabelValueSaturation, 1, 0);
            this.TableSaturation.Controls.Add(this.LabelUnitSaturation, 0, 0);
            this.TableSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableSaturation.Location = new System.Drawing.Point(644, 227);
            this.TableSaturation.Name = "TableSaturation";
            this.TableSaturation.RowCount = 1;
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableSaturation.Size = new System.Drawing.Size(153, 94);
            this.TableSaturation.TabIndex = 7;
            // 
            // LabelValueSaturation
            // 
            this.LabelValueSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelValueSaturation.AutoSize = true;
            this.LabelValueSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueSaturation.Location = new System.Drawing.Point(63, 0);
            this.LabelValueSaturation.Name = "LabelValueSaturation";
            this.LabelValueSaturation.Size = new System.Drawing.Size(87, 94);
            this.LabelValueSaturation.TabIndex = 0;
            this.LabelValueSaturation.Text = "Value";
            this.LabelValueSaturation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LabelPatientMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPatientMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TableBloodPressure.ColumnCount = 2;
            this.TableBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.56209F));
            this.TableBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.43791F));
            this.TableBloodPressure.Controls.Add(this.LabelValueBloodPressure, 1, 0);
            this.TableBloodPressure.Controls.Add(this.LabelUnitBloodPressure, 0, 0);
            this.TableBloodPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBloodPressure.Location = new System.Drawing.Point(644, 327);
            this.TableBloodPressure.Name = "TableBloodPressure";
            this.TableBloodPressure.RowCount = 1;
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableBloodPressure.Size = new System.Drawing.Size(153, 94);
            this.TableBloodPressure.TabIndex = 9;
            // 
            // LabelValueBloodPressure
            // 
            this.LabelValueBloodPressure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelValueBloodPressure.AutoSize = true;
            this.LabelValueBloodPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueBloodPressure.Location = new System.Drawing.Point(62, 0);
            this.LabelValueBloodPressure.Name = "LabelValueBloodPressure";
            this.LabelValueBloodPressure.Size = new System.Drawing.Size(88, 94);
            this.LabelValueBloodPressure.TabIndex = 0;
            this.LabelValueBloodPressure.Text = "Value";
            this.LabelValueBloodPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUnitBloodPressure
            // 
            this.LabelUnitBloodPressure.AutoSize = true;
            this.LabelUnitBloodPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitBloodPressure.Location = new System.Drawing.Point(3, 0);
            this.LabelUnitBloodPressure.Name = "LabelUnitBloodPressure";
            this.LabelUnitBloodPressure.Size = new System.Drawing.Size(52, 17);
            this.LabelUnitBloodPressure.TabIndex = 1;
            this.LabelUnitBloodPressure.Text = "mmHg";
            // 
            // TableBreathFrequency
            // 
            this.TableBreathFrequency.ColumnCount = 2;
            this.TableBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.TableBreathFrequency.Controls.Add(this.label1, 1, 0);
            this.TableBreathFrequency.Controls.Add(this.LabelBreathFrequency, 0, 0);
            this.TableBreathFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBreathFrequency.Location = new System.Drawing.Point(644, 127);
            this.TableBreathFrequency.Name = "TableBreathFrequency";
            this.TableBreathFrequency.RowCount = 1;
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableBreathFrequency.Size = new System.Drawing.Size(153, 94);
            this.TableBreathFrequency.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTable);
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeartFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodPressure)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart HeartFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart BreathFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart Saturation;
        private System.Windows.Forms.DataVisualization.Charting.Chart BloodPressure;
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
        private System.Windows.Forms.Label LabelValueSaturation;
        private System.Windows.Forms.Label LabelUnitSaturation;
        private System.Windows.Forms.Label LabelPatientMonitor;
        private System.Windows.Forms.TableLayoutPanel TableBloodPressure;
        private System.Windows.Forms.Label LabelValueBloodPressure;
        private System.Windows.Forms.Label LabelUnitBloodPressure;
        private System.Windows.Forms.TableLayoutPanel TableBreathFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelBreathFrequency;
    }
}