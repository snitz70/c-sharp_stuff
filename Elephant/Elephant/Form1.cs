using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant swap;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            swap = lucinda;
            lucinda = lloyd;
            lloyd = swap;
            MessageBox.Show("Objects swapped");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
