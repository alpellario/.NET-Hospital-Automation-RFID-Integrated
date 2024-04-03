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
    public partial class IlacListe : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");
        public IlacListe()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void IlacListe_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.MultiSelect = false;

            ilac_listele();

            dataGridView1.Columns[0].HeaderText = "İLAÇ ID";
            dataGridView1.Columns[1].HeaderText = "İLAÇ ADI";

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns[0].Width = 60;
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);

        }
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        void ilac_listele()
        {
            ds.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select ilac_id, ilac_ad FROM ilaclar ORDER BY ilac_id ASC", conn);
            
            da.Fill(ds, "ilaclar");
            bs.DataSource = ds.Tables["ilaclar"];
            dataGridView1.DataSource = bs;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DoktorEkran.secim = true;
            DoktorEkran.ilac_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DoktorEkran.ilac_ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }


        private void tb_ad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_ad.Text.Trim() == "")
                {
                    ilac_listele();
                }
                else
                {
                    ds.Clear();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("Select ilac_id, ilac_ad FROM ilaclar WHERE ilac_ad LIKE '"+ tb_ad.Text +"%' ORDER BY ilac_ad ASC", conn);
                    da.Fill(ds, "ilaclar");
                    bs.DataSource = ds.Tables["ilaclar"];
                    dataGridView1.DataSource = bs;
                    conn.Close();
                }
            }
            catch { }
        }

        private void tb_seriNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_seriNo.Text.Trim() == "")
                {
                    ilac_listele();
                }
                else
                {
                    ds.Clear();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("Select ilac_id, ilac_ad FROM ilaclar WHERE ilac_id LIKE '" + tb_seriNo.Text + "%' ORDER BY ilac_id ASC", conn);
                    da.Fill(ds, "ilaclar");
                    bs.DataSource = ds.Tables["ilaclar"];
                    dataGridView1.DataSource = bs;
                    conn.Close();
                }
            }
            catch { }
        }

        private void tb_seriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
