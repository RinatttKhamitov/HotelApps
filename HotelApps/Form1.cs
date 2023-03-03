using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 1000;

            // асинхронное чтение
            StreamReader f = new StreamReader("table/rooms.txt");
            while (!f.EndOfStream)
            {
                string[] s = f.ReadLine().Split(new char[] { ';' });
                DataGridViewRow row = (DataGridViewRow)dataGridViewRooms.Rows[0].Clone();
                row.Cells[0].Value = s[0];
                row.Cells[1].Value = s[1];
                row.Cells[2].Value = s[2];
                row.Cells[3].Value = s[3];
                dataGridViewRooms.Rows.Add(row);
                // что-нибудь делаем с прочитанной строкой s

            }
            f.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRooms.Rows)
            {
                if (row.Cells[1] == null || row.Cells[1].Value == null)
                    break;
                if (!row.Cells[1].Value.ToString().Equals(textBoxSearch.Text))
                {
                    row.Visible = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioBtnRserved_CheckedChanged(object sender, EventArgs e)
        {
            changeRows("Зарезервировано");
        }

        private void radioBtnFree_CheckedChanged(object sender, EventArgs e)
        {
            changeRows("Свободно");
        }

        private void radioBtnBusy_CheckedChanged(object sender, EventArgs e)
        {
            changeRows("Занято");
        }

        private void radioBtnDischarged_CheckedChanged(object sender, EventArgs e)
        {
            changeRows("Выписываются");
        }
        private void changeRows(string str)
        {
            foreach (DataGridViewRow row in dataGridViewRooms.Rows)
            {
                if (row.Cells[2] == null || row.Cells[2].Value == null)
                    break;


                if (!row.Cells[2].Value.ToString().Equals(str))
                {
                    row.Visible = false;
                }
            }
        }

        private void radioBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRooms.Rows)
            {
                row.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            StreamReader f = new StreamReader("table/resident.txt");
            while (!f.EndOfStream)
            {

                // баг первый чел не показывает
                string[] s = f.ReadLine().Split(new char[] { ';' });
                if (dataGridViewRooms[3, dataGridViewRooms.CurrentCell.RowIndex].Value == null)
                {
                    continue;
                }

                if (int.Parse(s[0]) == int.Parse(dataGridViewRooms[3, dataGridViewRooms.CurrentCell.RowIndex].Value.ToString()))
                {
                    labelFIO.Text = s[1];
                    labelStatus.Text = dataGridViewRooms[2, dataGridViewRooms.CurrentCell.RowIndex].Value.ToString();
                    labelDateArrival.Text = s[4];
                    labelDateDeparture.Text = s[5];
                    lableId.Text = s[0];
                    groupBoxNumber.Text = dataGridViewRooms[1, dataGridViewRooms.CurrentCell.RowIndex].Value.ToString();
                }

            }
            f.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 =  new Form2(lableId.Text);
            form2.Show();
            
        }
    }
}
