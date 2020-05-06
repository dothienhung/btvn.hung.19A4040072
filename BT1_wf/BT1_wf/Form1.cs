using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
           
            

        private void Sum_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(IpA.Text);
            int b = Convert.ToInt32(IpB.Text);

            int kq = 0;
       
        if (a >= b)
        {
            for (int i = b; i <= a; i++)
            {
                kq = kq+i;
            }
        }
        else
        {
            for (int i = a; i <= b; i++)
                kq = kq+i;
        }
        // Gắn kết quả vào txt kết quả
        txtkq.Text = kq.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
