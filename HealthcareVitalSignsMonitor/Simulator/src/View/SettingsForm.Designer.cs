
using System;
using System.Windows.Forms;

namespace Simulator.src.View
{
    partial class SettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.unit_of_measurement_label = new System.Windows.Forms.Label();
            this.alert_max_value_label = new System.Windows.Forms.Label();
            this.alert_min_value_label = new System.Windows.Forms.Label();
            this.max_value_label = new System.Windows.Forms.Label();
            this.min_value_label = new System.Windows.Forms.Label();
            this.sensor_label = new System.Windows.Forms.Label();
            this.temperature_label = new System.Windows.Forms.Label();
            this.heart_frequency_label = new System.Windows.Forms.Label();
            this.breath_frequency_label = new System.Windows.Forms.Label();
            this.saturation_label = new System.Windows.Forms.Label();
            this.blood_pressure_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.temperature_check_min = new System.Windows.Forms.CheckBox();
            this.temperature_alarm_min = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.heart_freq_check_min = new System.Windows.Forms.CheckBox();
            this.heart_freq_alarm_min = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.breath_freq_check_min = new System.Windows.Forms.CheckBox();
            this.breath_freq_alarm_min = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.saturation_check_min = new System.Windows.Forms.CheckBox();
            this.saturation_alert_min = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.blood_press_check_min = new System.Windows.Forms.CheckBox();
            this.blood_press_alert_min = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.temperature_check_max = new System.Windows.Forms.CheckBox();
            this.temperature_alarm_max = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.heart_freq_check_max = new System.Windows.Forms.CheckBox();
            this.heart_freq_alarm_max = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.breath_freq_check_max = new System.Windows.Forms.CheckBox();
            this.breath_freq_alarm_max = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.saturation_check_max = new System.Windows.Forms.CheckBox();
            this.saturation_alert_max = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.blood_press_check_max = new System.Windows.Forms.CheckBox();
            this.blood_press_alert_max = new System.Windows.Forms.TextBox();
            this.battery_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.battery_check_min = new System.Windows.Forms.CheckBox();
            this.battery_alert_min = new System.Windows.Forms.TextBox();
            this.temperature_min = new System.Windows.Forms.TextBox();
            this.heart_freq_min = new System.Windows.Forms.TextBox();
            this.breath_freq_min = new System.Windows.Forms.TextBox();
            this.saturation_min = new System.Windows.Forms.TextBox();
            this.blood_press_min = new System.Windows.Forms.TextBox();
            this.temperature_max = new System.Windows.Forms.TextBox();
            this.heart_freq_max = new System.Windows.Forms.TextBox();
            this.breath_freq_max = new System.Windows.Forms.TextBox();
            this.saturation_max = new System.Windows.Forms.TextBox();
            this.blood_press_max = new System.Windows.Forms.TextBox();
            this.temperature_uom = new System.Windows.Forms.ComboBox();
            this.heart_freq_uom = new System.Windows.Forms.TextBox();
            this.breath_freq_uom = new System.Windows.Forms.TextBox();
            this.saturation_uom = new System.Windows.Forms.TextBox();
            this.blood_press_uom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.discard_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.unit_of_measurement_label, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.alert_max_value_label, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.alert_min_value_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.max_value_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.min_value_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sensor_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.temperature_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.heart_frequency_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.breath_frequency_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.saturation_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.blood_pressure_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.battery_label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel13, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.temperature_min, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.heart_freq_min, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.breath_freq_min, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.saturation_min, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.blood_press_min, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.temperature_max, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.heart_freq_max, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.breath_freq_max, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.saturation_max, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.blood_press_max, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.temperature_uom, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.heart_freq_uom, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.breath_freq_uom, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.saturation_uom, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.blood_press_uom, 5, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // unit_of_measurement_label
            // 
            this.unit_of_measurement_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unit_of_measurement_label.AutoSize = true;
            this.unit_of_measurement_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_of_measurement_label.Location = new System.Drawing.Point(678, 9);
            this.unit_of_measurement_label.Name = "unit_of_measurement_label";
            this.unit_of_measurement_label.Size = new System.Drawing.Size(123, 13);
            this.unit_of_measurement_label.TabIndex = 10;
            this.unit_of_measurement_label.Text = "Unit of measurement";
            // 
            // alert_max_value_label
            // 
            this.alert_max_value_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alert_max_value_label.AutoSize = true;
            this.alert_max_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_max_value_label.Location = new System.Drawing.Point(542, 9);
            this.alert_max_value_label.Name = "alert_max_value_label";
            this.alert_max_value_label.Size = new System.Drawing.Size(122, 13);
            this.alert_max_value_label.TabIndex = 9;
            this.alert_max_value_label.Text = "Alert max threashold";
            // 
            // alert_min_value_label
            // 
            this.alert_min_value_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alert_min_value_label.AutoSize = true;
            this.alert_min_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_min_value_label.Location = new System.Drawing.Point(409, 9);
            this.alert_min_value_label.Name = "alert_min_value_label";
            this.alert_min_value_label.Size = new System.Drawing.Size(119, 13);
            this.alert_min_value_label.TabIndex = 8;
            this.alert_min_value_label.Text = "Alert min threashold";
            // 
            // max_value_label
            // 
            this.max_value_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.max_value_label.AutoSize = true;
            this.max_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_value_label.Location = new System.Drawing.Point(320, 9);
            this.max_value_label.Name = "max_value_label";
            this.max_value_label.Size = new System.Drawing.Size(30, 13);
            this.max_value_label.TabIndex = 7;
            this.max_value_label.Text = "Max";
            // 
            // min_value_label
            // 
            this.min_value_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min_value_label.AutoSize = true;
            this.min_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_value_label.Location = new System.Drawing.Point(187, 9);
            this.min_value_label.Name = "min_value_label";
            this.min_value_label.Size = new System.Drawing.Size(27, 13);
            this.min_value_label.TabIndex = 6;
            this.min_value_label.Text = "Min";
            // 
            // sensor_label
            // 
            this.sensor_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sensor_label.AutoSize = true;
            this.sensor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor_label.Location = new System.Drawing.Point(44, 9);
            this.sensor_label.Name = "sensor_label";
            this.sensor_label.Size = new System.Drawing.Size(46, 13);
            this.sensor_label.TabIndex = 0;
            this.sensor_label.Text = "Sensor";
            // 
            // temperature_label
            // 
            this.temperature_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.temperature_label.AutoSize = true;
            this.temperature_label.Location = new System.Drawing.Point(3, 40);
            this.temperature_label.Name = "temperature_label";
            this.temperature_label.Size = new System.Drawing.Size(67, 13);
            this.temperature_label.TabIndex = 1;
            this.temperature_label.Text = "Temperature";
            // 
            // heart_frequency_label
            // 
            this.heart_frequency_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heart_frequency_label.AutoSize = true;
            this.heart_frequency_label.Location = new System.Drawing.Point(3, 71);
            this.heart_frequency_label.Name = "heart_frequency_label";
            this.heart_frequency_label.Size = new System.Drawing.Size(86, 13);
            this.heart_frequency_label.TabIndex = 2;
            this.heart_frequency_label.Text = "Heart Frequency";
            // 
            // breath_frequency_label
            // 
            this.breath_frequency_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.breath_frequency_label.AutoSize = true;
            this.breath_frequency_label.Location = new System.Drawing.Point(3, 102);
            this.breath_frequency_label.Name = "breath_frequency_label";
            this.breath_frequency_label.Size = new System.Drawing.Size(91, 13);
            this.breath_frequency_label.TabIndex = 3;
            this.breath_frequency_label.Text = "Breath Frequency";
            // 
            // saturation_label
            // 
            this.saturation_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saturation_label.AutoSize = true;
            this.saturation_label.Location = new System.Drawing.Point(3, 133);
            this.saturation_label.Name = "saturation_label";
            this.saturation_label.Size = new System.Drawing.Size(55, 13);
            this.saturation_label.TabIndex = 4;
            this.saturation_label.Text = "Saturation";
            // 
            // blood_pressure_label
            // 
            this.blood_pressure_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.blood_pressure_label.AutoSize = true;
            this.blood_pressure_label.Location = new System.Drawing.Point(3, 164);
            this.blood_pressure_label.Name = "blood_pressure_label";
            this.blood_pressure_label.Size = new System.Drawing.Size(78, 13);
            this.blood_pressure_label.TabIndex = 5;
            this.blood_pressure_label.Text = "Blood Pressure";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.temperature_check_min, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.temperature_alarm_min, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(402, 31);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // temperature_check_min
            // 
            this.temperature_check_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature_check_min.AutoSize = true;
            this.temperature_check_min.Location = new System.Drawing.Point(9, 8);
            this.temperature_check_min.Name = "temperature_check_min";
            this.temperature_check_min.Size = new System.Drawing.Size(15, 14);
            this.temperature_check_min.TabIndex = 0;
            this.temperature_check_min.UseVisualStyleBackColor = true;
            // 
            // temperature_alarm_min
            // 
            this.temperature_alarm_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature_alarm_min.Location = new System.Drawing.Point(36, 5);
            this.temperature_alarm_min.Name = "temperature_alarm_min";
            this.temperature_alarm_min.Size = new System.Drawing.Size(95, 20);
            this.temperature_alarm_min.TabIndex = 1;
            this.temperature_alarm_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.heart_freq_check_min, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.heart_freq_alarm_min, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(402, 62);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // heart_freq_check_min
            // 
            this.heart_freq_check_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heart_freq_check_min.AutoSize = true;
            this.heart_freq_check_min.Location = new System.Drawing.Point(9, 8);
            this.heart_freq_check_min.Name = "heart_freq_check_min";
            this.heart_freq_check_min.Size = new System.Drawing.Size(15, 14);
            this.heart_freq_check_min.TabIndex = 0;
            this.heart_freq_check_min.UseVisualStyleBackColor = true;
            // 
            // heart_freq_alarm_min
            // 
            this.heart_freq_alarm_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heart_freq_alarm_min.Location = new System.Drawing.Point(36, 5);
            this.heart_freq_alarm_min.Name = "heart_freq_alarm_min";
            this.heart_freq_alarm_min.Size = new System.Drawing.Size(95, 20);
            this.heart_freq_alarm_min.TabIndex = 1;
            this.heart_freq_alarm_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.Controls.Add(this.breath_freq_check_min, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.breath_freq_alarm_min, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(402, 93);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // breath_freq_check_min
            // 
            this.breath_freq_check_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breath_freq_check_min.AutoSize = true;
            this.breath_freq_check_min.Location = new System.Drawing.Point(9, 8);
            this.breath_freq_check_min.Name = "breath_freq_check_min";
            this.breath_freq_check_min.Size = new System.Drawing.Size(15, 14);
            this.breath_freq_check_min.TabIndex = 0;
            this.breath_freq_check_min.UseVisualStyleBackColor = true;
            // 
            // breath_freq_alarm_min
            // 
            this.breath_freq_alarm_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breath_freq_alarm_min.Location = new System.Drawing.Point(36, 5);
            this.breath_freq_alarm_min.Name = "breath_freq_alarm_min";
            this.breath_freq_alarm_min.Size = new System.Drawing.Size(95, 20);
            this.breath_freq_alarm_min.TabIndex = 1;
            this.breath_freq_alarm_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel6.Controls.Add(this.saturation_check_min, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.saturation_alert_min, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(402, 124);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // saturation_check_min
            // 
            this.saturation_check_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturation_check_min.AutoSize = true;
            this.saturation_check_min.Location = new System.Drawing.Point(9, 8);
            this.saturation_check_min.Name = "saturation_check_min";
            this.saturation_check_min.Size = new System.Drawing.Size(15, 14);
            this.saturation_check_min.TabIndex = 0;
            this.saturation_check_min.UseVisualStyleBackColor = true;
            // 
            // saturation_alert_min
            // 
            this.saturation_alert_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturation_alert_min.Location = new System.Drawing.Point(36, 5);
            this.saturation_alert_min.Name = "saturation_alert_min";
            this.saturation_alert_min.Size = new System.Drawing.Size(95, 20);
            this.saturation_alert_min.TabIndex = 1;
            this.saturation_alert_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel7.Controls.Add(this.blood_press_check_min, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.blood_press_alert_min, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(402, 155);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel7.TabIndex = 15;
            // 
            // blood_press_check_min
            // 
            this.blood_press_check_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blood_press_check_min.AutoSize = true;
            this.blood_press_check_min.Location = new System.Drawing.Point(9, 8);
            this.blood_press_check_min.Name = "blood_press_check_min";
            this.blood_press_check_min.Size = new System.Drawing.Size(15, 14);
            this.blood_press_check_min.TabIndex = 0;
            this.blood_press_check_min.UseVisualStyleBackColor = true;
            // 
            // blood_press_alert_min
            // 
            this.blood_press_alert_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blood_press_alert_min.Location = new System.Drawing.Point(36, 5);
            this.blood_press_alert_min.Name = "blood_press_alert_min";
            this.blood_press_alert_min.Size = new System.Drawing.Size(95, 20);
            this.blood_press_alert_min.TabIndex = 1;
            this.blood_press_alert_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel8.Controls.Add(this.temperature_check_max, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.temperature_alarm_max, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(536, 31);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel8.TabIndex = 16;
            // 
            // temperature_check_max
            // 
            this.temperature_check_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature_check_max.AutoSize = true;
            this.temperature_check_max.Location = new System.Drawing.Point(9, 8);
            this.temperature_check_max.Name = "temperature_check_max";
            this.temperature_check_max.Size = new System.Drawing.Size(15, 14);
            this.temperature_check_max.TabIndex = 0;
            this.temperature_check_max.UseVisualStyleBackColor = true;
            // 
            // temperature_alarm_max
            // 
            this.temperature_alarm_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature_alarm_max.Location = new System.Drawing.Point(36, 5);
            this.temperature_alarm_max.Name = "temperature_alarm_max";
            this.temperature_alarm_max.Size = new System.Drawing.Size(95, 20);
            this.temperature_alarm_max.TabIndex = 1;
            this.temperature_alarm_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel9.Controls.Add(this.heart_freq_check_max, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.heart_freq_alarm_max, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(536, 62);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel9.TabIndex = 17;
            // 
            // heart_freq_check_max
            // 
            this.heart_freq_check_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heart_freq_check_max.AutoSize = true;
            this.heart_freq_check_max.Location = new System.Drawing.Point(9, 8);
            this.heart_freq_check_max.Name = "heart_freq_check_max";
            this.heart_freq_check_max.Size = new System.Drawing.Size(15, 14);
            this.heart_freq_check_max.TabIndex = 0;
            this.heart_freq_check_max.UseVisualStyleBackColor = true;
            // 
            // heart_freq_alarm_max
            // 
            this.heart_freq_alarm_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heart_freq_alarm_max.Location = new System.Drawing.Point(36, 5);
            this.heart_freq_alarm_max.Name = "heart_freq_alarm_max";
            this.heart_freq_alarm_max.Size = new System.Drawing.Size(95, 20);
            this.heart_freq_alarm_max.TabIndex = 1;
            this.heart_freq_alarm_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel10.Controls.Add(this.breath_freq_check_max, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.breath_freq_alarm_max, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(536, 93);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel10.TabIndex = 18;
            // 
            // breath_freq_check_max
            // 
            this.breath_freq_check_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breath_freq_check_max.AutoSize = true;
            this.breath_freq_check_max.Location = new System.Drawing.Point(9, 8);
            this.breath_freq_check_max.Name = "breath_freq_check_max";
            this.breath_freq_check_max.Size = new System.Drawing.Size(15, 14);
            this.breath_freq_check_max.TabIndex = 0;
            this.breath_freq_check_max.UseVisualStyleBackColor = true;
            // 
            // breath_freq_alarm_max
            // 
            this.breath_freq_alarm_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breath_freq_alarm_max.Location = new System.Drawing.Point(36, 5);
            this.breath_freq_alarm_max.Name = "breath_freq_alarm_max";
            this.breath_freq_alarm_max.Size = new System.Drawing.Size(95, 20);
            this.breath_freq_alarm_max.TabIndex = 1;
            this.breath_freq_alarm_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel11.Controls.Add(this.saturation_check_max, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.saturation_alert_max, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(536, 124);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel11.TabIndex = 19;
            // 
            // saturation_check_max
            // 
            this.saturation_check_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturation_check_max.AutoSize = true;
            this.saturation_check_max.Location = new System.Drawing.Point(9, 8);
            this.saturation_check_max.Name = "saturation_check_max";
            this.saturation_check_max.Size = new System.Drawing.Size(15, 14);
            this.saturation_check_max.TabIndex = 0;
            this.saturation_check_max.UseVisualStyleBackColor = true;
            // 
            // saturation_alert_max
            // 
            this.saturation_alert_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturation_alert_max.Location = new System.Drawing.Point(36, 5);
            this.saturation_alert_max.Name = "saturation_alert_max";
            this.saturation_alert_max.Size = new System.Drawing.Size(95, 20);
            this.saturation_alert_max.TabIndex = 1;
            this.saturation_alert_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel12.Controls.Add(this.blood_press_check_max, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.blood_press_alert_max, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(536, 155);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(134, 31);
            this.tableLayoutPanel12.TabIndex = 20;
            // 
            // blood_press_check_max
            // 
            this.blood_press_check_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blood_press_check_max.AutoSize = true;
            this.blood_press_check_max.Location = new System.Drawing.Point(9, 8);
            this.blood_press_check_max.Name = "blood_press_check_max";
            this.blood_press_check_max.Size = new System.Drawing.Size(15, 14);
            this.blood_press_check_max.TabIndex = 0;
            this.blood_press_check_max.UseVisualStyleBackColor = true;
            // 
            // blood_press_alert_max
            // 
            this.blood_press_alert_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blood_press_alert_max.Location = new System.Drawing.Point(36, 5);
            this.blood_press_alert_max.Name = "blood_press_alert_max";
            this.blood_press_alert_max.Size = new System.Drawing.Size(95, 20);
            this.blood_press_alert_max.TabIndex = 1;
            this.blood_press_alert_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // battery_label
            // 
            this.battery_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.battery_label.AutoSize = true;
            this.battery_label.Location = new System.Drawing.Point(3, 198);
            this.battery_label.Name = "battery_label";
            this.battery_label.Size = new System.Drawing.Size(40, 13);
            this.battery_label.TabIndex = 21;
            this.battery_label.Text = "Battery";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel13.Controls.Add(this.battery_check_min, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.battery_alert_min, 1, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(402, 186);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(134, 38);
            this.tableLayoutPanel13.TabIndex = 22;
            // 
            // battery_check_min
            // 
            this.battery_check_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.battery_check_min.AutoSize = true;
            this.battery_check_min.Location = new System.Drawing.Point(9, 12);
            this.battery_check_min.Name = "battery_check_min";
            this.battery_check_min.Size = new System.Drawing.Size(15, 14);
            this.battery_check_min.TabIndex = 0;
            this.battery_check_min.UseVisualStyleBackColor = true;
            // 
            // battery_alert_min
            // 
            this.battery_alert_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.battery_alert_min.Location = new System.Drawing.Point(36, 9);
            this.battery_alert_min.Name = "battery_alert_min";
            this.battery_alert_min.Size = new System.Drawing.Size(95, 20);
            this.battery_alert_min.TabIndex = 1;
            this.battery_alert_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // temperature_min
            // 
            this.temperature_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature_min.Location = new System.Drawing.Point(151, 36);
            this.temperature_min.Name = "temperature_min";
            this.temperature_min.Size = new System.Drawing.Size(100, 20);
            this.temperature_min.TabIndex = 24;
            this.temperature_min.TextChanged += new System.EventHandler(this.temperature_min_TextChanged);
            this.temperature_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // heart_freq_min
            // 
            this.heart_freq_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heart_freq_min.Location = new System.Drawing.Point(151, 67);
            this.heart_freq_min.Name = "heart_freq_min";
            this.heart_freq_min.Size = new System.Drawing.Size(100, 20);
            this.heart_freq_min.TabIndex = 25;
            this.heart_freq_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // breath_freq_min
            // 
            this.breath_freq_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breath_freq_min.Location = new System.Drawing.Point(151, 98);
            this.breath_freq_min.Name = "breath_freq_min";
            this.breath_freq_min.Size = new System.Drawing.Size(100, 20);
            this.breath_freq_min.TabIndex = 26;
            this.breath_freq_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // saturation_min
            // 
            this.saturation_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturation_min.Location = new System.Drawing.Point(151, 129);
            this.saturation_min.Name = "saturation_min";
            this.saturation_min.Size = new System.Drawing.Size(100, 20);
            this.saturation_min.TabIndex = 27;
            this.saturation_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // blood_press_min
            // 
            this.blood_press_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blood_press_min.Location = new System.Drawing.Point(151, 160);
            this.blood_press_min.Name = "blood_press_min";
            this.blood_press_min.Size = new System.Drawing.Size(100, 20);
            this.blood_press_min.TabIndex = 28;
            this.blood_press_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // temperature_max
            // 
            this.temperature_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature_max.Location = new System.Drawing.Point(285, 36);
            this.temperature_max.Name = "temperature_max";
            this.temperature_max.Size = new System.Drawing.Size(100, 20);
            this.temperature_max.TabIndex = 30;
            this.temperature_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // heart_freq_max
            // 
            this.heart_freq_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heart_freq_max.Location = new System.Drawing.Point(285, 67);
            this.heart_freq_max.Name = "heart_freq_max";
            this.heart_freq_max.Size = new System.Drawing.Size(100, 20);
            this.heart_freq_max.TabIndex = 31;
            this.heart_freq_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // breath_freq_max
            // 
            this.breath_freq_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breath_freq_max.Location = new System.Drawing.Point(285, 98);
            this.breath_freq_max.Name = "breath_freq_max";
            this.breath_freq_max.Size = new System.Drawing.Size(100, 20);
            this.breath_freq_max.TabIndex = 32;
            this.breath_freq_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // saturation_max
            // 
            this.saturation_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturation_max.Location = new System.Drawing.Point(285, 129);
            this.saturation_max.Name = "saturation_max";
            this.saturation_max.Size = new System.Drawing.Size(100, 20);
            this.saturation_max.TabIndex = 33;
            this.saturation_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // blood_press_max
            // 
            this.blood_press_max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blood_press_max.Location = new System.Drawing.Point(285, 160);
            this.blood_press_max.Name = "blood_press_max";
            this.blood_press_max.Size = new System.Drawing.Size(100, 20);
            this.blood_press_max.TabIndex = 34;
            this.blood_press_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersKeyPress);
            // 
            // temperature_uom
            // 
            this.temperature_uom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature_uom.FormattingEnabled = true;
            this.temperature_uom.Items.AddRange(new object[] {
            "°C (Celsius)",
            "°F (Fahrenheit)",
            "K (Kelvin)"});
            this.temperature_uom.Location = new System.Drawing.Point(689, 36);
            this.temperature_uom.Name = "temperature_uom";
            this.temperature_uom.Size = new System.Drawing.Size(100, 21);
            this.temperature_uom.TabIndex = 36;
            // 
            // heart_freq_uom
            // 
            this.heart_freq_uom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heart_freq_uom.Location = new System.Drawing.Point(689, 67);
            this.heart_freq_uom.Name = "heart_freq_uom";
            this.heart_freq_uom.Size = new System.Drawing.Size(100, 20);
            this.heart_freq_uom.TabIndex = 37;
            // 
            // breath_freq_uom
            // 
            this.breath_freq_uom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breath_freq_uom.Location = new System.Drawing.Point(689, 98);
            this.breath_freq_uom.Name = "breath_freq_uom";
            this.breath_freq_uom.Size = new System.Drawing.Size(100, 20);
            this.breath_freq_uom.TabIndex = 38;
            // 
            // saturation_uom
            // 
            this.saturation_uom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturation_uom.Location = new System.Drawing.Point(689, 129);
            this.saturation_uom.Name = "saturation_uom";
            this.saturation_uom.Size = new System.Drawing.Size(100, 20);
            this.saturation_uom.TabIndex = 39;
            // 
            // blood_press_uom
            // 
            this.blood_press_uom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blood_press_uom.Location = new System.Drawing.Point(689, 160);
            this.blood_press_uom.Name = "blood_press_uom";
            this.blood_press_uom.Size = new System.Drawing.Size(100, 20);
            this.blood_press_uom.TabIndex = 40;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.discard_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.save_button, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 241);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(809, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // discard_button
            // 
            this.discard_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discard_button.Location = new System.Drawing.Point(589, 3);
            this.discard_button.Name = "discard_button";
            this.discard_button.Size = new System.Drawing.Size(75, 23);
            this.discard_button.TabIndex = 0;
            this.discard_button.Text = "Discard";
            this.discard_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_button.Location = new System.Drawing.Point(710, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 270);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label sensor_label;
        private System.Windows.Forms.Label temperature_label;
        private System.Windows.Forms.Label heart_frequency_label;
        private System.Windows.Forms.Label breath_frequency_label;
        private System.Windows.Forms.Label saturation_label;
        private System.Windows.Forms.Label blood_pressure_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button discard_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label unit_of_measurement_label;
        private System.Windows.Forms.Label alert_max_value_label;
        private System.Windows.Forms.Label alert_min_value_label;
        private System.Windows.Forms.Label max_value_label;
        private System.Windows.Forms.Label min_value_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox temperature_check_min;
        private System.Windows.Forms.TextBox temperature_alarm_min;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox heart_freq_check_min;
        private System.Windows.Forms.TextBox heart_freq_alarm_min;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox breath_freq_check_min;
        private System.Windows.Forms.TextBox breath_freq_alarm_min;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox saturation_check_min;
        private System.Windows.Forms.TextBox saturation_alert_min;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.CheckBox blood_press_check_min;
        private System.Windows.Forms.TextBox blood_press_alert_min;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.CheckBox temperature_check_max;
        private System.Windows.Forms.TextBox temperature_alarm_max;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.CheckBox heart_freq_check_max;
        private System.Windows.Forms.TextBox heart_freq_alarm_max;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.CheckBox breath_freq_check_max;
        private System.Windows.Forms.TextBox breath_freq_alarm_max;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.CheckBox saturation_check_max;
        private System.Windows.Forms.TextBox saturation_alert_max;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.CheckBox blood_press_check_max;
        private System.Windows.Forms.TextBox blood_press_alert_max;
        private System.Windows.Forms.Label battery_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.CheckBox battery_check_min;
        private System.Windows.Forms.TextBox battery_alert_min;
        private System.Windows.Forms.TextBox temperature_min;
        private System.Windows.Forms.TextBox heart_freq_min;
        private System.Windows.Forms.TextBox breath_freq_min;
        private System.Windows.Forms.TextBox saturation_min;
        private System.Windows.Forms.TextBox blood_press_min;
        private System.Windows.Forms.TextBox temperature_max;
        private System.Windows.Forms.TextBox heart_freq_max;
        private System.Windows.Forms.TextBox breath_freq_max;
        private System.Windows.Forms.TextBox saturation_max;
        private System.Windows.Forms.TextBox blood_press_max;
        private System.Windows.Forms.ComboBox temperature_uom;
        private System.Windows.Forms.TextBox heart_freq_uom;
        private System.Windows.Forms.TextBox breath_freq_uom;
        private System.Windows.Forms.TextBox saturation_uom;
        private System.Windows.Forms.TextBox blood_press_uom;

        private void NumbersKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}