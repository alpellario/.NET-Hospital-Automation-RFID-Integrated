
namespace Hastane
{
    partial class Home
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
            this.btn_randevu = new System.Windows.Forms.Button();
            this.btn_recete_oku = new System.Windows.Forms.Button();
            this.btn_doktorEkran = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_randevu
            // 
            this.btn_randevu.BackColor = System.Drawing.Color.Transparent;
            this.btn_randevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_randevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randevu.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_randevu.Location = new System.Drawing.Point(264, 267);
            this.btn_randevu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(313, 177);
            this.btn_randevu.TabIndex = 30;
            this.btn_randevu.Text = "Randevu İşlemleri";
            this.btn_randevu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_randevu.UseVisualStyleBackColor = false;
            this.btn_randevu.Click += new System.EventHandler(this.btn_randevu_Click);
            this.btn_randevu.MouseEnter += new System.EventHandler(this.btn_randevu_MouseEnter);
            this.btn_randevu.MouseLeave += new System.EventHandler(this.btn_randevu_MouseLeave);
            // 
            // btn_recete_oku
            // 
            this.btn_recete_oku.BackColor = System.Drawing.Color.Transparent;
            this.btn_recete_oku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_recete_oku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recete_oku.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_recete_oku.ForeColor = System.Drawing.Color.Orange;
            this.btn_recete_oku.Location = new System.Drawing.Point(27, 120);
            this.btn_recete_oku.Margin = new System.Windows.Forms.Padding(2);
            this.btn_recete_oku.Name = "btn_recete_oku";
            this.btn_recete_oku.Size = new System.Drawing.Size(215, 324);
            this.btn_recete_oku.TabIndex = 29;
            this.btn_recete_oku.Text = "Reçete Oku";
            this.btn_recete_oku.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recete_oku.UseVisualStyleBackColor = false;
            this.btn_recete_oku.Click += new System.EventHandler(this.btn_recete_oku_Click);
            this.btn_recete_oku.MouseEnter += new System.EventHandler(this.btn_recete_oku_MouseEnter);
            this.btn_recete_oku.MouseLeave += new System.EventHandler(this.btn_recete_oku_MouseLeave);
            // 
            // btn_doktorEkran
            // 
            this.btn_doktorEkran.BackColor = System.Drawing.Color.Transparent;
            this.btn_doktorEkran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_doktorEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorEkran.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorEkran.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_doktorEkran.Location = new System.Drawing.Point(599, 120);
            this.btn_doktorEkran.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doktorEkran.Name = "btn_doktorEkran";
            this.btn_doktorEkran.Size = new System.Drawing.Size(215, 324);
            this.btn_doktorEkran.TabIndex = 29;
            this.btn_doktorEkran.Text = "Doktor Ekranı";
            this.btn_doktorEkran.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_doktorEkran.UseVisualStyleBackColor = false;
            this.btn_doktorEkran.Click += new System.EventHandler(this.btn_doktorEkran_Click);
            this.btn_doktorEkran.MouseEnter += new System.EventHandler(this.btn_doktorEkran_MouseEnter);
            this.btn_doktorEkran.MouseLeave += new System.EventHandler(this.btn_doktorEkran_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(322, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 29);
            this.label10.TabIndex = 49;
            this.label10.Text = "ÖZEL X HASTANESİ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(270, -22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 239);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 498);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_randevu);
            this.Controls.Add(this.btn_recete_oku);
            this.Controls.Add(this.btn_doktorEkran);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doktorEkran;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.Button btn_recete_oku;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}