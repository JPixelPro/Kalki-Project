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
    public partial class front : UserControl
    {
        private static front obj1;
        public static front Instance
        {
            get
            {
                if (obj1 == null)
                    obj1 = new front();
                return obj1;
            }
        }
        public front()
        {
            InitializeComponent();
        }
    }
}
