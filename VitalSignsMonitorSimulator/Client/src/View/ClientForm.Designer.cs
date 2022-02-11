
namespace Client.View
{
    partial class ClientForm
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
            this.get_twins_button = new System.Windows.Forms.Button();
            this.patients_twins_collections = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.06299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.55906F));
            this.tableLayoutPanel1.Controls.Add(this.create_patient_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.get_twins_button, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.623F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // create_patient_button
            // 
            this.create_patient_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.create_patient_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_patient_button.Location = new System.Drawing.Point(249, 12);
            this.create_patient_button.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.create_patient_button.Name = "create_patient_button";
            this.create_patient_button.Size = new System.Drawing.Size(100, 30);
            this.create_patient_button.TabIndex = 1;
            this.create_patient_button.Text = "Add Patient";
            this.create_patient_button.UseVisualStyleBackColor = true;
            this.create_patient_button.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // get_twins_button
            // 
            this.get_twins_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.get_twins_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_twins_button.Location = new System.Drawing.Point(131, 12);
            this.get_twins_button.Name = "get_twins_button";
            this.get_twins_button.Size = new System.Drawing.Size(100, 30);
            this.get_twins_button.TabIndex = 3;
            this.get_twins_button.Text = "Get Twins";
            this.get_twins_button.UseVisualStyleBackColor = true;
            this.get_twins_button.Click += new System.EventHandler(this.GetTwinsButtonClick);
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
            this.patients_twins_collections.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexPatients);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 313);
            this.Controls.Add(this.patients_twins_collections);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button create_patient_button;
        private System.Windows.Forms.ListBox patients_twins_collections;
        private System.Windows.Forms.Button get_twins_button;
    }
}

