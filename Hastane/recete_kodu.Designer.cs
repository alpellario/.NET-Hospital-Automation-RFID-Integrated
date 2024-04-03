
namespace Hastane
{
    partial class recete_kodu
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
            this.label8 = new System.Windows.Forms.Label();
            this.tb_recete_kod = new System.Windows.Forms.TextBox();
            this.btn_kopyala = new System.Windows.Forms.Button();
            this.lbl_check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(11, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 26);
            this.label8.TabIndex = 65;
            this.label8.Text = "Reçete oluşturma başarılı !";
            // 
            // tb_recete_kod
            // 
            this.tb_recete_kod.Enabled = false;
            this.tb_recete_kod.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_recete_kod.Location = new System.Drawing.Point(42, 57);
            this.tb_recete_kod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_recete_kod.Name = "tb_recete_kod";
            this.tb_recete_kod.Size = new System.Drawing.Size(126, 40);
            this.tb_recete_kod.TabIndex = 66;
            // 
            // btn_kopyala
            // 
            this.btn_kopyala.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_kopyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kopyala.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kopyala.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kopyala.Location = new System.Drawing.Point(172, 57);
            this.btn_kopyala.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kopyala.Name = "btn_kopyala";
            this.btn_kopyala.Size = new System.Drawing.Size(61, 40);
            this.btn_kopyala.TabIndex = 67;
            this.btn_kopyala.Text = "Copy";
            this.btn_kopyala.UseVisualStyleBackColor = false;
            this.btn_kopyala.Click += new System.EventHandler(this.btn_kopyala_Click);
            // 
            // lbl_check
            // 
            this.lbl_check.AutoSize = true;
            this.lbl_check.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_check.ForeColor = System.Drawing.Color.Green;
            this.lbl_check.Location = new System.Drawing.Point(90, 99);
            this.lbl_check.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_check.Name = "lbl_check";
            this.lbl_check.Size = new System.Drawing.Size(84, 19);
            this.lbl_check.TabIndex = 68;
            this.lbl_check.Text = "Kopyalandı.";
            this.lbl_check.Visible = false;
            // 
            // recete_kodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 135);
            this.Controls.Add(this.lbl_check);
            this.Controls.Add(this.btn_kopyala);
            this.Controls.Add(this.tb_recete_kod);
            this.Controls.Add(this.label8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recete_kodu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reçete Kodu";
            this.Load += new System.EventHandler(this.recete_kodu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_recete_kod;
        private System.Windows.Forms.Button btn_kopyala;
        private System.Windows.Forms.Label lbl_check;
    }
}