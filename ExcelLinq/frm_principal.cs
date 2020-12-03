using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelLinq
{
    public partial class frm_Principal : Form
    {
        int contador = 0;
        public frm_Principal()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Interval = 3000;
            timer2.Interval = 100;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            contador += 4;
            this.progressBar1.Increment(5);
            if (contador <= 100)
            {
                label1.Text = contador.ToString() + "%";
            }
        }
    }
}
