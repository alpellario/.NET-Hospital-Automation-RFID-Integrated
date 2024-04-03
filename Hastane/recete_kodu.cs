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
    public partial class recete_kodu : Form
    {
        public recete_kodu()
        {
            InitializeComponent();
        }
        
        private void recete_kodu_Load(object sender, EventArgs e)
        {
            tb_recete_kod.Text = DoktorEkran.token;
        }

        private void btn_kopyala_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(tb_recete_kod.Text);
            lbl_check.Visible = true;
        }
    }
}
