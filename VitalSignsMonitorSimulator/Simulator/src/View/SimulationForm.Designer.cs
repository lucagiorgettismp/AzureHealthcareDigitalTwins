
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeartFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlarmHeartFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.SaturationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BreathFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.AlarmBreathFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.AlarmSaturation = new System.Windows.Forms.TableLayoutPanel();
            this.AlarmBloodPressure = new System.Windows.Forms.TableLayoutPanel();
            this.BloodPressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainTable.SuspendLayout();
            this.TableDateHour.SuspendLayout();
            this.TableValuesHeartFrequency.SuspendLayout();
            this.TableUpHeartFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeart)).BeginInit();
            this.TableTemperature.SuspendLayout();
            this.TableSaturation.SuspendLayout();
            this.TableBloodPressure.SuspendLayout();
            this.TableBreathFrequency.SuspendLayout();
            this.TableBattery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeartFrequencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequencyChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodPressureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 635F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
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
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
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
            this.TableDateHour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.TableDateHour.Size = new System.Drawing.Size(177, 23);
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
            this.DateLabel.Size = new System.Drawing.Size(81, 15);
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
            this.HourLabel.Size = new System.Drawing.Size(82, 15);
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
            this.MonitorLabel.Size = new System.Drawing.Size(84, 23);
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
            this.TableValuesHeartFrequency.Location = new System.Drawing.Point(638, 26);
            this.TableValuesHeartFrequency.Name = "TableValuesHeartFrequency";
            this.TableValuesHeartFrequency.RowCount = 2;
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.31915F));
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.68085F));
            this.TableValuesHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableValuesHeartFrequency.Size = new System.Drawing.Size(171, 90);
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
            this.TableUpHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TableUpHeartFrequency.Size = new System.Drawing.Size(163, 42);
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
            this.ValueHeartFrequency.Size = new System.Drawing.Size(95, 42);
            this.ValueHeartFrequency.TabIndex = 0;
            this.ValueHeartFrequency.Text = "Value";
            this.ValueHeartFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureHeart
            // 
            this.PictureHeart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureHeart.Image = ((System.Drawing.Image)(resources.GetObject("PictureHeart.Image")));
            this.PictureHeart.InitialImage = null;
            this.PictureHeart.Location = new System.Drawing.Point(3, 16);
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
            this.TableTemperature.Location = new System.Drawing.Point(4, 52);
            this.TableTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.TableTemperature.Name = "TableTemperature";
            this.TableTemperature.RowCount = 2;
            this.TableTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.TableTemperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.TableTemperature.Size = new System.Drawing.Size(149, 34);
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
            this.LabelUnitTemperature.Location = new System.Drawing.Point(3, 21);
            this.LabelUnitTemperature.Name = "LabelUnitTemperature";
            this.LabelUnitTemperature.Size = new System.Drawing.Size(25, 13);
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
            this.ValueTemperatureLabel.Size = new System.Drawing.Size(86, 21);
            this.ValueTemperatureLabel.TabIndex = 2;
            this.ValueTemperatureLabel.Text = "Value";
            this.ValueTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableSaturation
            // 
            this.TableSaturation.BackColor = System.Drawing.SystemColors.Desktop;
            this.TableSaturation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableSaturation.ColumnCount = 2;
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.TableSaturation.Controls.Add(this.ValueSaturationLabel, 1, 0);
            this.TableSaturation.Controls.Add(this.LabelUnitSaturation, 0, 0);
            this.TableSaturation.Cursor = System.Windows.Forms.Cursors.Default;
            this.TableSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableSaturation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableSaturation.Location = new System.Drawing.Point(638, 218);
            this.TableSaturation.Name = "TableSaturation";
            this.TableSaturation.RowCount = 1;
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.TableSaturation.Size = new System.Drawing.Size(171, 90);
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
            this.ValueSaturationLabel.Location = new System.Drawing.Point(71, 2);
            this.ValueSaturationLabel.Name = "ValueSaturationLabel";
            this.ValueSaturationLabel.Size = new System.Drawing.Size(95, 86);
            this.ValueSaturationLabel.TabIndex = 0;
            this.ValueSaturationLabel.Text = "Value";
            this.ValueSaturationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUnitSaturation
            // 
            this.LabelUnitSaturation.AutoSize = true;
            this.LabelUnitSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitSaturation.Location = new System.Drawing.Point(5, 2);
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
            this.LabelPatientMonitor.Location = new System.Drawing.Point(3, 407);
            this.LabelPatientMonitor.Name = "LabelPatientMonitor";
            this.LabelPatientMonitor.Size = new System.Drawing.Size(629, 23);
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
            this.TableBloodPressure.Location = new System.Drawing.Point(638, 314);
            this.TableBloodPressure.Name = "TableBloodPressure";
            this.TableBloodPressure.RowCount = 1;
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.TableBloodPressure.Size = new System.Drawing.Size(171, 90);
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
            this.ValueBloodPressureLabel.Size = new System.Drawing.Size(96, 86);
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
            this.TableBreathFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.TableBreathFrequency.Controls.Add(this.ValueBreathFrequencyLabel, 1, 0);
            this.TableBreathFrequency.Controls.Add(this.LabelBreathFrequency, 0, 0);
            this.TableBreathFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBreathFrequency.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TableBreathFrequency.Location = new System.Drawing.Point(638, 122);
            this.TableBreathFrequency.Name = "TableBreathFrequency";
            this.TableBreathFrequency.RowCount = 1;
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.TableBreathFrequency.Size = new System.Drawing.Size(171, 90);
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
            this.ValueBreathFrequencyLabel.Location = new System.Drawing.Point(71, 2);
            this.ValueBreathFrequencyLabel.Name = "ValueBreathFrequencyLabel";
            this.ValueBreathFrequencyLabel.Size = new System.Drawing.Size(95, 86);
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
            this.TableBattery.ColumnCount = 2;
            this.TableBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.52288F));
            this.TableBattery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.47712F));
            this.TableBattery.Controls.Add(this.BatteryLabel, 0, 0);
            this.TableBattery.Controls.Add(this.ValueBatteryLabel, 1, 0);
            this.TableBattery.Location = new System.Drawing.Point(638, 410);
            this.TableBattery.Name = "TableBattery";
            this.TableBattery.RowCount = 1;
            this.TableBattery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBattery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableBattery.Size = new System.Drawing.Size(171, 17);
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
            this.BatteryLabel.Size = new System.Drawing.Size(60, 13);
            this.BatteryLabel.TabIndex = 0;
            this.BatteryLabel.Text = "Battery";
            this.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValueBatteryLabel
            // 
            this.ValueBatteryLabel.AutoSize = true;
            this.ValueBatteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBatteryLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ValueBatteryLabel.Location = new System.Drawing.Point(73, 2);
            this.ValueBatteryLabel.Name = "ValueBatteryLabel";
            this.ValueBatteryLabel.Size = new System.Drawing.Size(39, 13);
            this.ValueBatteryLabel.TabIndex = 1;
            this.ValueBatteryLabel.Text = "Value";
            this.ValueBatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.656598F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.3434F));
            this.tableLayoutPanel1.Controls.Add(this.HeartFrequencyChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlarmHeartFrequency, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 90);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // HeartFrequencyChart
            // 
            this.HeartFrequencyChart.BackColor = System.Drawing.Color.Black;
            this.HeartFrequencyChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.IsMarginVisible = false;
            chartArea5.AxisX.IsMarksNextToAxis = false;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.Name = "BreathFrequencyChartArea";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 100F;
            chartArea5.Position.Width = 100F;
            this.HeartFrequencyChart.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Black;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.Name = "Legend1";
            this.HeartFrequencyChart.Legends.Add(legend5);
            this.HeartFrequencyChart.Location = new System.Drawing.Point(26, 3);
            this.HeartFrequencyChart.Name = "HeartFrequencyChart";
            this.HeartFrequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.BorderWidth = 3;
            series5.ChartArea = "BreathFrequencyChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Legend = "Legend1";
            series5.Name = "Heart Frequency";
            this.HeartFrequencyChart.Series.Add(series5);
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
            this.AlarmHeartFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmHeartFrequency.Size = new System.Drawing.Size(17, 83);
            this.AlarmHeartFrequency.TabIndex = 14;
            // 
            // SaturationChart
            // 
            this.SaturationChart.BackColor = System.Drawing.Color.Black;
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.Name = "SaturationChartArea";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 100F;
            chartArea6.Position.Width = 100F;
            this.SaturationChart.ChartAreas.Add(chartArea6);
            this.SaturationChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.BackColor = System.Drawing.Color.Black;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.Name = "Legend1";
            this.SaturationChart.Legends.Add(legend6);
            this.SaturationChart.Location = new System.Drawing.Point(26, 3);
            this.SaturationChart.Name = "SaturationChart";
            this.SaturationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series6.BorderColor = System.Drawing.Color.Transparent;
            series6.BorderWidth = 3;
            series6.ChartArea = "SaturationChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.LabelBackColor = System.Drawing.Color.Black;
            series6.LabelBorderColor = System.Drawing.Color.Black;
            series6.Legend = "Legend1";
            series6.Name = "Saturation";
            this.SaturationChart.Series.Add(series6);
            this.SaturationChart.Size = new System.Drawing.Size(600, 84);
            this.SaturationChart.TabIndex = 2;
            this.SaturationChart.Text = "Saturation";
            // 
            // BreathFrequencyChart
            // 
            this.BreathFrequencyChart.BackColor = System.Drawing.Color.Black;
            this.BreathFrequencyChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.IsMarginVisible = false;
            chartArea7.AxisX.IsMarksNextToAxis = false;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorTickMark.Enabled = false;
            chartArea7.BackColor = System.Drawing.Color.Black;
            chartArea7.Name = "BreathFrequencyChartArea";
            chartArea7.Position.Auto = false;
            chartArea7.Position.Height = 100F;
            chartArea7.Position.Width = 100F;
            this.BreathFrequencyChart.ChartAreas.Add(chartArea7);
            this.BreathFrequencyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.BackColor = System.Drawing.Color.Black;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.Name = "Legend1";
            this.BreathFrequencyChart.Legends.Add(legend7);
            this.BreathFrequencyChart.Location = new System.Drawing.Point(26, 3);
            this.BreathFrequencyChart.Name = "BreathFrequencyChart";
            this.BreathFrequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.BorderWidth = 3;
            series7.ChartArea = "BreathFrequencyChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.Name = "Breath Frequency";
            this.BreathFrequencyChart.Series.Add(series7);
            this.BreathFrequencyChart.Size = new System.Drawing.Size(600, 84);
            this.BreathFrequencyChart.TabIndex = 1;
            this.BreathFrequencyChart.Text = "Breath Frequency";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.656598F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.3434F));
            this.tableLayoutPanel3.Controls.Add(this.BreathFrequencyChart, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AlarmBreathFrequency, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(629, 90);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.656598F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.3434F));
            this.tableLayoutPanel4.Controls.Add(this.SaturationChart, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.AlarmSaturation, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 218);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(629, 90);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.81558F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.18442F));
            this.tableLayoutPanel5.Controls.Add(this.BloodPressureChart, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.AlarmBloodPressure, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 314);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(629, 90);
            this.tableLayoutPanel5.TabIndex = 15;
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
            this.AlarmBreathFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmBreathFrequency.Size = new System.Drawing.Size(17, 84);
            this.AlarmBreathFrequency.TabIndex = 2;
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
            this.AlarmSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmSaturation.Size = new System.Drawing.Size(17, 84);
            this.AlarmSaturation.TabIndex = 3;
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
            this.AlarmBloodPressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AlarmBloodPressure.Size = new System.Drawing.Size(18, 84);
            this.AlarmBloodPressure.TabIndex = 0;
            // 
            // BloodPressureChart
            // 
            this.BloodPressureChart.BackColor = System.Drawing.Color.Black;
            chartArea8.AxisX.IsMarginVisible = false;
            chartArea8.BackColor = System.Drawing.Color.Black;
            chartArea8.Name = "SaturationChartArea";
            chartArea8.Position.Auto = false;
            chartArea8.Position.Height = 100F;
            chartArea8.Position.Width = 100F;
            this.BloodPressureChart.ChartAreas.Add(chartArea8);
            this.BloodPressureChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.BackColor = System.Drawing.Color.Black;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.ForeColor = System.Drawing.Color.White;
            legend8.Name = "Legend1";
            this.BloodPressureChart.Legends.Add(legend8);
            this.BloodPressureChart.Location = new System.Drawing.Point(27, 3);
            this.BloodPressureChart.Name = "BloodPressureChart";
            this.BloodPressureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series8.BorderColor = System.Drawing.Color.Transparent;
            series8.BorderWidth = 3;
            series8.ChartArea = "SaturationChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Yellow;
            series8.LabelBackColor = System.Drawing.Color.Black;
            series8.LabelBorderColor = System.Drawing.Color.Black;
            series8.Legend = "Legend1";
            series8.Name = "BloodPressure";
            this.BloodPressureChart.Series.Add(series8);
            this.BloodPressureChart.Size = new System.Drawing.Size(599, 84);
            this.BloodPressureChart.TabIndex = 3;
            this.BloodPressureChart.Text = "Blood Pressure";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 447);
            this.Controls.Add(this.MainTable);
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.Load += new System.EventHandler(this.SimulationForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.SaturationChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreathFrequencyChart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
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
    }
}