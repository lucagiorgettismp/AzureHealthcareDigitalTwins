
namespace Common.View
{
    partial class SuccessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessForm));
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonConfirmation = new System.Windows.Forms.Button();
            this.TableTextSuccess = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTextSuccess = new System.Windows.Forms.Label();
            this.PictureSuccess = new System.Windows.Forms.PictureBox();
            this.TableMain.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            this.TableTextSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableMain.Controls.Add(this.ButtonTable, 0, 1);
            this.TableMain.Controls.Add(this.TableTextSuccess, 0, 0);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 2;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.94915F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.05085F));
            this.TableMain.Size = new System.Drawing.Size(262, 109);
            this.TableMain.TabIndex = 0;
            // 
            // ButtonTable
            // 
            this.ButtonTable.ColumnCount = 3;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.89113F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85594F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25293F));
            this.ButtonTable.Controls.Add(this.ButtonConfirmation, 1, 0);
            this.ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTable.Location = new System.Drawing.Point(3, 75);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTable.Size = new System.Drawing.Size(256, 31);
            this.ButtonTable.TabIndex = 0;
            // 
            // ButtonConfirmation
            // 
            this.ButtonConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConfirmation.Location = new System.Drawing.Point(87, 3);
            this.ButtonConfirmation.Name = "ButtonConfirmation";
            this.ButtonConfirmation.Size = new System.Drawing.Size(80, 25);
            this.ButtonConfirmation.TabIndex = 0;
            this.ButtonConfirmation.Text = "OK";
            this.ButtonConfirmation.UseVisualStyleBackColor = true;
            this.ButtonConfirmation.Click += new System.EventHandler(this.ButtonConfirmationClick);
            // 
            // TableTextSuccess
            // 
            this.TableTextSuccess.ColumnCount = 2;
            this.TableTextSuccess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04969F));
            this.TableTextSuccess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.95031F));
            this.TableTextSuccess.Controls.Add(this.LabelTextSuccess, 1, 0);
            this.TableTextSuccess.Controls.Add(this.PictureSuccess, 0, 0);
            this.TableTextSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTextSuccess.Location = new System.Drawing.Point(3, 3);
            this.TableTextSuccess.Name = "TableTextSuccess";
            this.TableTextSuccess.RowCount = 1;
            this.TableTextSuccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableTextSuccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.TableTextSuccess.Size = new System.Drawing.Size(256, 66);
            this.TableTextSuccess.TabIndex = 1;
            // 
            // LabelTextSuccess
            // 
            this.LabelTextSuccess.AutoSize = true;
            this.LabelTextSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTextSuccess.Location = new System.Drawing.Point(66, 30);
            this.LabelTextSuccess.Margin = new System.Windows.Forms.Padding(10, 30, 40, 10);
            this.LabelTextSuccess.Name = "LabelTextSuccess";
            this.LabelTextSuccess.Size = new System.Drawing.Size(150, 26);
            this.LabelTextSuccess.TabIndex = 0;
            this.LabelTextSuccess.Text = "Text";
            // 
            // PictureSuccess
            // 
            this.PictureSuccess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureSuccess.BackColor = System.Drawing.Color.White;
            this.PictureSuccess.ErrorImage = null;
            this.PictureSuccess.Image = ((System.Drawing.Image)(resources.GetObject("PictureSuccess.Image")));
            this.PictureSuccess.Location = new System.Drawing.Point(16, 20);
            this.PictureSuccess.Name = "PictureSuccess";
            this.PictureSuccess.Size = new System.Drawing.Size(24, 25);
            this.PictureSuccess.TabIndex = 1;
            this.PictureSuccess.TabStop = false;
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 109);
            this.Controls.Add(this.TableMain);
            this.Name = "SuccessForm";
            this.Text = "SuccessForm";
            this.TableMain.ResumeLayout(false);
            this.ButtonTable.ResumeLayout(false);
            this.TableTextSuccess.ResumeLayout(false);
            this.TableTextSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSuccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableMain;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.Button ButtonConfirmation;
        private System.Windows.Forms.TableLayoutPanel TableTextSuccess;
        private System.Windows.Forms.Label LabelTextSuccess;
        private System.Windows.Forms.PictureBox PictureSuccess;
    }
}