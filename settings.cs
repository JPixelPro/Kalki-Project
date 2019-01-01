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
    public partial class settings : UserControl
    {
        private static settings obj1;

        public static settings Instance
        {
            get
            {
                if (obj1 == null)
                    obj1 = new settings();
                return obj1;
            }
        }
        public settings()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel1.Controls.Contains(employee_mgmt.Instance))
            {
                bunifuGradientPanel1.Controls.Add(employee_mgmt.Instance);
                employee_mgmt.Instance.BringToFront();
            }
            else
                employee_mgmt.Instance.BringToFront();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel1.Controls.Contains(employee_mgmt.Instance))
            {
                bunifuGradientPanel1.Controls.Add(employee_mgmt.Instance);
                employee_mgmt.Instance.BringToFront();
            }
            else
                employee_mgmt.Instance.BringToFront();
        }
    }
}
