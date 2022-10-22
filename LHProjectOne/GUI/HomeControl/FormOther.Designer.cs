namespace LHProjectOne.GUI.HomeControl
{
    partial class FormOther
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
            this.pnBackgroundNote = new System.Windows.Forms.Panel();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.pnBackgroundNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackgroundNote
            // 
            this.pnBackgroundNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnBackgroundNote.Controls.Add(this.lblTitleForm);
            this.pnBackgroundNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackgroundNote.Location = new System.Drawing.Point(0, 0);
            this.pnBackgroundNote.Name = "pnBackgroundNote";
            this.pnBackgroundNote.Size = new System.Drawing.Size(948, 437);
            this.pnBackgroundNote.TabIndex = 7;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleForm.Location = new System.Drawing.Point(12, 9);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(137, 21);
            this.lblTitleForm.TabIndex = 1;
            this.lblTitleForm.Text = "This is note form";
            // 
            // FormOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 437);
            this.Controls.Add(this.pnBackgroundNote);
            this.Name = "FormOther";
            this.Text = "FormOther";
            this.pnBackgroundNote.ResumeLayout(false);
            this.pnBackgroundNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackgroundNote;
        private System.Windows.Forms.Label lblTitleForm;
    }
}