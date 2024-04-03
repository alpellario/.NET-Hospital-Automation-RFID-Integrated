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
    public partial class Randevular : Form
    {
        public Randevular()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");

        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        void datadoldur()
        {
            ds.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SElect kimlik,islemtarih,tc,ad,soyad,cinsiyet,alinandr,alinanbolum,randevugun,randevusaat from randevular ORDER BY randevugun,randevusaat ASC", conn);


            da.Fill(ds, "randevular");
            conn.Close();
        }
        private void Randevular_Load(object sender, EventArgs e)
        {
            datadoldur();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.MultiSelect = false;
            bs.DataSource = ds.Tables["randevular"];
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "İslem Tarih";
            dataGridView1.Columns[2].HeaderText = "TC Kimlik No";
            dataGridView1.Columns[3].HeaderText = "Ad";
            dataGridView1.Columns[4].HeaderText = "Soyad";
            dataGridView1.Columns[5].HeaderText = "Cinsiyet";
            dataGridView1.Columns[6].HeaderText = "Alınan Doktor";

            dataGridView1.Columns[7].HeaderText = "Alınan Bölüm";
            dataGridView1.Columns[8].HeaderText = "Randevu Günü";
            dataGridView1.Columns[8].Width = 167;
            dataGridView1.Columns[9].HeaderText = "Randevu Saati";


            for (int i = 0; i < 10; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

        }
        DataTable dt = new DataTable();
        DataSet dss = new DataSet();
        BindingSource bss = new BindingSource();

        private void randevusilButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult dialog = new DialogResult();
                int dt = dataGridView1.RowCount;

                dialog = MessageBox.Show(dataGridView1.CurrentRow.Cells[2].Value.ToString() + " TC li " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[4].Value.ToString().ToUpper() + " ye ait " + dataGridView1.CurrentRow.Cells[7].Value.ToString().ToUpper() + " " + dataGridView1.CurrentRow.Cells[9].Value.ToString() + " randevusunu silmek istediğinize eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    DialogResult dialog2 = new DialogResult();
                    dialog2 = MessageBox.Show("Bu randevu silinecek. Bu işlem geri alınamaz. Devam etmek istiyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog2 == DialogResult.Yes)
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        OleDbCommand del = new OleDbCommand("DELETE FROM doktor_randevu where kimlik=@kimlik", conn);
                        del.Parameters.AddWithValue("@kimlik", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        del.ExecuteNonQuery();
                        OleDbCommand del2 = new OleDbCommand("DELETE FROM randevular where kimlik=@kimlik", conn);
                        del2.Parameters.AddWithValue("@kimlik", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        del2.ExecuteNonQuery();
                        datadoldur();
                    }
                    else MessageBox.Show("İşlem iptal edildi!");
                }
                else MessageBox.Show("İşlem iptal edildi!");
            }
            else MessageBox.Show("Randevu Seçimi Yapmadınız!");

        }
    }
}
