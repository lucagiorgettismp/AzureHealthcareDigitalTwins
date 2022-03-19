
namespace Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.TableDateHour = new System.Windows.Forms.TableLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MonitorLabel = new System.Windows.Forms.Label();
            this.TableValuesHeartFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.TableUpHeartFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.ValueHeartFrequency = new System.Windows.Forms.Label();
            this.PictureHeart = new System.Windows.Forms.PictureBox();
            this.TableTemperature = new System.Windows.Forms.TableLayoutPanel();
            this.ValueTemperatureLabel = new System.Windows.Forms.Label();
            this.AlarmTemperature = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTemprature = new System.Windows.Forms.Label();
            this.LabelUnitTemperature = new System.Windows.Forms.Label();
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
            this.AlarmBattery = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeartFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlarmHeartFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BreathFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlarmBreathFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SaturationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlarmSaturation = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BloodPressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlarmBloodPressure = new System.Windows.Forms.TableLayoutPanel();
            this.MainTable.SuspendLayout();
            this.TableDateHour.SuspendLayout();
            this.TableValuesHeartFrequency.SuspendLayout();
            this.TableUpHeartFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeart)).BeginInit();
            this.TableTemperature.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TableSaturation.SuspendLayout();
            this.TableBloodPressure.SuspendLayout();
            this.TableBreathFrequency.SuspendLayout();
            this.TableBattery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeartFrequencyChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequencyChart)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationChart)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodPressureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 635F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.MainTable.Controls.Add(this.TableDateHour, 1, 0);
            this.MainTable.Controls.Add(this.MonitorLabel, 0, 0);
            this.MainTable.Controls.Add(this.TableValuesHeartFrequency, 1, 1);
            this.MainTable.Controls.Add(this.TableSaturation, 1, 3);
            this.MainTable.Controls.Add(this.LabelPatientMonitor, 0, 5);
            this.MainTable.Controls.Add(this.TableBloodPressure, 1, 4);
            this.MainTable.Controls.Add(this.TableBreathFrequency, 1, 2);
            this.MainTable.Controls.Add(this.TableBattery, 1, 5);
            this.MainTable.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.MainTable.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.MainTable.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.MainTable.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 7;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.479733F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26013F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.479733F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.MainTable.Size = new System.Drawing.Size(812, 447);
            this.MainTable.TabIndex = 0;
            // 
            // TableDateHour
            // 
            this.TableDateHour.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableDateHour.ColumnCount = 2;
            this.TableDateHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableDateHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableDateHour.Controls.Add(this.DateLabel, 0, 0);
            this.TableDateHour.Controls.Add(this.HourLabel, 1, 0);
            this.TableDateHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDateHour.Location = new System.Drawing.Point(635, 0);
            this.TableDateHour.Margin = new System.Windows.Forms.Padding(0);
            this.TableDateHour.Name = "TableDateHour";
            this.TableDateHour.RowCount = 1;
            this.TableDateHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableDateHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableDateHour.Size = new System.Drawing.Size(177, 24);
            this.TableDateHour.TabIndex = 4;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DateLabel.Location = new System.Drawing.Point(4, 4);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(81, 16);
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
            this.HourLabel.Location = new System.Drawing.Point(91, 4);
            this.HourLabel.Margin = new System.Windows.Forms.Padding(2);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(82, 16);
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
            this.MonitorLabel.Location = new System.Drawing.Point(275, 0);
            this.MonitorLabel.Name = "MonitorLabel";
            this.MonitorLabel.Size = new System.Drawing.Size(84, 24);
            this.MonitorLabel.TabIndex = 5;
            this.MonitorLabel.Text = "Monitor";
            this.MonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableValuesHeartFrequency
            // 
            this.TableValuesHeartFrequency.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableValuesHeartFrequency.ColumnCount = 1;
            this.TableValuesHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableValuesHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableValuesHeartFrequency.Controls.Add(this.TableUpHeartFrequency, 0, 0);
            this.TableValuesHeartFrequency.Controls.Add(this.TableTemperature, 0, 1);
            this.TableValuesHeartFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableValuesHeartFrequency.Location = new System.Drawing.Point(638, 27);
            this.TableValuesHeartFrequency.Name = "TableValuesHeartFrequency";
            this.TableValuesHeartFrequency.RowCount = 2;
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.31915F));
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.68085F));
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableValuesHeartFrequency.Size = new System.Drawing.Size(171, 91);
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
            this.TableUpHeartFrequency.Location = new System.Drawing.Point(4, 4);
            this.TableUpHeartFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.TableUpHeartFrequency.Name = "TableUpHeartFrequency";
            this.TableUpHeartFrequency.RowCount = 1;
            this.TableUpHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableUpHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.TableUpHeartFrequency.Size = new System.Drawing.Size(163, 43);
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
            this.ValueHeartFrequency.Location = new System.Drawing.Point(65, 0);
            this.ValueHeartFrequency.Name = "ValueHeartFrequency";
            this.ValueHeartFrequency.Size = new System.Drawing.Size(95, 43);
            this.ValueHeartFrequency.TabIndex = 0;
            this.ValueHeartFrequency.Text = "Value";
            this.ValueHeartFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureHeart
            // 
            this.PictureHeart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureHeart.Image = ((System.Drawing.Image)(resources.GetObject("PictureHeart.Image")));
            this.PictureHeart.InitialImage = null;
            this.PictureHeart.Location = new System.Drawing.Point(3, 17);
            this.PictureHeart.Name = "PictureHeart";
            this.PictureHeart.Size = new System.Drawing.Size(25, 23);
            this.PictureHeart.TabIndex = 1;
            this.PictureHeart.TabStop = false;
            // 
            // TableTemperature
            // 
            this.TableTemperature.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableTemperature.ColumnCount = 3;
            this.TableTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TableTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableTemperature.Controls.Add(this.ValueTemperatureLabel, 1, 0);
            this.TableTemperature.Controls.Add(this.AlarmTemperature, 2, 0);
            this.TableTemperature.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.TableTemperature.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableTemperature.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableTemperature.Location = new System.Drawing.Point(4, 53);
            this.TableTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.TableTemperature.Name = "TableTemperature";
            this.TableTemperature.RowCount = 1;
            this.TableTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableTemperature.Size = new System.Drawing.Size(163, 34);
            this.TableTemperature.TabIndex = 1;
            // 
            // ValueTemperatureLabel
            // 
            this.ValueTemperatureLabel.AutoSize = true;
            this.ValueTemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTemperatureLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ValueTemperatureLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ValueTemperatureLabel.Location = new System.Drawing.Point(61, 0);
            this.ValueTemperatureLabel.Name = "ValueTemperatureLabel";
            this.ValueTemperatureLabel.Size = new System.Drawing.Size(70, 34);
            this.ValueTemperatureLabel.TabIndex = 2;
            this.ValueTemperatureLabel.Text = "Value";
            this.ValueTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlarmTemperature
            // 
            this.AlarmTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlarmTemperature.BackColor = System.Drawing.Color.Black;
            this.AlarmTemperature.ColumnCount = 2;
            this.AlarmTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmTemperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmTemperature.Location = new System.Drawing.Point(141, 9);
            this.AlarmTemperature.Name = "AlarmTemperature";
            this.AlarmTemperature.RowCount = 2;
            this.AlarmTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmTemperature.Size = new System.Drawing.Size(15, 15);
            this.AlarmTemperature.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.LabelTemprature, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelUnitTemperature, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(52, 28);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // LabelTemprature
            // 
            this.LabelTemprature.AutoSize = true;
            this.LabelTemprature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTemprature.Location = new System.Drawing.Point(3, 0);
            this.LabelTemprature.Name = "LabelTemprature";
            this.LabelTemprature.Size = new System.Drawing.Size(38, 13);
            this.LabelTemprature.TabIndex = 0;
            this.LabelTemprature.Text = "Temp";
            // 
            // LabelUnitTemperature
            // 
            this.LabelUnitTemperature.AutoSize = true;
            this.LabelUnitTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitTemperature.Location = new System.Drawing.Point(3, 14);
            this.LabelUnitTemperature.Name = "LabelUnitTemperature";
            this.LabelUnitTemperature.Size = new System.Drawing.Size(20, 13);
            this.LabelUnitTemperature.TabIndex = 1;
            this.LabelUnitTemperature.Text = "°C";
            // 
            // TableSaturation
            // 
            this.TableSaturation.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableSaturation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableSaturation.ColumnCount = 2;
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.TableSaturation.Controls.Add(this.ValueSaturationLabel, 1, 0);
            this.TableSaturation.Controls.Add(this.LabelUnitSaturation, 0, 0);
            this.TableSaturation.Cursor = System.Windows.Forms.Cursors.Default;
            this.TableSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableSaturation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableSaturation.Location = new System.Drawing.Point(638, 221);
            this.TableSaturation.Name = "TableSaturation";
            this.TableSaturation.RowCount = 1;
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.TableSaturation.Size = new System.Drawing.Size(171, 91);
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
            this.ValueSaturationLabel.Location = new System.Drawing.Point(67, 2);
            this.ValueSaturationLabel.Name = "ValueSaturationLabel";
            this.ValueSaturationLabel.Size = new System.Drawing.Size(99, 87);
            this.ValueSaturationLabel.TabIndex = 0;
            this.ValueSaturationLabel.Text = "Value";
            this.ValueSaturationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUnitSaturation
            // 
            this.LabelUnitSaturation.AutoSize = true;
            this.LabelUnitSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitSaturation.Location = new System.Drawing.Point(5, 2);
            this.LabelUnitSaturation.Name = "LabelUnitSaturation";
            this.LabelUnitSaturation.Size = new System.Drawing.Size(27, 22);
            this.LabelUnitSaturation.TabIndex = 1;
            this.LabelUnitSaturation.Text = "%";
            // 
            // LabelPatientMonitor
            // 
            this.LabelPatientMonitor.AutoSize = true;
            this.LabelPatientMonitor.BackColor = System.Drawing.SystemColors.Desktop;
            this.LabelPatientMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPatientMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPatientMonitor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelPatientMonitor.Location = new System.Drawing.Point(3, 412);
            this.LabelPatientMonitor.Name = "LabelPatientMonitor";
            this.LabelPatientMonitor.Size = new System.Drawing.Size(629, 24);
            this.LabelPatientMonitor.TabIndex = 8;
            this.LabelPatientMonitor.Text = "Patient Monitor";
            this.LabelPatientMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPatientMonitor.UseMnemonic = false;
            // 
            // TableBloodPressure
            // 
            this.TableBloodPressure.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableBloodPressure.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableBloodPressure.ColumnCount = 2;
            this.TableBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.56209F));
            this.TableBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.43791F));
            this.TableBloodPressure.Controls.Add(this.ValueBloodPressureLabel, 1, 0);
            this.TableBloodPressure.Controls.Add(this.LabelUnitBloodPressure, 0, 0);
            this.TableBloodPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBloodPressure.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TableBloodPressure.Location = new System.Drawing.Point(638, 318);
            this.TableBloodPressure.Name = "TableBloodPressure";
            this.TableBloodPressure.RowCount = 1;
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.TableBloodPressure.Size = new System.Drawing.Size(171, 91);
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
            this.ValueBloodPressureLabel.Location = new System.Drawing.Point(70, 2);
            this.ValueBloodPressureLabel.Name = "ValueBloodPressureLabel";
            this.ValueBloodPressureLabel.Size = new System.Drawing.Size(96, 87);
            this.ValueBloodPressureLabel.TabIndex = 0;
            this.ValueBloodPressureLabel.Text = "Value";
            this.ValueBloodPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUnitBloodPressure
            // 
            this.LabelUnitBloodPressure.AutoSize = true;
            this.LabelUnitBloodPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitBloodPressure.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelUnitBloodPressure.Location = new System.Drawing.Point(5, 2);
            this.LabelUnitBloodPressure.Name = "LabelUnitBloodPressure";
            this.LabelUnitBloodPressure.Size = new System.Drawing.Size(52, 17);
            this.LabelUnitBloodPressure.TabIndex = 1;
            this.LabelUnitBloodPressure.Text = "mmHg";
            // 
            // TableBreathFrequency
            // 
            this.TableBreathFrequency.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableBreathFrequency.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableBreathFrequency.ColumnCount = 2;
            this.TableBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.TableBreathFrequency.Controls.Add(this.ValueBreathFrequencyLabel, 1, 0);
            this.TableBreathFrequency.Controls.Add(this.LabelBreathFrequency, 0, 0);
            this.TableBreathFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBreathFrequency.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableBreathFrequency.Location = new System.Drawing.Point(638, 124);
            this.TableBreathFrequency.Name = "TableBreathFrequency";
            this.TableBreathFrequency.RowCount = 1;
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.TableBreathFrequency.Size = new System.Drawing.Size(171, 91);
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
            this.ValueBreathFrequencyLabel.Location = new System.Drawing.Point(67, 2);
            this.ValueBreathFrequencyLabel.Name = "ValueBreathFrequencyLabel";
            this.ValueBreathFrequencyLabel.Size = new System.Drawing.Size(99, 87);
            this.ValueBreathFrequencyLabel.TabIndex = 0;
            this.ValueBreathFrequencyLabel.Text = "Value";
            this.ValueBreathFrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBreathFrequency
            // 
            this.LabelBreathFrequency.AutoSize = true;
            this.LabelBreathFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBreathFrequency.Location = new System.Drawing.Point(5, 2);
            this.LabelBreathFrequency.Name = "LabelBreathFrequency";
            this.LabelBreathFrequency.Size = new System.Drawing.Size(41, 17);
            this.LabelBreathFrequency.TabIndex = 1;
            this.LabelBreathFrequency.Text = "RPM";
            // 
            // TableBattery
            // 
            this.TableBattery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableBattery.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableBattery.ColumnCount = 3;
            this.TableBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35461F));
            this.TableBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64539F));
            this.TableBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableBattery.Controls.Add(this.BatteryLabel, 0, 0);
            this.TableBattery.Controls.Add(this.ValueBatteryLabel, 1, 0);
            this.TableBattery.Controls.Add(this.AlarmBattery, 2, 0);
            this.TableBattery.Location = new System.Drawing.Point(638, 415);
            this.TableBattery.Name = "TableBattery";
            this.TableBattery.RowCount = 1;
            this.TableBattery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBattery.Size = new System.Drawing.Size(171, 18);
            this.TableBattery.TabIndex = 11;
            // 
            // BatteryLabel
            // 
            this.BatteryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatteryLabel.AutoSize = true;
            this.BatteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BatteryLabel.Location = new System.Drawing.Point(5, 2);
            this.BatteryLabel.Name = "BatteryLabel";
            this.BatteryLabel.Size = new System.Drawing.Size(58, 14);
            this.BatteryLabel.TabIndex = 0;
            this.BatteryLabel.Text = "Battery";
            this.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValueBatteryLabel
            // 
            this.ValueBatteryLabel.AutoSize = true;
            this.ValueBatteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBatteryLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ValueBatteryLabel.Location = new System.Drawing.Point(71, 2);
            this.ValueBatteryLabel.Name = "ValueBatteryLabel";
            this.ValueBatteryLabel.Size = new System.Drawing.Size(39, 13);
            this.ValueBatteryLabel.TabIndex = 1;
            this.ValueBatteryLabel.Text = "Value";
            this.ValueBatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlarmBattery
            // 
            this.AlarmBattery.BackColor = System.Drawing.Color.Black;
            this.AlarmBattery.ColumnCount = 2;
            this.AlarmBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmBattery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlarmBattery.Location = new System.Drawing.Point(137, 5);
            this.AlarmBattery.Name = "AlarmBattery";
            this.AlarmBattery.RowCount = 2;
            this.AlarmBattery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmBattery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlarmBattery.Size = new System.Drawing.Size(29, 8);
            this.AlarmBattery.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.656598F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.3434F));
            this.tableLayoutPanel1.Controls.Add(this.HeartFrequencyChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlarmHeartFrequency, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 91);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // HeartFrequencyChart
            // 
            this.HeartFrequencyChart.BackColor = System.Drawing.Color.Black;
            this.HeartFrequencyChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "BreathFrequencyChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.HeartFrequencyChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.HeartFrequencyChart.Legends.Add(legend1);
            this.HeartFrequencyChart.Location = new System.Drawing.Point(26, 3);
            this.HeartFrequencyChart.Name = "HeartFrequencyChart";
            this.HeartFrequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "BreathFrequencyChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Heart Frequency";
            this.HeartFrequencyChart.Series.Add(series1);
            this.HeartFrequencyChart.Size = new System.Drawing.Size(600, 84);
            this.HeartFrequencyChart.TabIndex = 13;
            this.HeartFrequencyChart.Text = "Hearth Frequency";
            // 
            // AlarmHeartFrequency
            // 
            this.AlarmHeartFrequency.BackColor = System.Drawing.Color.Black;
            this.AlarmHeartFrequency.ColumnCount = 1;
            this.AlarmHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmHeartFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmHeartFrequency.Location = new System.Drawing.Point(3, 3);
            this.AlarmHeartFrequency.Name = "AlarmHeartFrequency";
            this.AlarmHeartFrequency.RowCount = 1;
            this.AlarmHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.AlarmHeartFrequency.Size = new System.Drawing.Size(17, 83);
            this.AlarmHeartFrequency.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.656598F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.3434F));
            this.tableLayoutPanel3.Controls.Add(this.BreathFrequencyChart, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AlarmBreathFrequency, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 124);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(629, 91);
            this.tableLayoutPanel3.TabIndex = 13;
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
            this.BreathFrequencyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Black;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.BreathFrequencyChart.Legends.Add(legend2);
            this.BreathFrequencyChart.Location = new System.Drawing.Point(26, 3);
            this.BreathFrequencyChart.Name = "BreathFrequencyChart";
            this.BreathFrequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 3;
            series2.ChartArea = "BreathFrequencyChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Breath Frequency";
            this.BreathFrequencyChart.Series.Add(series2);
            this.BreathFrequencyChart.Size = new System.Drawing.Size(600, 85);
            this.BreathFrequencyChart.TabIndex = 1;
            this.BreathFrequencyChart.Text = "Breath Frequency";
            // 
            // AlarmBreathFrequency
            // 
            this.AlarmBreathFrequency.ColumnCount = 1;
            this.AlarmBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmBreathFrequency.Location = new System.Drawing.Point(3, 3);
            this.AlarmBreathFrequency.Name = "AlarmBreathFrequency";
            this.AlarmBreathFrequency.RowCount = 1;
            this.AlarmBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.AlarmBreathFrequency.Size = new System.Drawing.Size(17, 84);
            this.AlarmBreathFrequency.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.656598F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.3434F));
            this.tableLayoutPanel4.Controls.Add(this.SaturationChart, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.AlarmSaturation, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 221);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(629, 91);
            this.tableLayoutPanel4.TabIndex = 14;
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
            this.SaturationChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.BackColor = System.Drawing.Color.Black;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.SaturationChart.Legends.Add(legend3);
            this.SaturationChart.Location = new System.Drawing.Point(26, 3);
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
            this.SaturationChart.Size = new System.Drawing.Size(600, 85);
            this.SaturationChart.TabIndex = 2;
            this.SaturationChart.Text = "Saturation";
            // 
            // AlarmSaturation
            // 
            this.AlarmSaturation.ColumnCount = 1;
            this.AlarmSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmSaturation.Location = new System.Drawing.Point(3, 3);
            this.AlarmSaturation.Name = "AlarmSaturation";
            this.AlarmSaturation.RowCount = 1;
            this.AlarmSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.AlarmSaturation.Size = new System.Drawing.Size(17, 84);
            this.AlarmSaturation.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.81558F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.18442F));
            this.tableLayoutPanel5.Controls.Add(this.BloodPressureChart, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.AlarmBloodPressure, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 318);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(629, 91);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // BloodPressureChart
            // 
            this.BloodPressureChart.BackColor = System.Drawing.Color.Black;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "SaturationChartArea";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 100F;
            this.BloodPressureChart.ChartAreas.Add(chartArea4);
            this.BloodPressureChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.BackColor = System.Drawing.Color.Black;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            this.BloodPressureChart.Legends.Add(legend4);
            this.BloodPressureChart.Location = new System.Drawing.Point(26, 3);
            this.BloodPressureChart.Name = "BloodPressureChart";
            this.BloodPressureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.BorderWidth = 3;
            series4.ChartArea = "SaturationChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Yellow;
            series4.LabelBackColor = System.Drawing.Color.Black;
            series4.LabelBorderColor = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.Name = "BloodPressure";
            this.BloodPressureChart.Series.Add(series4);
            this.BloodPressureChart.Size = new System.Drawing.Size(600, 85);
            this.BloodPressureChart.TabIndex = 3;
            this.BloodPressureChart.Text = "Blood Pressure";
            // 
            // AlarmBloodPressure
            // 
            this.AlarmBloodPressure.ColumnCount = 1;
            this.AlarmBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmBloodPressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmBloodPressure.Location = new System.Drawing.Point(3, 3);
            this.AlarmBloodPressure.Name = "AlarmBloodPressure";
            this.AlarmBloodPressure.RowCount = 1;
            this.AlarmBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlarmBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.AlarmBloodPressure.Size = new System.Drawing.Size(17, 84);
            this.AlarmBloodPressure.TabIndex = 0;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 447);
            this.Controls.Add(this.MainTable);
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.Load += new System.EventHandler(this.SimulationFormLoad);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.TableDateHour.ResumeLayout(false);
            this.TableDateHour.PerformLayout();
            this.TableValuesHeartFrequency.ResumeLayout(false);
            this.TableUpHeartFrequency.ResumeLayout(false);
            this.TableUpHeartFrequency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeart)).EndInit();
            this.TableTemperature.ResumeLayout(false);
            this.TableTemperature.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.TableSaturation.ResumeLayout(false);
            this.TableSaturation.PerformLayout();
            this.TableBloodPressure.ResumeLayout(false);
            this.TableBloodPressure.PerformLayout();
            this.TableBreathFrequency.ResumeLayout(false);
            this.TableBreathFrequency.PerformLayout();
            this.TableBattery.ResumeLayout(false);
            this.TableBattery.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeartFrequencyChart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequencyChart)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaturationChart)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BloodPressureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart BreathFrequencyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SaturationChart;
        private System.Windows.Forms.TableLayoutPanel TableDateHour;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MonitorLabel;
        private System.Windows.Forms.TableLayoutPanel TableValuesHeartFrequency;
        private System.Windows.Forms.TableLayoutPanel TableUpHeartFrequency;
        private System.Windows.Forms.Label ValueHeartFrequency;
        private System.Windows.Forms.PictureBox PictureHeart;
        private System.Windows.Forms.TableLayoutPanel TableTemperature;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart HeartFrequencyChart;
        private System.Windows.Forms.TableLayoutPanel AlarmHeartFrequency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel AlarmBreathFrequency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel AlarmSaturation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart BloodPressureChart;
        private System.Windows.Forms.TableLayoutPanel AlarmBloodPressure;
        private System.Windows.Forms.TableLayoutPanel AlarmTemperature;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelTemprature;
        private System.Windows.Forms.Label LabelUnitTemperature;
        private System.Windows.Forms.TableLayoutPanel AlarmBattery;
    }
}