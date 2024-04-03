using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Bar : Form
    {
        public Bar()
        {
            InitializeComponent();
        }

        private void timer1_Tickz(object sender, EventArgs e)
        {
            
                //timer1.Stop();
                //this.Close();
            
        }


        private void Bar_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;//1 second
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
            progressBar1.Maximum = 100;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //do whatever you want
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Close();
            }
            else
                progressBar1.Value += 20;
        }

       
    }
}
