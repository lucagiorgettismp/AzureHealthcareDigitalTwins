namespace Client.View
{
    partial class PatientForm
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.patient_surname = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_body_mass_index = new System.Windows.Forms.Label();
            this.patient_age = new System.Windows.Forms.TextBox();
            this.patient_height = new System.Windows.Forms.TextBox();
            this.patient_weight = new System.Windows.Forms.TextBox();
            this.patient_description = new System.Windows.Forms.TextBox();
            this.patient_body_mass_index = new System.Windows.Forms.TextBox();
            this.patient_name = new System.Windows.Forms.TextBox();
            this.save_patient_button = new System.Windows.Forms.Button();
            this.patient_gender = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.UnitHeightLabel = new System.Windows.Forms.Label();
            this.UnitWeightLabel = new System.Windows.Forms.Label();
            this.UnitBodyMassIndexLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.875F));
            this.tableLayoutPanel1.Controls.Add(this.label_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_surname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.patient_surname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_age, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_gender, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_height, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_weight, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_description, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_body_mass_index, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.patient_age, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.patient_height, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.patient_weight, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.patient_description, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.patient_body_mass_index, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.patient_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.save_patient_button, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.patient_gender, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UnitHeightLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.UnitWeightLabel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.UnitBodyMassIndexLabel, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.444445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17584F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17584F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17584F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17584F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17584F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.972325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.972325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.117554F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(114, 65);
            this.label_name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name:";
            // 
            // label_surname
            // 
            this.label_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_surname.Location = new System.Drawing.Point(91, 110);
            this.label_surname.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(78, 20);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Surname:";
            // 
            // patient_surname
            // 
            this.patient_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_surname.Location = new System.Drawing.Point(175, 109);
            this.patient_surname.Name = "patient_surname";
            this.patient_surname.Size = new System.Drawing.Size(254, 23);
            this.patient_surname.TabIndex = 3;
            // 
            // label_age
            // 
            this.label_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(131, 155);
            this.label_age.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(38, 20);
            this.label_age.TabIndex = 4;
            this.label_age.Text = "Age";
            // 
            // label_gender
            // 
            this.label_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(106, 200);
            this.label_gender.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(63, 20);
            this.label_gender.TabIndex = 5;
            this.label_gender.Text = "Gender";
            // 
            // label_height
            // 
            this.label_height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_height.AutoSize = true;
            this.label_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_height.Location = new System.Drawing.Point(113, 245);
            this.label_height.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(56, 20);
            this.label_height.TabIndex = 6;
            this.label_height.Text = "Height";
            // 
            // label_weight
            // 
            this.label_weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_weight.AutoSize = true;
            this.label_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weight.Location = new System.Drawing.Point(110, 290);
            this.label_weight.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(59, 20);
            this.label_weight.TabIndex = 7;
            this.label_weight.Text = "Weight";
            // 
            // label_description
            // 
            this.label_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(80, 334);
            this.label_description.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(89, 20);
            this.label_description.TabIndex = 8;
            this.label_description.Text = "Description";
            // 
            // label_body_mass_index
            // 
            this.label_body_mass_index.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_body_mass_index.AutoSize = true;
            this.label_body_mass_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_body_mass_index.Location = new System.Drawing.Point(39, 378);
            this.label_body_mass_index.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_body_mass_index.Name = "label_body_mass_index";
            this.label_body_mass_index.Size = new System.Drawing.Size(130, 20);
            this.label_body_mass_index.TabIndex = 9;
            this.label_body_mass_index.Text = "Body Mass Index";
            // 
            // patient_age
            // 
            this.patient_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_age.Location = new System.Drawing.Point(175, 154);
            this.patient_age.MaxLength = 3;
            this.patient_age.Name = "patient_age";
            this.patient_age.Size = new System.Drawing.Size(254, 23);
            this.patient_age.TabIndex = 10;
            this.patient_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientAgeKeyPress);
            // 
            // patient_height
            // 
            this.patient_height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_height.Location = new System.Drawing.Point(175, 244);
            this.patient_height.MaxLength = 4;
            this.patient_height.Name = "patient_height";
            this.patient_height.Size = new System.Drawing.Size(254, 23);
            this.patient_height.TabIndex = 12;
            this.patient_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientHeightKeyPress);
            // 
            // patient_weight
            // 
            this.patient_weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_weight.Location = new System.Drawing.Point(175, 289);
            this.patient_weight.MaxLength = 4;
            this.patient_weight.Name = "patient_weight";
            this.patient_weight.Size = new System.Drawing.Size(254, 23);
            this.patient_weight.TabIndex = 13;
            this.patient_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientWeightKeyPress);
            // 
            // patient_description
            // 
            this.patient_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_description.Location = new System.Drawing.Point(175, 321);
            this.patient_description.Multiline = true;
            this.patient_description.Name = "patient_description";
            this.patient_description.Size = new System.Drawing.Size(254, 35);
            this.patient_description.TabIndex = 14;
            // 
            // patient_body_mass_index
            // 
            this.patient_body_mass_index.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_body_mass_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_body_mass_index.Location = new System.Drawing.Point(175, 377);
            this.patient_body_mass_index.MaxLength = 5;
            this.patient_body_mass_index.Name = "patient_body_mass_index";
            this.patient_body_mass_index.Size = new System.Drawing.Size(254, 23);
            this.patient_body_mass_index.TabIndex = 15;
            this.patient_body_mass_index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientBodyMassIndexKeyPress);
            // 
            // patient_name
            // 
            this.patient_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_name.Location = new System.Drawing.Point(175, 64);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(254, 23);
            this.patient_name.TabIndex = 16;
            // 
            // save_patient_button
            // 
            this.save_patient_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_patient_button.Location = new System.Drawing.Point(265, 418);
            this.save_patient_button.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.save_patient_button.Name = "save_patient_button";
            this.save_patient_button.Size = new System.Drawing.Size(75, 23);
            this.save_patient_button.TabIndex = 17;
            this.save_patient_button.Text = "Save";
            this.save_patient_button.UseVisualStyleBackColor = true;
            this.save_patient_button.Click += new System.EventHandler(this.SavePatientButtonClick);
            // 
            // patient_gender
            // 
            this.patient_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_gender.FormattingEnabled = true;
            this.patient_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patient_gender.Location = new System.Drawing.Point(175, 197);
            this.patient_gender.Name = "patient_gender";
            this.patient_gender.Size = new System.Drawing.Size(254, 24);
            this.patient_gender.TabIndex = 19;
            this.patient_gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientGenderKeyPress);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(222, 29);
            this.title.Margin = new System.Windows.Forms.Padding(3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(160, 20);
            this.title.TabIndex = 18;
            this.title.Text = "Create a new patient:";
            // 
            // UnitHeightLabel
            // 
            this.UnitHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UnitHeightLabel.AutoSize = true;
            this.UnitHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitHeightLabel.Location = new System.Drawing.Point(433, 243);
            this.UnitHeightLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 7);
            this.UnitHeightLabel.Name = "UnitHeightLabel";
            this.UnitHeightLabel.Size = new System.Drawing.Size(22, 20);
            this.UnitHeightLabel.TabIndex = 20;
            this.UnitHeightLabel.Text = "m";
            this.UnitHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitWeightLabel
            // 
            this.UnitWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UnitWeightLabel.AutoSize = true;
            this.UnitWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitWeightLabel.Location = new System.Drawing.Point(433, 291);
            this.UnitWeightLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 7);
            this.UnitWeightLabel.Name = "UnitWeightLabel";
            this.UnitWeightLabel.Size = new System.Drawing.Size(25, 17);
            this.UnitWeightLabel.TabIndex = 21;
            this.UnitWeightLabel.Text = "Kg";
            this.UnitWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitBodyMassIndexLabel
            // 
            this.UnitBodyMassIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UnitBodyMassIndexLabel.AutoSize = true;
            this.UnitBodyMassIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitBodyMassIndexLabel.Location = new System.Drawing.Point(433, 379);
            this.UnitBodyMassIndexLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 7);
            this.UnitBodyMassIndexLabel.Name = "UnitBodyMassIndexLabel";
            this.UnitBodyMassIndexLabel.Size = new System.Drawing.Size(56, 17);
            this.UnitBodyMassIndexLabel.TabIndex = 22;
            this.UnitBodyMassIndexLabel.Text = "Kg / m2";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox patient_surname;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_body_mass_index;
        private System.Windows.Forms.TextBox patient_age;
        private System.Windows.Forms.TextBox patient_height;
        private System.Windows.Forms.TextBox patient_weight;
        private System.Windows.Forms.TextBox patient_description;
        private System.Windows.Forms.TextBox patient_body_mass_index;
        private System.Windows.Forms.TextBox patient_name;
        private System.Windows.Forms.Button save_patient_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox patient_gender;
        private System.Windows.Forms.Label UnitHeightLabel;
        private System.Windows.Forms.Label UnitWeightLabel;
        private System.Windows.Forms.Label UnitBodyMassIndexLabel;
    }
}