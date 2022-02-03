
namespace ShutdownToolkit.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAcoes = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.btnParar = new ShutdownToolkit.Componentes.CustomButton();
            this.btnStart = new ShutdownToolkit.Componentes.CustomButton();
            this.pnlAcoes = new ShutdownToolkit.Componentes.CustomPanel();
            this.rbSleep = new System.Windows.Forms.RadioButton();
            this.rbLogoff = new System.Windows.Forms.RadioButton();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.pnlSeconds = new ShutdownToolkit.Componentes.CustomPanel();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.pnlMinutes = new ShutdownToolkit.Componentes.CustomPanel();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.pnlHours = new ShutdownToolkit.Componentes.CustomPanel();
            this.txtHours = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.pnlAcoes.SuspendLayout();
            this.pnlSeconds.SuspendLayout();
            this.pnlMinutes.SuspendLayout();
            this.pnlHours.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAcoes
            // 
            this.lblAcoes.AutoSize = true;
            this.lblAcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.lblAcoes.Location = new System.Drawing.Point(12, 48);
            this.lblAcoes.Name = "lblAcoes";
            this.lblAcoes.Size = new System.Drawing.Size(37, 13);
            this.lblAcoes.TabIndex = 0;
            this.lblAcoes.Text = "Ações";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.lblMinutes.Location = new System.Drawing.Point(177, 97);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(48, 13);
            this.lblMinutes.TabIndex = 6;
            this.lblMinutes.Text = "Minutos";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.lblHours.Location = new System.Drawing.Point(177, 48);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(37, 13);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Horas";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.lblSeconds.Location = new System.Drawing.Point(177, 151);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(57, 13);
            this.lblSeconds.TabIndex = 8;
            this.lblSeconds.Text = "Segundos";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.lblTimeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.lblTimeLeft.Location = new System.Drawing.Point(10, 215);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(80, 25);
            this.lblTimeLeft.TabIndex = 3;
            this.lblTimeLeft.Text = "00:00:00";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.lblTime.Location = new System.Drawing.Point(12, 202);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Tempo";
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 1000;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // picAbout
            // 
            this.picAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAbout.Image = global::ShutdownToolkit.Properties.Resources.help_24px;
            this.picAbout.Location = new System.Drawing.Point(407, 12);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(24, 24);
            this.picAbout.TabIndex = 14;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnParar.BorderSize = 0;
            this.btnParar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnParar.ButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnParar.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.FlatAppearance.BorderSize = 0;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnParar.Location = new System.Drawing.Point(235, 210);
            this.btnParar.Name = "btnParar";
            this.btnParar.RadiusSize = 7;
            this.btnParar.Size = new System.Drawing.Size(82, 34);
            this.btnParar.TabIndex = 11;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnStart.BorderSize = 0;
            this.btnStart.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnStart.ButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnStart.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnStart.Location = new System.Drawing.Point(323, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.RadiusSize = 7;
            this.btnStart.Size = new System.Drawing.Size(82, 34);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlAcoes
            // 
            this.pnlAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlAcoes.BorderSize = 0;
            this.pnlAcoes.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlAcoes.ButtonTextColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAcoes.Controls.Add(this.rbSleep);
            this.pnlAcoes.Controls.Add(this.rbLogoff);
            this.pnlAcoes.Controls.Add(this.rbRestart);
            this.pnlAcoes.Controls.Add(this.rbShutdown);
            this.pnlAcoes.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlAcoes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAcoes.Location = new System.Drawing.Point(12, 65);
            this.pnlAcoes.Name = "pnlAcoes";
            this.pnlAcoes.RadiusSize = 6;
            this.pnlAcoes.Size = new System.Drawing.Size(151, 130);
            this.pnlAcoes.TabIndex = 1;
            // 
            // rbSleep
            // 
            this.rbSleep.AutoSize = true;
            this.rbSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.rbSleep.Location = new System.Drawing.Point(8, 92);
            this.rbSleep.Name = "rbSleep";
            this.rbSleep.Size = new System.Drawing.Size(69, 17);
            this.rbSleep.TabIndex = 3;
            this.rbSleep.TabStop = true;
            this.rbSleep.Text = "Hibernar";
            this.rbSleep.UseVisualStyleBackColor = true;
            // 
            // rbLogoff
            // 
            this.rbLogoff.AutoSize = true;
            this.rbLogoff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.rbLogoff.Location = new System.Drawing.Point(8, 67);
            this.rbLogoff.Name = "rbLogoff";
            this.rbLogoff.Size = new System.Drawing.Size(59, 17);
            this.rbLogoff.TabIndex = 2;
            this.rbLogoff.TabStop = true;
            this.rbLogoff.Text = "Logoff";
            this.rbLogoff.UseVisualStyleBackColor = true;
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.rbRestart.Location = new System.Drawing.Point(8, 42);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(65, 17);
            this.rbRestart.TabIndex = 1;
            this.rbRestart.TabStop = true;
            this.rbRestart.Text = "Reinicar";
            this.rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.rbShutdown.Location = new System.Drawing.Point(8, 17);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(67, 17);
            this.rbShutdown.TabIndex = 0;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Desligar";
            this.rbShutdown.UseVisualStyleBackColor = true;
            // 
            // pnlSeconds
            // 
            this.pnlSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlSeconds.BorderSize = 0;
            this.pnlSeconds.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlSeconds.ButtonTextColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSeconds.Controls.Add(this.txtSeconds);
            this.pnlSeconds.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlSeconds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSeconds.Location = new System.Drawing.Point(180, 169);
            this.pnlSeconds.Name = "pnlSeconds";
            this.pnlSeconds.RadiusSize = 4;
            this.pnlSeconds.Size = new System.Drawing.Size(225, 26);
            this.pnlSeconds.TabIndex = 9;
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeconds.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.txtSeconds.Location = new System.Drawing.Point(7, 5);
            this.txtSeconds.MaxLength = 2;
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(210, 16);
            this.txtSeconds.TabIndex = 0;
            this.txtSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeconds_KeyPress);
            // 
            // pnlMinutes
            // 
            this.pnlMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlMinutes.BorderSize = 0;
            this.pnlMinutes.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlMinutes.ButtonTextColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMinutes.Controls.Add(this.txtMinutes);
            this.pnlMinutes.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlMinutes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMinutes.Location = new System.Drawing.Point(180, 115);
            this.pnlMinutes.Name = "pnlMinutes";
            this.pnlMinutes.RadiusSize = 4;
            this.pnlMinutes.Size = new System.Drawing.Size(225, 26);
            this.pnlMinutes.TabIndex = 7;
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.txtMinutes.Location = new System.Drawing.Point(7, 5);
            this.txtMinutes.MaxLength = 2;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(210, 16);
            this.txtMinutes.TabIndex = 0;
            this.txtMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutes_KeyPress);
            // 
            // pnlHours
            // 
            this.pnlHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlHours.BorderSize = 0;
            this.pnlHours.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlHours.ButtonTextColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHours.Controls.Add(this.txtHours);
            this.pnlHours.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlHours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHours.Location = new System.Drawing.Point(180, 66);
            this.pnlHours.Name = "pnlHours";
            this.pnlHours.RadiusSize = 4;
            this.pnlHours.Size = new System.Drawing.Size(225, 26);
            this.pnlHours.TabIndex = 5;
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHours.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.txtHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.txtHours.Location = new System.Drawing.Point(7, 5);
            this.txtHours.MaxLength = 2;
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(210, 16);
            this.txtHours.TabIndex = 0;
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(443, 256);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblAcoes);
            this.Controls.Add(this.pnlAcoes);
            this.Controls.Add(this.pnlSeconds);
            this.Controls.Add(this.pnlMinutes);
            this.Controls.Add(this.pnlHours);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.pnlAcoes.ResumeLayout(false);
            this.pnlAcoes.PerformLayout();
            this.pnlSeconds.ResumeLayout(false);
            this.pnlSeconds.PerformLayout();
            this.pnlMinutes.ResumeLayout(false);
            this.pnlMinutes.PerformLayout();
            this.pnlHours.ResumeLayout(false);
            this.pnlHours.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.CustomPanel pnlHours;
        private Componentes.CustomPanel pnlMinutes;
        private Componentes.CustomPanel pnlSeconds;
        private Componentes.CustomPanel pnlAcoes;
        private System.Windows.Forms.Label lblAcoes;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.RadioButton rbLogoff;
        private System.Windows.Forms.RadioButton rbSleep;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSeconds;
        private Componentes.CustomButton btnStart;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.PictureBox picAbout;
        private Componentes.CustomButton btnParar;
    }
}

