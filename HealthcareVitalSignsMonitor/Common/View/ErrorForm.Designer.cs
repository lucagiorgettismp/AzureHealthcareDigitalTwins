
namespace Common.View
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonConfirmation = new System.Windows.Forms.Button();
            this.TableTextError = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTextError = new System.Windows.Forms.Label();
            this.PictureError = new System.Windows.Forms.PictureBox();
            this.TableMain.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            this.TableTextError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureError)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableMain.Controls.Add(this.ButtonTable, 0, 1);
            this.TableMain.Controls.Add(this.TableTextError, 0, 0);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 2;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.94915F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.05085F));
            this.TableMain.Size = new System.Drawing.Size(328, 118);
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
            this.ButtonTable.Location = new System.Drawing.Point(3, 81);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTable.Size = new System.Drawing.Size(322, 34);
            this.ButtonTable.TabIndex = 0;
            // 
            // ButtonConfirmation
            // 
            this.ButtonConfirmation.Location = new System.Drawing.Point(108, 3);
            this.ButtonConfirmation.Name = "ButtonConfirmation";
            this.ButtonConfirmation.Size = new System.Drawing.Size(80, 28);
            this.ButtonConfirmation.TabIndex = 0;
            this.ButtonConfirmation.Text = "OK";
            this.ButtonConfirmation.UseVisualStyleBackColor = true;
            this.ButtonConfirmation.Click += new System.EventHandler(this.ButtonConfirmationClick);
            // 
            // TableTextError
            // 
            this.TableTextError.ColumnCount = 2;
            this.TableTextError.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04969F));
            this.TableTextError.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.95031F));
            this.TableTextError.Controls.Add(this.LabelTextError, 1, 0);
            this.TableTextError.Controls.Add(this.PictureError, 0, 0);
            this.TableTextError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTextError.Location = new System.Drawing.Point(3, 3);
            this.TableTextError.Name = "TableTextError";
            this.TableTextError.RowCount = 1;
            this.TableTextError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableTextError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.TableTextError.Size = new System.Drawing.Size(322, 72);
            this.TableTextError.TabIndex = 1;
            // 
            // LabelTextError
            // 
            this.LabelTextError.AutoSize = true;
            this.LabelTextError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTextError.Location = new System.Drawing.Point(81, 30);
            this.LabelTextError.Margin = new System.Windows.Forms.Padding(10, 30, 40, 10);
            this.LabelTextError.Name = "LabelTextError";
            this.LabelTextError.Size = new System.Drawing.Size(201, 32);
            this.LabelTextError.TabIndex = 0;
            this.LabelTextError.Text = "Text Error";
            // 
            // PictureError
            // 
            this.PictureError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureError.BackColor = System.Drawing.Color.White;
            this.PictureError.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureError.ErrorImage")));
            this.PictureError.Image = ((System.Drawing.Image)(resources.GetObject("PictureError.Image")));
            this.PictureError.Location = new System.Drawing.Point(21, 22);
            this.PictureError.Name = "PictureError";
            this.PictureError.Size = new System.Drawing.Size(29, 27);
            this.PictureError.TabIndex = 1;
            this.PictureError.TabStop = false;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 118);
            this.Controls.Add(this.TableMain);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.TableMain.ResumeLayout(false);
            this.ButtonTable.ResumeLayout(false);
            this.TableTextError.ResumeLayout(false);
            this.TableTextError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableMain;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.Button ButtonConfirmation;
        private System.Windows.Forms.TableLayoutPanel TableTextError;
        private System.Windows.Forms.Label LabelTextError;
        private System.Windows.Forms.PictureBox PictureError;
    }
}