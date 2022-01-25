
namespace Simulator
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
            this.title = new System.Windows.Forms.Label();
            this.patient_gender = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.875F));
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
            this.tableLayoutPanel1.Controls.Add(this.title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.patient_gender, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.943182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.943182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(95, 65);
            this.label_name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name:";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_surname
            // 
            this.label_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_surname.Location = new System.Drawing.Point(72, 110);
            this.label_surname.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(78, 20);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Surname:";
            this.label_surname.Click += new System.EventHandler(this.label_surname_Click);
            // 
            // patient_surname
            // 
            this.patient_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_surname.Location = new System.Drawing.Point(156, 109);
            this.patient_surname.Name = "patient_surname";
            this.patient_surname.Size = new System.Drawing.Size(537, 23);
            this.patient_surname.TabIndex = 3;
            this.patient_surname.TextChanged += new System.EventHandler(this.patient_surname_TextChanged);
            // 
            // label_age
            // 
            this.label_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(112, 155);
            this.label_age.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(38, 20);
            this.label_age.TabIndex = 4;
            this.label_age.Text = "Age";
            this.label_age.Click += new System.EventHandler(this.label_age_Click);
            // 
            // label_gender
            // 
            this.label_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(87, 200);
            this.label_gender.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(63, 20);
            this.label_gender.TabIndex = 5;
            this.label_gender.Text = "Gender";
            this.label_gender.Click += new System.EventHandler(this.label_gender_Click);
            // 
            // label_height
            // 
            this.label_height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_height.AutoSize = true;
            this.label_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_height.Location = new System.Drawing.Point(94, 245);
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
            this.label_weight.Location = new System.Drawing.Point(91, 290);
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
            this.label_description.Location = new System.Drawing.Point(61, 334);
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
            this.label_body_mass_index.Location = new System.Drawing.Point(20, 378);
            this.label_body_mass_index.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_body_mass_index.Name = "label_body_mass_index";
            this.label_body_mass_index.Size = new System.Drawing.Size(130, 20);
            this.label_body_mass_index.TabIndex = 9;
            this.label_body_mass_index.Text = "Body Mass Index";
            this.label_body_mass_index.Click += new System.EventHandler(this.label_body_mass_index_Click);
            // 
            // patient_age
            // 
            this.patient_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_age.Location = new System.Drawing.Point(156, 154);
            this.patient_age.MaxLength = 3;
            this.patient_age.Name = "patient_age";
            this.patient_age.Size = new System.Drawing.Size(537, 23);
            this.patient_age.TabIndex = 10;
            this.patient_age.TextChanged += new System.EventHandler(this.patient_age_TextChanged);
            this.patient_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_age_KeyPress);
            // 
            // patient_height
            // 
            this.patient_height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_height.Location = new System.Drawing.Point(156, 244);
            this.patient_height.MaxLength = 4;
            this.patient_height.Name = "patient_height";
            this.patient_height.Size = new System.Drawing.Size(537, 23);
            this.patient_height.TabIndex = 12;
            this.patient_height.TextChanged += new System.EventHandler(this.patient_height_TextChanged);
            this.patient_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_height_KeyPress);
            // 
            // patient_weight
            // 
            this.patient_weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_weight.Location = new System.Drawing.Point(156, 289);
            this.patient_weight.MaxLength = 4;
            this.patient_weight.Name = "patient_weight";
            this.patient_weight.Size = new System.Drawing.Size(537, 23);
            this.patient_weight.TabIndex = 13;
            this.patient_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_weight_KeyPress);
            // 
            // patient_description
            // 
            this.patient_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_description.Location = new System.Drawing.Point(156, 336);
            this.patient_description.Multiline = true;
            this.patient_description.Name = "patient_description";
            this.patient_description.Size = new System.Drawing.Size(537, 20);
            this.patient_description.TabIndex = 14;
            // 
            // patient_body_mass_index
            // 
            this.patient_body_mass_index.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_body_mass_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_body_mass_index.Location = new System.Drawing.Point(156, 377);
            this.patient_body_mass_index.MaxLength = 5;
            this.patient_body_mass_index.Name = "patient_body_mass_index";
            this.patient_body_mass_index.Size = new System.Drawing.Size(537, 23);
            this.patient_body_mass_index.TabIndex = 15;
            this.patient_body_mass_index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_body_mass_index_KeyPress);
            // 
            // patient_name
            // 
            this.patient_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_name.Location = new System.Drawing.Point(156, 64);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(537, 23);
            this.patient_name.TabIndex = 16;
            this.patient_name.TextChanged += new System.EventHandler(this.patient_name_TextChanged_1);
            // 
            // save_patient_button
            // 
            this.save_patient_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_patient_button.Location = new System.Drawing.Point(439, 418);
            this.save_patient_button.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.save_patient_button.Name = "save_patient_button";
            this.save_patient_button.Size = new System.Drawing.Size(75, 23);
            this.save_patient_button.TabIndex = 17;
            this.save_patient_button.Text = "Save";
            this.save_patient_button.UseVisualStyleBackColor = true;
            this.save_patient_button.Click += new System.EventHandler(this.save_patient_button_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(396, 10);
            this.title.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(160, 20);
            this.title.TabIndex = 18;
            this.title.Text = "Create a new patient:";
            // 
            // patient_gender
            // 
            this.patient_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_gender.FormattingEnabled = true;
            this.patient_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patient_gender.Location = new System.Drawing.Point(156, 194);
            this.patient_gender.Name = "patient_gender";
            this.patient_gender.Size = new System.Drawing.Size(537, 24);
            this.patient_gender.TabIndex = 19;
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
    }
}