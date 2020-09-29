using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwelveMonths_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            show_month();

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            show_month();
        }
            public void show_month()
        {
            string month;
            month = monthCalendar.SelectionStart.Month.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile("months\\" + month + ".jpg");
            }
            catch
            {
                MessageBox.Show("Каталог с картинками не найден");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }
    }
}
