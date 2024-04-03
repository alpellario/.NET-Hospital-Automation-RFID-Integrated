using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Login : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");
        public Login()
        {
            InitializeComponent();
        }
        public static int doktor_id;
        private void dr_login_Click(object sender, EventArgs e)
        {
            
            string id = dr_id.Text;
            string pw = dr_pw.Text;

            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbCommand command = new OleDbCommand("SELECT doktor_id FROM doktor_login WHERE doktor_kullanici_adi=@doktor_kullanici_adi AND doktor_sifre=@doktor_sifre", conn);
            command.Parameters.AddWithValue("@doktor_kullanici_adi", id);
            command.Parameters.AddWithValue("@doktor_sifre", pw);
            OleDbDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                doktor_id = Convert.ToInt32(dr["doktor_id"].ToString());
                DoktorEkran dE = new DoktorEkran();
                this.Hide();
                dE.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Doktor hesabı bulunamadı");
            }
            conn.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
    }
}
