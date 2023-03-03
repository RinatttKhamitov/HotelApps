using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApps
{
    public partial class Form2 : Form
    {
        public Form2(string idPerson)
        {
            InitializeComponent();
            string[] f = Properties.Resources.resident.Split(new char[] { '\n' });
            foreach (string c in f)
            {
                // баг первый чел не показывает
                string[] s = c.Split(new char[] { ';' });
                if (s[0].Equals(idPerson))
                {
                    label6.Text = s[1];
                    label7.Text = s[2];
                    comboBox1.Text = s[3];
                    comboBox1.Enabled = false;
                    label8.Text = s[4];
                    checkBox1.Enabled = false;

                }

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
