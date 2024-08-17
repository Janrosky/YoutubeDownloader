namespace JanrosMediaPlayer
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblReservado = new Label();
            btnAcerca = new FontAwesome.Sharp.IconButton();
            btnVer = new FontAwesome.Sharp.IconButton();
            btnDescargar = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblAppTitle = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            folderBrowser = new FolderBrowserDialog();
            panelMain = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(lblReservado);
            panel1.Controls.Add(btnAcerca);
            panel1.Controls.Add(btnVer);
            panel1.Controls.Add(btnDescargar);
            panel1.Controls.Add(PanelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 286);
            panel1.TabIndex = 0;
            // 
            // lblReservado
            // 
            lblReservado.AutoSize = true;
            lblReservado.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReservado.ForeColor = SystemColors.ButtonFace;
            lblReservado.Location = new Point(40, 261);
            lblReservado.Name = "lblReservado";
            lblReservado.Size = new Size(130, 13);
            lblReservado.TabIndex = 2;
            lblReservado.Text = "chacon.jky ®  2024";
            // 
            // btnAcerca
            // 
            btnAcerca.BackColor = Color.AliceBlue;
            btnAcerca.Dock = DockStyle.Top;
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.Font = new Font("Century", 11.25F);
            btnAcerca.ForeColor = SystemColors.ActiveCaptionText;
            btnAcerca.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAcerca.IconColor = Color.Black;
            btnAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAcerca.Location = new Point(0, 205);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(220, 44);
            btnAcerca.TabIndex = 4;
            btnAcerca.Text = "Acerca De";
            btnAcerca.UseVisualStyleBackColor = false;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.AliceBlue;
            btnVer.Dock = DockStyle.Top;
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Century", 11.25F);
            btnVer.ForeColor = SystemColors.ActiveCaptionText;
            btnVer.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVer.IconColor = Color.Black;
            btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVer.Location = new Point(0, 161);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(220, 44);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver Video";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnDescargar
            // 
            btnDescargar.BackColor = Color.AliceBlue;
            btnDescargar.Dock = DockStyle.Top;
            btnDescargar.FlatAppearance.BorderSize = 0;
            btnDescargar.FlatStyle = FlatStyle.Flat;
            btnDescargar.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDescargar.ForeColor = SystemColors.ActiveCaptionText;
            btnDescargar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDescargar.IconColor = Color.Black;
            btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescargar.Location = new Point(0, 117);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(220, 44);
            btnDescargar.TabIndex = 1;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = false;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(36, 36, 36);
            PanelLogo.Controls.Add(iconPictureBox4);
            PanelLogo.Controls.Add(iconPictureBox1);
            PanelLogo.Controls.Add(lblAppTitle);
            PanelLogo.Controls.Add(iconPictureBox2);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.ForeColor = SystemColors.Control;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(220, 117);
            PanelLogo.TabIndex = 0;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(36, 36, 36);
            iconPictureBox4.ForeColor = SystemColors.Control;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Reply;
            iconPictureBox4.IconColor = SystemColors.Control;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 42;
            iconPictureBox4.Location = new Point(124, 12);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(42, 45);
            iconPictureBox4.TabIndex = 3;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(36, 36, 36);
            iconPictureBox1.ForeColor = SystemColors.Control;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            iconPictureBox1.IconColor = SystemColors.Control;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 42;
            iconPictureBox1.Location = new Point(76, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(42, 45);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppTitle.Location = new Point(52, 66);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(114, 36);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Youtube MP3\r\nDownloader";
            lblAppTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(36, 36, 36);
            iconPictureBox2.ForeColor = SystemColors.Control;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Music;
            iconPictureBox2.IconColor = SystemColors.Control;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 42;
            iconPictureBox2.Location = new Point(28, 12);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(42, 45);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 36, 36);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 66);
            panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ActiveCaptionText;
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(iconPictureBox3);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 66);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(580, 220);
            panelMain.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.ActiveCaptionText;
            iconPictureBox3.ForeColor = SystemColors.Control;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconPictureBox3.IconColor = SystemColors.Control;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 117;
            iconPictureBox3.Location = new Point(239, 36);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(125, 117);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(250, 156);
            label1.Name = "label1";
            label1.Size = new Size(101, 13);
            label1.TabIndex = 3;
            label1.Text = "Menu Principal";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 286);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menu";
            Text = "Janros Youtube Downloader";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnDescargar;
        private FontAwesome.Sharp.IconButton btnAcerca;
        private FontAwesome.Sharp.IconButton btnVer;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel2;
        private Label lblReservado;
        private Label lblAppTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FolderBrowserDialog folderBrowser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel panelMain;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label1;
    }
}
