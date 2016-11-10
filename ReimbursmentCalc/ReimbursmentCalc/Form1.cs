using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReimbursmentCalc
{
    public partial class Form1 : Form
    {
        public int startingMileage;
        public int endingMileage;
        public double milesTraveled;
        public double reimburseRate = .39;
        public double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage > endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.",
                    "Cannot Calculate Mileage");
            }
            else
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
        }
    }
}
