
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.create_patient_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.get_twins_button = new System.Windows.Forms.Button();
            this.patients_twins_collections = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.create_patient_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.start_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stop_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.get_twins_button, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // create_patient_button
            // 
            this.create_patient_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.create_patient_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_patient_button.Location = new System.Drawing.Point(257, 123);
            this.create_patient_button.Name = "create_patient_button";
            this.create_patient_button.Size = new System.Drawing.Size(100, 30);
            this.create_patient_button.TabIndex = 1;
            this.create_patient_button.Text = "Add Patient";
            this.create_patient_button.UseVisualStyleBackColor = true;
            this.create_patient_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // start_button
            // 
            this.start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.start_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(151, 123);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(100, 30);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_click);
            // 
            // stop_button
            // 
            this.stop_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_button.Location = new System.Drawing.Point(151, 159);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(100, 30);
            this.stop_button.TabIndex = 2;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // get_twins_button
            // 
            this.get_twins_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_twins_button.Location = new System.Drawing.Point(257, 159);
            this.get_twins_button.Name = "get_twins_button";
            this.get_twins_button.Size = new System.Drawing.Size(100, 30);
            this.get_twins_button.TabIndex = 3;
            this.get_twins_button.Text = "Get Twins";
            this.get_twins_button.UseVisualStyleBackColor = true;
            this.get_twins_button.Click += new System.EventHandler(this.get_twins_button_Click);
            // 
            // patients_twins_collections
            // 
            this.patients_twins_collections.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patients_twins_collections.FormattingEnabled = true;
            this.patients_twins_collections.ItemHeight = 15;
            this.patients_twins_collections.Location = new System.Drawing.Point(0, 0);
            this.patients_twins_collections.Name = "patients_twins_collections";
            this.patients_twins_collections.Size = new System.Drawing.Size(120, 319);
            this.patients_twins_collections.TabIndex = 1;
            this.patients_twins_collections.SelectedIndexChanged += new System.EventHandler(this.patients_twins_collections_SelectedIndexChanged);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 313);
            this.Controls.Add(this.patients_twins_collections);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimulationForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button create_patient_button;
        private System.Windows.Forms.ListBox patients_twins_collections;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button get_twins_button;
    }
}

