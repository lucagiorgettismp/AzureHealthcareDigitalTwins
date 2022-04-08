namespace Simulator.View
{
    partial class DevicesForm
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
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.devices_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.DevicesTable = new System.Windows.Forms.TableLayoutPanel();
            this.listbox_devices = new System.Windows.Forms.ListBox();
            this.TableMain.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            this.DevicesTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableMain.Controls.Add(this.ButtonTable, 0, 0);
            this.TableMain.Controls.Add(this.DevicesTable, 0, 1);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 2;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.91549F));
            this.TableMain.Size = new System.Drawing.Size(566, 284);
            this.TableMain.TabIndex = 0;
            // 
            // ButtonTable
            // 
            this.ButtonTable.ColumnCount = 4;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.Controls.Add(this.devices_button, 0, 0);
            this.ButtonTable.Controls.Add(this.stop_button, 2, 0);
            this.ButtonTable.Controls.Add(this.start_button, 1, 0);
            this.ButtonTable.Controls.Add(this.settings_button, 3, 0);
            this.ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTable.Location = new System.Drawing.Point(3, 3);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTable.Size = new System.Drawing.Size(560, 34);
            this.ButtonTable.TabIndex = 0;
            // 
            // devices_button
            // 
            this.devices_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.devices_button.Location = new System.Drawing.Point(3, 3);
            this.devices_button.Name = "devices_button";
            this.devices_button.Size = new System.Drawing.Size(100, 28);
            this.devices_button.TabIndex = 0;
            this.devices_button.Text = "Devices";
            this.devices_button.UseVisualStyleBackColor = true;
            this.devices_button.Click += new System.EventHandler(this.DevicesButtonClick);
            // 
            // stop_button
            // 
            this.stop_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stop_button.Location = new System.Drawing.Point(342, 3);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(100, 28);
            this.stop_button.TabIndex = 0;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.StopButtonClick);
            // 
            // start_button
            // 
            this.start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.start_button.Location = new System.Drawing.Point(230, 3);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(100, 28);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // settings_button
            // 
            this.settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.settings_button.Location = new System.Drawing.Point(454, 3);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(100, 28);
            this.settings_button.TabIndex = 2;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.SettingsButtonClick);
            // 
            // DevicesTable
            // 
            this.DevicesTable.ColumnCount = 1;
            this.DevicesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DevicesTable.Controls.Add(this.listbox_devices, 0, 0);
            this.DevicesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevicesTable.Location = new System.Drawing.Point(3, 43);
            this.DevicesTable.Name = "DevicesTable";
            this.DevicesTable.RowCount = 1;
            this.DevicesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DevicesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.DevicesTable.Size = new System.Drawing.Size(560, 238);
            this.DevicesTable.TabIndex = 1;
            // 
            // listbox_devices
            // 
            this.listbox_devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listbox_devices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_devices.FormattingEnabled = true;
            this.listbox_devices.ItemHeight = 16;
            this.listbox_devices.Location = new System.Drawing.Point(3, 3);
            this.listbox_devices.Name = "listbox_devices";
            this.listbox_devices.Size = new System.Drawing.Size(554, 232);
            this.listbox_devices.TabIndex = 1;
            this.listbox_devices.SelectedIndexChanged += new System.EventHandler(this.OnDeviceSelected);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 284);
            this.Controls.Add(this.TableMain);
            this.Name = "ControlPanelForm";
            this.Text = "Devices";
            this.Load += new System.EventHandler(this.ControlPanelFormLoad);
            this.TableMain.ResumeLayout(false);
            this.ButtonTable.ResumeLayout(false);
            this.DevicesTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableMain;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TableLayoutPanel DevicesTable;
        private System.Windows.Forms.Button devices_button;
        private System.Windows.Forms.ListBox listbox_devices;
        private System.Windows.Forms.Button settings_button;
    }
}

