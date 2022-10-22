
namespace LHProjectOne.GUI.HomeControl
{
    partial class FormDashboard
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
            this.pnScreenHomeDashboard = new System.Windows.Forms.Panel();
            this.pnBackgroundDashBoard = new System.Windows.Forms.Panel();
            this.pnTimeUsed = new System.Windows.Forms.Panel();
            this.lblTitleTimeUse = new System.Windows.Forms.Label();
            this.lblTimeUsed = new System.Windows.Forms.Label();
            this.pnScreenHomeDashboard.SuspendLayout();
            this.pnBackgroundDashBoard.SuspendLayout();
            this.pnTimeUsed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnScreenHomeDashboard
            // 
            this.pnScreenHomeDashboard.Controls.Add(this.pnBackgroundDashBoard);
            this.pnScreenHomeDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnScreenHomeDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnScreenHomeDashboard.Name = "pnScreenHomeDashboard";
            this.pnScreenHomeDashboard.Size = new System.Drawing.Size(948, 437);
            this.pnScreenHomeDashboard.TabIndex = 0;
            // 
            // pnBackgroundDashBoard
            // 
            this.pnBackgroundDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnBackgroundDashBoard.Controls.Add(this.pnTimeUsed);
            this.pnBackgroundDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackgroundDashBoard.Location = new System.Drawing.Point(0, 0);
            this.pnBackgroundDashBoard.Name = "pnBackgroundDashBoard";
            this.pnBackgroundDashBoard.Size = new System.Drawing.Size(948, 437);
            this.pnBackgroundDashBoard.TabIndex = 4;
            // 
            // pnTimeUsed
            // 
            this.pnTimeUsed.Controls.Add(this.lblTimeUsed);
            this.pnTimeUsed.Controls.Add(this.lblTitleTimeUse);
            this.pnTimeUsed.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTimeUsed.Location = new System.Drawing.Point(13, 4);
            this.pnTimeUsed.Name = "pnTimeUsed";
            this.pnTimeUsed.Size = new System.Drawing.Size(369, 31);
            this.pnTimeUsed.TabIndex = 1;
            // 
            // lblTitleTimeUse
            // 
            this.lblTitleTimeUse.AutoSize = true;
            this.lblTitleTimeUse.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTimeUse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleTimeUse.Location = new System.Drawing.Point(3, 5);
            this.lblTitleTimeUse.Name = "lblTitleTimeUse";
            this.lblTitleTimeUse.Size = new System.Drawing.Size(94, 21);
            this.lblTitleTimeUse.TabIndex = 0;
            this.lblTitleTimeUse.Text = "Time Used:";
            // 
            // lblTimeUsed
            // 
            this.lblTimeUsed.AutoSize = true;
            this.lblTimeUsed.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUsed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimeUsed.Location = new System.Drawing.Point(141, 5);
            this.lblTimeUsed.Name = "lblTimeUsed";
            this.lblTimeUsed.Size = new System.Drawing.Size(95, 21);
            this.lblTimeUsed.TabIndex = 1;
            this.lblTimeUsed.Text = "0d 00:00:00";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 437);
            this.Controls.Add(this.pnScreenHomeDashboard);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.pnScreenHomeDashboard.ResumeLayout(false);
            this.pnBackgroundDashBoard.ResumeLayout(false);
            this.pnTimeUsed.ResumeLayout(false);
            this.pnTimeUsed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnScreenHomeDashboard;
        private System.Windows.Forms.Panel pnBackgroundDashBoard;
        private System.Windows.Forms.Panel pnTimeUsed;
        private System.Windows.Forms.Label lblTitleTimeUse;
        private System.Windows.Forms.Label lblTimeUsed;
    }
}