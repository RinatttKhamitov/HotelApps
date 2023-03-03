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
            StreamReader f = new StreamReader("table/resident.txt");
            while (!f.EndOfStream)
            {
                // баг первый чел не показывает
                string[] s = f.ReadLine().Split(new char[] { ';' });
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
            f.Close();
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
