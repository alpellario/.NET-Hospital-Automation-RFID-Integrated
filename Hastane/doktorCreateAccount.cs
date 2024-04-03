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
    public partial class doktorCreateAccount : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");
        public doktorCreateAccount()
        {
            InitializeComponent();
        }

        private void doktorCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            bool id_varmi = false;
            DataTable kontrol = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            kontrol.Rows.Clear();
            OleDbCommand idoku = new OleDbCommand("SELECT * FROM doktor_login", conn);
            OleDbDataReader idKontrol = idoku.ExecuteReader();
            kontrol.Load(idKontrol);
            for (int i = 0; i < kontrol.Rows.Count; i++)
            {
                if (dr_id.Text == kontrol.Rows[i][2].ToString())
                {
                    id_varmi = true;
                    MessageBox.Show("Bu kullanıcı adı başka bir doktora ait.\nLütfen yeni bir kullanıcı adı giriniz.");
                }
            }
            if (id_varmi != true)
            {
                if (dr_pw.Text == dr_pw2.Text)
                {
                    Doktorkayit.dr_id = dr_id.Text;
                    Doktorkayit.dr_pw = dr_pw.Text;
                    Doktorkayit.kayit_basarili = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girilen şifreler aynı değil. Lütfen kontrol ediniz.");
                }
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Doktorkayit.kayit_basarili = false;
            this.Close();
        }
    }
}
