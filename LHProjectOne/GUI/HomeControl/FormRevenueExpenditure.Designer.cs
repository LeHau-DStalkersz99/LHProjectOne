namespace LHProjectOne.GUI.HomeControl
{
    partial class FormRevenueExpenditure
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
            this.pnBackgroundRevenueExpenditure = new System.Windows.Forms.Panel();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.pnBackgroundRevenueExpenditure.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackgroundRevenueExpenditure
            // 
            this.pnBackgroundRevenueExpenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnBackgroundRevenueExpenditure.Controls.Add(this.lblTitleForm);
            this.pnBackgroundRevenueExpenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackgroundRevenueExpenditure.Location = new System.Drawing.Point(0, 0);
            this.pnBackgroundRevenueExpenditure.Name = "pnBackgroundRevenueExpenditure";
            this.pnBackgroundRevenueExpenditure.Size = new System.Drawing.Size(948, 437);
            this.pnBackgroundRevenueExpenditure.TabIndex = 7;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleForm.Location = new System.Drawing.Point(12, 9);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(261, 21);
            this.lblTitleForm.TabIndex = 1;
            this.lblTitleForm.Text = "This is RevenueExpenditure form";
            // 
            // FormRevenueExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 437);
            this.Controls.Add(this.pnBackgroundRevenueExpenditure);
            this.Name = "FormRevenueExpenditure";
            this.Text = "FormRevenueExpenditure";
            this.pnBackgroundRevenueExpenditure.ResumeLayout(false);
            this.pnBackgroundRevenueExpenditure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackgroundRevenueExpenditure;
        private System.Windows.Forms.Label lblTitleForm;
    }
}