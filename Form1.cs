using Kalki.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalki
{
    public partial class Form1 : Form
    {
        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();

           /* if (!panel4.Controls.Contains(order.Instance))
            {
                panel4.Controls.Add(order.Instance);//image
                order.Instance.BringToFront();
            }
            else
                order.Instance.BringToFront();*/

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //exit
        }

        private void pictureBox5_Click(object sender, EventArgs e)//menu button slide in
        {
            if (bunifuGradientPanel1.Visible == true)
                bunifuTransition1.HideSync(bunifuGradientPanel1);
            else
                bunifuTransition2.ShowSync(bunifuGradientPanel1);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            bunifuTransition3.ShowSync(pictureBox3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuFlatButton5.Iconimage_right = Resources.Collapse_Arrow_32px;
            if (isCollapsed)
            {
                panel5.Height += 10;
                if (panel5.Size == panel5.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                bunifuFlatButton5.Iconimage_right = Resources.Expand_Arrow_32px;
                panel5.Height -= 10;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //panel2.Height = panel5.Height;
            panel2.Top = panel5.Top;
            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuFlatButton2.Height;
            if (!panel4.Controls.Contains(settings.Instance))
            {
                panel4.Controls.Add(settings.Instance);
                settings.Instance.BringToFront();
            }
            else
                settings.Instance.BringToFront();
            panel2.Top = bunifuFlatButton2.Top;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuFlatButton1.Height;
            if (!panel4.Controls.Contains(orderDetails.Instance))
            {
                panel4.Controls.Add(orderDetails.Instance);
                orderDetails.Instance.BringToFront();
            }
            else
                orderDetails.Instance.BringToFront();
            panel2.Top = bunifuFlatButton1.Top;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuFlatButton4.Height;
            panel2.Top = bunifuFlatButton4.Top;
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
