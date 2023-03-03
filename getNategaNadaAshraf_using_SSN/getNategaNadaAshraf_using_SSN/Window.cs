using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getNategaNadaAshraf_using_birthdate
{
    public partial class Window : Form
    {
        public double SSN=0;
        public Window()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            
            var array_Date=date.Split('-');

            string ssn = "";
            //Date
            if (int.Parse(array_Date[2]) > 1999)
            {
                ssn += "3";

            }
            else
            {
                ssn += "2";
            }

            ssn += array_Date[2][1].ToString()+ array_Date[2][0].ToString() + array_Date[1] + array_Date[0] + "2100000";
            this.SSN = double.Parse(ssn);
            Console.WriteLine(double.Parse( ssn));

            Close();






        }
    }
}
