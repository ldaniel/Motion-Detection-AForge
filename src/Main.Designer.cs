namespace DetectorMovimento
{
    partial class Main
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
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.lblDispositivos = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.gbxVideo = new System.Windows.Forms.GroupBox();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.btnDetectarMovimento = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.gbTipoDestaque = new System.Windows.Forms.GroupBox();
            this.rbtArea = new System.Windows.Forms.RadioButton();
            this.rbtContorno = new System.Windows.Forms.RadioButton();
            this.gbTipoCaptura = new System.Windows.Forms.GroupBox();
            this.rbtDuas = new System.Windows.Forms.RadioButton();
            this.rbtSimples = new System.Windows.Forms.RadioButton();
            this.gbxVideo.SuspendLayout();
            this.gbTipoDestaque.SuspendLayout();
            this.gbTipoCaptura.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(12, 26);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(288, 21);
            this.cbxDispositivos.TabIndex = 0;
            // 
            // lblDispositivos
            // 
            this.lblDispositivos.AutoSize = true;
            this.lblDispositivos.Location = new System.Drawing.Point(9, 9);
            this.lblDispositivos.Name = "lblDispositivos";
            this.lblDispositivos.Size = new System.Drawing.Size(106, 13);
            this.lblDispositivos.TabIndex = 1;
            this.lblDispositivos.Text = "Escolha o dispositivo";
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(306, 24);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(75, 23);
            this.btnLigar.TabIndex = 2;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // gbxVideo
            // 
            this.gbxVideo.Controls.Add(this.videoSourcePlayer);
            this.gbxVideo.Location = new System.Drawing.Point(10, 55);
            this.gbxVideo.Name = "gbxVideo";
            this.gbxVideo.Size = new System.Drawing.Size(371, 257);
            this.gbxVideo.TabIndex = 4;
            this.gbxVideo.TabStop = false;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.AutoSizeControl = true;
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(24, 7);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer.TabIndex = 4;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // btnDetectarMovimento
            // 
            this.btnDetectarMovimento.Enabled = false;
            this.btnDetectarMovimento.Location = new System.Drawing.Point(135, 425);
            this.btnDetectarMovimento.Name = "btnDetectarMovimento";
            this.btnDetectarMovimento.Size = new System.Drawing.Size(127, 23);
            this.btnDetectarMovimento.TabIndex = 6;
            this.btnDetectarMovimento.Text = "Detectar movimento";
            this.btnDetectarMovimento.UseVisualStyleBackColor = true;
            this.btnDetectarMovimento.Click += new System.EventHandler(this.btnDetectarMovimento_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(135, 454);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(126, 23);
            this.btnParar.TabIndex = 7;
            this.btnParar.Text = "Parar detecção";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // gbTipoDestaque
            // 
            this.gbTipoDestaque.Controls.Add(this.rbtArea);
            this.gbTipoDestaque.Controls.Add(this.rbtContorno);
            this.gbTipoDestaque.Enabled = false;
            this.gbTipoDestaque.Location = new System.Drawing.Point(10, 322);
            this.gbTipoDestaque.Name = "gbTipoDestaque";
            this.gbTipoDestaque.Size = new System.Drawing.Size(178, 88);
            this.gbTipoDestaque.TabIndex = 10;
            this.gbTipoDestaque.TabStop = false;
            this.gbTipoDestaque.Text = "Processamento";
            // 
            // rbtArea
            // 
            this.rbtArea.AutoSize = true;
            this.rbtArea.Location = new System.Drawing.Point(15, 56);
            this.rbtArea.Name = "rbtArea";
            this.rbtArea.Size = new System.Drawing.Size(134, 17);
            this.rbtArea.TabIndex = 11;
            this.rbtArea.Text = "MotionAreaHighlighting";
            this.rbtArea.UseVisualStyleBackColor = true;
            // 
            // rbtContorno
            // 
            this.rbtContorno.AutoSize = true;
            this.rbtContorno.Checked = true;
            this.rbtContorno.Location = new System.Drawing.Point(15, 29);
            this.rbtContorno.Name = "rbtContorno";
            this.rbtContorno.Size = new System.Drawing.Size(143, 17);
            this.rbtContorno.TabIndex = 10;
            this.rbtContorno.TabStop = true;
            this.rbtContorno.Text = "MotionBorderHighlighting";
            this.rbtContorno.UseVisualStyleBackColor = true;
            // 
            // gbTipoCaptura
            // 
            this.gbTipoCaptura.Controls.Add(this.rbtDuas);
            this.gbTipoCaptura.Controls.Add(this.rbtSimples);
            this.gbTipoCaptura.Enabled = false;
            this.gbTipoCaptura.Location = new System.Drawing.Point(203, 322);
            this.gbTipoCaptura.Name = "gbTipoCaptura";
            this.gbTipoCaptura.Size = new System.Drawing.Size(178, 88);
            this.gbTipoCaptura.TabIndex = 11;
            this.gbTipoCaptura.TabStop = false;
            this.gbTipoCaptura.Text = "Detecção";
            // 
            // rbtDuas
            // 
            this.rbtDuas.AutoSize = true;
            this.rbtDuas.Location = new System.Drawing.Point(16, 55);
            this.rbtDuas.Name = "rbtDuas";
            this.rbtDuas.Size = new System.Drawing.Size(129, 17);
            this.rbtDuas.TabIndex = 1;
            this.rbtDuas.Text = "TwoFramesDifference";
            this.rbtDuas.UseVisualStyleBackColor = true;
            // 
            // rbtSimples
            // 
            this.rbtSimples.AutoSize = true;
            this.rbtSimples.Checked = true;
            this.rbtSimples.Location = new System.Drawing.Point(16, 29);
            this.rbtSimples.Name = "rbtSimples";
            this.rbtSimples.Size = new System.Drawing.Size(157, 17);
            this.rbtSimples.TabIndex = 0;
            this.rbtSimples.TabStop = true;
            this.rbtSimples.Text = "SimpleBackgroundModeling";
            this.rbtSimples.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 491);
            this.Controls.Add(this.gbTipoCaptura);
            this.Controls.Add(this.gbTipoDestaque);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnDetectarMovimento);
            this.Controls.Add(this.gbxVideo);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblDispositivos);
            this.Controls.Add(this.cbxDispositivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detector de movimento";
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbxVideo.ResumeLayout(false);
            this.gbTipoDestaque.ResumeLayout(false);
            this.gbTipoDestaque.PerformLayout();
            this.gbTipoCaptura.ResumeLayout(false);
            this.gbTipoCaptura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.Label lblDispositivos;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.GroupBox gbxVideo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button btnDetectarMovimento;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.GroupBox gbTipoDestaque;
        private System.Windows.Forms.RadioButton rbtArea;
        private System.Windows.Forms.RadioButton rbtContorno;
        private System.Windows.Forms.GroupBox gbTipoCaptura;
        private System.Windows.Forms.RadioButton rbtDuas;
        private System.Windows.Forms.RadioButton rbtSimples;
    }
}

