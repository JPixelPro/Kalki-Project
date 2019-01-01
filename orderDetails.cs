using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalki
{
    public partial class orderDetails : UserControl
    {
        private static orderDetails obj1;
        public static orderDetails Instance
        {
            get
            {
                if (obj1 == null)
                    obj1 = new orderDetails();
                return obj1;
            }
        }
        public orderDetails()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel1.Controls.Contains(order.Instance))
            {
                bunifuGradientPanel1.Controls.Add(order.Instance);
                order.Instance.BringToFront();
            }
            else
                order.Instance.BringToFront();
        }
    }
}
