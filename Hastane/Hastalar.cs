using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Hastane
{
    public partial class Hastalar : Form
    {
        public Hastalar()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");

        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        void datadoldur()
        {
            try
            {
                ds.Clear();
                if (conn.State == ConnectionState.Closed) conn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM Hastalar ORDER BY ad ASC", conn);
                oda.Fill(ds, "Hastalar");
                conn.Close();
            }
            catch { }
        }
        private void Hastalar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.MultiSelect = false;
            datadoldur();
            bs.DataSource = ds.Tables["Hastalar"];
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "RFID NO";
            dataGridView1.Columns[1].HeaderText = "TC KİMLİK NO";
            dataGridView1.Columns[2].HeaderText = "AD";
            dataGridView1.Columns[3].HeaderText = "SOYAD";
            dataGridView1.Columns[4].HeaderText = "CİNSİYET";
            dataGridView1.Columns[5].HeaderText = "ŞEHİR";
            dataGridView1.Columns[6].HeaderText = "ANNE ADI";
            dataGridView1.Columns[7].HeaderText = "BABA ADI";
            dataGridView1.Columns[8].HeaderText = "DOĞUM TARİH";
            dataGridView1.Columns[9].HeaderText = "TELEFON NO";
            dataGridView1.Columns[10].HeaderText = "ADRES";
            dataGridView1.Columns[12].HeaderText = "İŞLEM TARİH";
            dataGridView1.Columns[10].Width = 90;
            dataGridView1.Columns[11].Visible = false;
            for (int i = 0; i < 13; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.EnableHeadersVisualStyles = false;

            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

        }
        DataTable dt = new DataTable();
        DataSet dss = new DataSet();
        BindingSource bss = new BindingSource();

        private void tcgore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcgore.Text.Trim() == "")
                {
                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Hastalar ORDER BY ad ASC", conn);


                    da.Fill(ds, "Hastalar");
                    bs.DataSource = ds.Tables["Hastalar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM Hastalar Where tckimlikno Like'" + tcgore.Text + "%' ORDER BY ad ASC", conn);

                    adtr.Fill(dss, "Hastalar");
                    bss.DataSource = dss.Tables["Hastalar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }

        }

        private void adagore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (adagore.Text.Trim() == "")
                {
                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Hastalar ORDER BY ad ASC", conn);


                    da.Fill(ds, "Hastalar");
                    bs.DataSource = ds.Tables["Hastalar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM Hastalar Where ad Like'" + adagore.Text + "%' ORDER BY ad ASC", conn);

                    adtr.Fill(dss, "Hastalar");
                    bss.DataSource = dss.Tables["Hastalar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }

        }

        private void soyadagore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (soyadagore.Text.Trim() == "")
                {
                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Hastalar ORDER BY ad ASC", conn);


                    da.Fill(ds, "Hastalar");
                    bs.DataSource = ds.Tables["Hastalar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM Hastalar Where soyad Like'" + soyadagore.Text + "%' ORDER BY ad ASC", conn);

                    adtr.Fill(dss, "Hastalar");
                    bss.DataSource = dss.Tables["Hastalar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }

        }

        private void telnogore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (telnogore.Text.Trim() == "")
                {
                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Hastalar ORDER BY ad ASC", conn);


                    da.Fill(ds, "Hastalar");
                    bs.DataSource = ds.Tables["Hastalar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM Hastalar Where telefonno Like'" + telnogore.Text + "%' ORDER BY ad ASC", conn);

                    adtr.Fill(dss, "Hastalar");
                    bss.DataSource = dss.Tables["Hastalar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }

        }

        private void dogumgore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (islemgore.Text.Trim() == "")
                {

                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Hastalar ORDER BY ad ASC", conn);


                    da.Fill(ds, "Hastalar");
                    bs.DataSource = ds.Tables["Hastalar"];
                    dataGridView1.DataSource = bs;

                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM hasta_kayit Where dogumtarih Like'" + dogumgore.Text + "%' ORDER BY ad ASC", conn);

                    adtr.Fill(dss, "Hastalar");
                    bss.DataSource = dss.Tables["Hastalar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }

        }

        private void islemgore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (islemgore.Text.Trim() == "")
                {
                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Hastalar ORDER BY ad ASC", conn);


                    da.Fill(ds, "Hastalar");
                    bs.DataSource = ds.Tables["Hastalar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM Hastalar Where islemtarih Like'" + islemgore.Text + "%' ORDER BY ad ASC", conn);

                    adtr.Fill(dss, "Hastalar");
                    bss.DataSource = dss.Tables["Hastalar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string imagePath;
                string hastaTc = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                if (conn.State == ConnectionState.Closed) conn.Open();
                OleDbCommand findId = new OleDbCommand("select resim from Hastalar WHERE tckimlikno = @tckimlikno", conn);
                findId.Parameters.AddWithValue("@tckimlikno", hastaTc);
                OleDbDataReader dr = findId.ExecuteReader();

                while (dr.Read())
                {
                    imagePath = Application.StartupPath + "\\resimler\\" + dr["resim"].ToString();
                    pictureBox2.Load(imagePath);
                }
                conn.Close();
            }
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
    }
}
