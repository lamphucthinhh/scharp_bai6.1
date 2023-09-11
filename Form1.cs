using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scharp_bai6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hk1, hk2, dtb;
            hk1 = Convert.ToDouble(txthk1.Text);
            hk2 = Convert.ToDouble(txthk2.Text);
            dtb = (hk1 + hk2) / 2;
            txtdtb.Text = Convert.ToString(dtb);
            if (dtb >= 5)
            {
                txtkq.Text = "được lên lớp";
            } 
            else 
                if (dtb <=5)
            {
                txtkq.Text = " ở lại lớp ";
            }
            if (dtb < 5)
            {
                txtxeploai.Text = "yếu";
            }
            else if (dtb <= 6 )
            {
                txtxeploai.Text = " trung bình";
            }
            else if (dtb < 8 )
            {
                txtxeploai.Text = "khá";
            }
            e

        }
    }
}
