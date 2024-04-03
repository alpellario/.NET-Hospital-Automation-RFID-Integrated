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
    public partial class DoktorListe : Form
    {
        public DoktorListe()
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
                OleDbDataAdapter getir = new OleDbDataAdapter("SELECT * FROM doktorlar ORDER BY doktorad ASC", conn);
                getir.Fill(ds, "doktorlar");
                conn.Close();
            }
            catch { }
        }
        private void DoktorListe_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            datadoldur();
            bs.DataSource = ds.Tables["doktorlar"];
            dataGridView1.DataSource = bs;

            dataGridView1.Columns[0].HeaderText = "DOKTOR TC";
            dataGridView1.Columns[1].HeaderText = "DOKTOR AD";
            dataGridView1.Columns[2].HeaderText = "DOKTOR SOYAD";
            dataGridView1.Columns[3].HeaderText = "DOKTOR CİNSİYET";
            dataGridView1.Columns[4].HeaderText = "DOKTOR BRANS";
            dataGridView1.Columns[5].HeaderText = "DOKTOR TELEFON";
            dataGridView1.Columns[6].HeaderText = "DOKTOR DOĞUM TARİHİ";
            dataGridView1.Columns[7].HeaderText = "DOKTOR KAYIT TARİHİ";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;


            for (int i = 0; i < 9; i++)
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

        public static string tarih, tc, ad, soyad, cinsiyet, brans, telefon, dogum;

        private void button2_Click(object sender, EventArgs e)
        {
            tc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            brans = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            DialogResult dialog = new DialogResult();
            int dt = dataGridView1.RowCount;

            dialog = MessageBox.Show(tc + " TC li " + ad.ToUpper() + " " + soyad.ToUpper() + " kişisine ait HASTANE KAYITINI silmek istediğinize eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                DialogResult dialog2 = new DialogResult();
                dialog2 = MessageBox.Show("Bu DOKTOR ve DOKTORA ait TÜM RANDEVULAR silinecek. Bu işlem geri alınamaz. Devam etmek istiyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog2 == DialogResult.Yes)
                {

                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbCommand del = new OleDbCommand("DELETE FROM doktorlar where doktortc=@doktortc", conn);
                    del.Parameters.AddWithValue("@doktortc", tc);
                    del.ExecuteNonQuery();
                    OleDbCommand del2 = new OleDbCommand("DELETE FROM randevular where alinandr=@alinandr AND alinanbolum=@alinanbolum ", conn);
                    del2.Parameters.AddWithValue("@alinandr", ad + ' ' + soyad);
                    del2.Parameters.AddWithValue("@alinanbolum", brans);

                    del2.ExecuteNonQuery();

                    OleDbCommand del3 = new OleDbCommand("DELETE FROM drsaat where drtc=@drtc", conn);
                    del3.Parameters.AddWithValue("@drtc", tc);
                    del3.ExecuteNonQuery();

                    OleDbCommand del4 = new OleDbCommand("DELETE FROM doktor_randevu where doktor_Ad=@doktor_Ad AND drbrans=@drbrans", conn);
                    del4.Parameters.AddWithValue("@doktor_Ad", ad + ' ' + soyad);
                    del4.Parameters.AddWithValue("@drbrans", brans);
                    del4.ExecuteNonQuery();

                    MessageBox.Show("DOKTORA ait TÜM HASTANE KAYITLARI silindi!");
                    adagore.Clear(); soyadagore.Clear(); telnogore.Clear(); dogumgore.Clear(); islemgore.Clear(); tcgore.Clear();
                    datadoldur();
                    yenile();
                }
                else MessageBox.Show("İşlem iptal edildi!");
            }
            else MessageBox.Show("İşlem iptal edildi!");
        }
        void yenile()
        {
            tcgore.Clear(); adagore.Clear(); soyadagore.Clear(); telnogore.Clear(); dogumgore.Clear(); islemgore.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            int dt = dataGridView1.RowCount;

            dialog = MessageBox.Show("Eğer bir doktorun BRANŞINI değiştirirseniz, o doktora ait tüm randevular silinir. Devam etmek istiyormusuunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                tarih = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                tc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cinsiyet = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                brans = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                telefon = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dogum = dataGridView1.CurrentRow.Cells[6].Value.ToString();




                doktorDuzenle dd = new doktorDuzenle();
                dd.ShowDialog();
                //yenile();
            }
            else { MessageBox.Show("İşlem iptal edildi!"); }

            datadoldur();
            //if (doktorDuzenle.evet == false)
            //{
            //    MessageBox.Show("Doktorun bölümünü değiştirdiğiniz için o doktora ait randevular silindi!");
            //}
        }

        private void tcgore_Click(object sender, EventArgs e)
        {
            adagore.Clear(); soyadagore.Clear(); telnogore.Clear(); dogumgore.Clear(); islemgore.Clear();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string imagePath;
                string docTc = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (conn.State == ConnectionState.Closed) conn.Open();
                OleDbCommand findId = new OleDbCommand("select doktorresim from doktorlar WHERE doktortc = @doktortc", conn);
                findId.Parameters.AddWithValue("@doktortc", docTc);
                OleDbDataReader dr = findId.ExecuteReader();

                while (dr.Read())
                {
                    imagePath = Application.StartupPath + "\\resimler\\" + dr["doktorresim"].ToString();
                    pictureBox2.Load(imagePath);
                }
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            int dt = dataGridView1.RowCount;

            dialog = MessageBox.Show("Kayıtlı " + dt.ToString() + " DOKTORU silmek istediğinize eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                DialogResult dialog2 = new DialogResult();
                dialog2 = MessageBox.Show(dt + " DOKTORLARIN TÜMÜ , onlara ait TÜM RANDEVU ve VERİTABANI verileri silinecek. Bu işlem geri alınamaz. Devam etmek istiyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog2 == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbCommand del = new OleDbCommand("DELETE FROM doktorlar", conn);
                    del.ExecuteNonQuery();
                    //OleDbCommand del2 = new OleDbCommand("DELETE FROM doktor_randevu", conn);
                    //del2.ExecuteNonQuery();
                    OleDbCommand del3 = new OleDbCommand("DELETE FROM drsaat", conn);
                    del3.ExecuteNonQuery();
                    //OleDbCommand del4 = new OleDbCommand("DELETE FROM randevular", conn);
                    //del4.ExecuteNonQuery();

                    MessageBox.Show(dt + " DOKTOR ve TÜM DOKTOR VERİTABANI silindi");
                    datadoldur();
                    conn.Close();
                    yenile();
                }
                else MessageBox.Show("İşlem iptal edildi!");
            }
            else MessageBox.Show("İşlem iptal edildi!");
        }

        private void tcgore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcgore.Text.Trim() == "")
                {
                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM doktorlar ORDER BY doktorad ASC", conn);


                    da.Fill(ds, "doktorlar");
                    bs.DataSource = ds.Tables["doktorlar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM doktorlar Where doktortc Like'" + tcgore.Text + "%' ORDER BY doktorad ASC", conn);


                    adtr.Fill(dss, "doktorlar");
                    bss.DataSource = dss.Tables["doktorlar"];
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
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM doktorlar ORDER BY doktorad ASC", conn);


                    da.Fill(ds, "doktorlar");
                    bs.DataSource = ds.Tables["doktorlar"];
                    dataGridView1.DataSource = bs;

                }
                else
                {
                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM doktorlar Where doktorad Like'" + adagore.Text + "%' ORDER BY doktorad ASC", conn);

                    adtr.Fill(dss, "doktorlar");
                    bss.DataSource = dss.Tables["doktorlar"];
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
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM doktorlar ORDER BY doktorad ASC", conn);


                    da.Fill(ds, "doktorlar");
                    bs.DataSource = ds.Tables["doktorlar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM doktorlar Where doktorsoyad Like'" + soyadagore.Text + "%' ORDER BY doktorad ASC", conn);

                    adtr.Fill(dss, "doktorlar");
                    bss.DataSource = dss.Tables["doktorlar"];
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
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM doktorlar ORDER BY doktorad ASC", conn);


                    da.Fill(ds, "doktorlar");
                    bs.DataSource = ds.Tables["doktorlar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM doktorlar Where doktortelefon Like'" + telnogore.Text + "%' ORDER BY doktorad ASC", conn);

                    adtr.Fill(dss, "doktorlar");
                    bss.DataSource = dss.Tables["doktorlar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }
        }

        private void dogumgore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dogumgore.Text.Trim() == "")
                {
                    ds.Clear();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM doktorlar ORDER BY doktorad ASC", conn);


                    da.Fill(ds, "doktorlar");
                    bs.DataSource = ds.Tables["doktorlar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM doktorlar Where doktordogum Like'" + dogumgore.Text + "%' ORDER BY doktorad ASC", conn);

                    adtr.Fill(dss, "doktorlar");
                    bss.DataSource = dss.Tables["doktorlar"];
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
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM doktorlar ORDER BY doktorad ASC", conn);


                    da.Fill(ds, "doktorlar");
                    bs.DataSource = ds.Tables["doktorlar"];
                    dataGridView1.DataSource = bs;
                }
                else
                {

                    dss.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM doktorlar Where doktorkayit Like'" + islemgore.Text + "%' ORDER BY doktorad ASC", conn);

                    adtr.Fill(dss, "doktorlar");
                    bss.DataSource = dss.Tables["doktorlar"];
                    dataGridView1.DataSource = bss;

                }
            }
            catch { }
        }
    }

}
