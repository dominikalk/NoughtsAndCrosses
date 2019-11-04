using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoughtsAndCrosses
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void singlePlayerbtn_Click(object sender, EventArgs e)
        {
            /*
            Form1 form1 = new Form1();
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
              */

            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            form1.isSinglePlayer = true;
            form1.singlePlayer();

            form1.Show();
            this.Hide();
        }

        private void twoPlayerbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            form1.Show();
            this.Hide();
        }
    }
}
