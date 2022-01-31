
namespace ShutdownToolkit.Forms
{
    partial class About
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
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.linkGithubProfile = new System.Windows.Forms.LinkLabel();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.picInformation = new System.Windows.Forms.PictureBox();
            this.picGithubProfile = new System.Windows.Forms.PictureBox();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithubProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.lblAbout.Location = new System.Drawing.Point(78, 80);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(291, 51);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "Este sistema foi desenvolvido por José Lucas, com intuito de automatizar as taref" +
    "as de desligamento do windows.";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlBottom.Controls.Add(this.linkGithubProfile);
            this.pnlBottom.Controls.Add(this.lblAdditionalInfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 191);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(382, 20);
            this.pnlBottom.TabIndex = 16;
            // 
            // linkGithubProfile
            // 
            this.linkGithubProfile.AutoSize = true;
            this.linkGithubProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkGithubProfile.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkGithubProfile.Location = new System.Drawing.Point(220, 3);
            this.linkGithubProfile.Name = "linkGithubProfile";
            this.linkGithubProfile.Size = new System.Drawing.Size(159, 13);
            this.linkGithubProfile.TabIndex = 2;
            this.linkGithubProfile.TabStop = true;
            this.linkGithubProfile.Text = "https://github.com/jslucas22/";
            this.linkGithubProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithubProfile_LinkClicked);
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.AutoSize = true;
            this.lblAdditionalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAdditionalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.lblAdditionalInfo.Location = new System.Drawing.Point(3, 3);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(107, 15);
            this.lblAdditionalInfo.TabIndex = 1;
            this.lblAdditionalInfo.Text = "Shutdown Toolkit. ";
            // 
            // picInformation
            // 
            this.picInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInformation.Image = global::ShutdownToolkit.Properties.Resources.info_64px;
            this.picInformation.Location = new System.Drawing.Point(14, 73);
            this.picInformation.Name = "picInformation";
            this.picInformation.Size = new System.Drawing.Size(64, 64);
            this.picInformation.TabIndex = 17;
            this.picInformation.TabStop = false;
            // 
            // picGithubProfile
            // 
            this.picGithubProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picGithubProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGithubProfile.Image = global::ShutdownToolkit.Properties.Resources.github_24px;
            this.picGithubProfile.Location = new System.Drawing.Point(346, 12);
            this.picGithubProfile.Name = "picGithubProfile";
            this.picGithubProfile.Size = new System.Drawing.Size(24, 24);
            this.picGithubProfile.TabIndex = 15;
            this.picGithubProfile.TabStop = false;
            this.picGithubProfile.Click += new System.EventHandler(this.picGithubProfile_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(382, 211);
            this.Controls.Add(this.picInformation);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.picGithubProfile);
            this.Controls.Add(this.lblAbout);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithubProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox picGithubProfile;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.LinkLabel linkGithubProfile;
        private System.Windows.Forms.PictureBox picInformation;
    }
}