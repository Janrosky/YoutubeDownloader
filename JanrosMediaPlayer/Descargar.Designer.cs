namespace YoutubeDownloader
{
    partial class Descargar
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
            btnPath = new FontAwesome.Sharp.IconButton();
            lblStatus = new Label();
            btnComenzarDescarga = new FontAwesome.Sharp.IconButton();
            txtPath = new TextBox();
            label2 = new Label();
            txtUrl = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPath
            // 
            btnPath.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnPath.IconColor = Color.Black;
            btnPath.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPath.IconSize = 25;
            btnPath.Location = new Point(505, 96);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(49, 24);
            btnPath.TabIndex = 13;
            btnPath.UseVisualStyleBackColor = true;
            btnPath.Click += btnPath_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblStatus.Location = new Point(14, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(23, 18);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "...";
            // 
            // btnComenzarDescarga
            // 
            btnComenzarDescarga.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComenzarDescarga.IconChar = FontAwesome.Sharp.IconChar.None;
            btnComenzarDescarga.IconColor = Color.Black;
            btnComenzarDescarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComenzarDescarga.Location = new Point(165, 144);
            btnComenzarDescarga.Name = "btnComenzarDescarga";
            btnComenzarDescarga.Size = new Size(389, 27);
            btnComenzarDescarga.TabIndex = 11;
            btnComenzarDescarga.Text = "Comienza la Descarga";
            btnComenzarDescarga.UseVisualStyleBackColor = true;
            btnComenzarDescarga.Click += btnComenzarDescarga_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(229, 96);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(271, 23);
            txtPath.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 9;
            label2.Text = "Dirección de Descarga:";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(229, 46);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(325, 23);
            txtUrl.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 54);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 7;
            label1.Text = "Ingresa el URL del Video:";
            // 
            // Descargar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(580, 220);
            Controls.Add(btnPath);
            Controls.Add(lblStatus);
            Controls.Add(btnComenzarDescarga);
            Controls.Add(txtPath);
            Controls.Add(label2);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Descargar";
            Text = "Form1";
            Load += Descargar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnPath;
        private Label lblStatus;
        private FontAwesome.Sharp.IconButton btnComenzarDescarga;
        private TextBox txtPath;
        private Label label2;
        private TextBox txtUrl;
        private Label label1;
    }
}