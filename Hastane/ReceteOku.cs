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
    public partial class ReceteOku : Form
    {
        public ReceteOku()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");
        private void ReceteOku_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("İLAÇ ADI", 360);
        }

        DataTable dt = new DataTable();
        private void btn_oku_Click(object sender, EventArgs e)
        {
            string ilaclar;
            if (tb_kod.Text != "")
            {
                listView1.Items.Clear();
                lbl_ad.Text = "";
                tb_teshis.Text = "";
                dt.Clear();
                if (conn.State == ConnectionState.Closed) conn.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM receteler WHERE recete_token=@recete_token", conn);
                command.Parameters.AddWithValue("@recete_token", tb_kod.Text);
                OleDbDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    ilaclar = row["recete_ilac_adi"].ToString();
                    lbl_ad.Text = row["hasta_ad_soyad"].ToString();
                    tb_teshis.Text = row["teshis"].ToString();
                    string[] arr_ilac = ilaclar.Split('|');

                    for (int i = 0; i < arr_ilac.Length; i++)
                    {
                        listView1.Items.Add(new ListViewItem(arr_ilac[i]));
                    }

                }
                else
                {
                    MessageBox.Show("Reçete bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Reçete kodu girmediniz.");
                tb_kod.Text = "";
                listView1.Items.Clear();
                lbl_ad.Text = "";
                tb_teshis.Text = "";
                dt.Clear();
            }
        }
    }
}
