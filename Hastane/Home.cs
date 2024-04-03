using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_doktorEkran_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevu rn = new Randevu();
            rn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serial s = new serial();
            s.ShowDialog();
        }

        private void btn_doktorEkran_MouseHover(object sender, EventArgs e)
        {
            btn_doktorEkran.BackColor = Color.SeaGreen;
        }

        private void btn_doktorEkran_MouseLeave(object sender, EventArgs e)
        {
            btn_doktorEkran.BackColor = Color.Transparent;
            btn_doktorEkran.ForeColor = Color.DarkGreen;
        }

        private void btn_doktorEkran_MouseEnter(object sender, EventArgs e)
        {
            btn_doktorEkran.BackColor = ColorTranslator.FromHtml("#05A987");
            btn_doktorEkran.ForeColor = Color.White;
        }

        private void btn_randevu_MouseEnter(object sender, EventArgs e)
        {
            btn_randevu.BackColor = Color.Brown;
            btn_randevu.ForeColor = Color.White;
        }

        private void btn_randevu_MouseLeave(object sender, EventArgs e)
        {
            btn_randevu.BackColor = Color.Transparent;
            btn_randevu.ForeColor = Color.Maroon;
        }

        private void btn_recete_oku_MouseEnter(object sender, EventArgs e)
        {
            btn_recete_oku.BackColor = ColorTranslator.FromHtml("#CC6300");
            btn_recete_oku.ForeColor = Color.White;
        }

        private void btn_recete_oku_MouseLeave(object sender, EventArgs e)
        {
            btn_recete_oku.BackColor = Color.Transparent;
            btn_recete_oku.ForeColor = Color.Orange;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btn_doktorEkran.BackgroundImage =  Image.FromFile(Application.StartupPath + "\\doktor.png");
            btn_randevu.BackgroundImage = Image.FromFile(Application.StartupPath + "\\randevu.png");
            btn_recete_oku.BackgroundImage = Image.FromFile(Application.StartupPath + "\\recete.png");

            //btn_randevu.BackColor = Color.Brown;
            //btn_doktorEkran.BackColor = ColorTranslator.FromHtml("#05A987");
            //btn_recete_oku.BackColor = ColorTranslator.FromHtml("#CC6300");
            //btn_doktorEkran.ForeColor = Color.White;
            //btn_randevu.ForeColor = Color.White;
            //btn_recete_oku.ForeColor = Color.White;
        }

        private void btn_recete_oku_Click(object sender, EventArgs e)
        {
            ReceteOku rO = new ReceteOku();
            rO.ShowDialog();
        }
    }
}
