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
    public partial class order : UserControl
    {
       private static order obj1;
        String period;
        public static order Instance
        {
            get
            {
                if (obj1 == null)
                    obj1 = new order();
                return obj1;
            }
        }
        public order()
        {
            InitializeComponent();
            panel3.Enabled = false;
            //panel4.Enabled = false;
        }

        

        private void bunifuMetroTextbox9_Click(object sender, EventArgs e)
        {
            // SendToBack();
            /*if (!panel4.Controls.Contains(birthday.Instance))
            {
                panel4.Controls.Add(birthday.Instance);
                birthday.Instance.BringToFront();
            }
            else
                birthday.Instance.BringToFront();*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ceremony = comboBox1.Text;
            if (ceremony == "Other")
            {
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                comboBox2.Enabled = false;
                panel3.Enabled = true;
                
            }
                
           else if(ceremony == "Birthday")
            {
                panel3.Enabled = false;
                comboBox2.Enabled = true;
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                this.comboBox2.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver",
            "Photo Album Only",
            "Photo Only",
            "Photo Only(Home Tea Party)"});
            }
                
            else if (ceremony == "Puberty Ceremony")
            {
                panel3.Enabled = false;
                comboBox2.Enabled = true;
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                this.comboBox2.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver"});
            }
                
            else if (ceremony == "Wedding Ceremony")
            {
                panel3.Enabled = false;
                comboBox2.Enabled = true;
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                this.comboBox2.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver"});
            }
                
            else if (ceremony == "Homecoming")
            {
                panel3.Enabled = false;
                comboBox2.Enabled = true;
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                this.comboBox2.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver"});
            }


            if (period == "full") {
                panel4.Enabled = false;
                bunifuMetroTextbox6.Enabled = false;
                bunifuMetroTextbox7.Enabled = false;
            }//period
                
            else
            {
                // panel4.Enabled = true;
                bunifuMetroTextbox6.Enabled = true;
                bunifuMetroTextbox7.Enabled = true;

                panel4.Enabled = true;
            }
            /*if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }*/


            //package


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            period = "full";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            period = "hour";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
