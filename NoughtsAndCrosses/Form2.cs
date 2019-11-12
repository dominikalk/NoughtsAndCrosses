using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NoughtsAndCrosses
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        // if single player is clicked
        private void singlePlayerbtn_Click(object sender, EventArgs e)
        {
            // initialises form variables
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            // sets the variable value and calles a function inside the other form
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

        // so exits propperly
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // plays mario dreaming audio
        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer dream = new SoundPlayer(NoughtsAndCrosses.Properties.Resources.Dream);
            dream.PlayLooping();
        }
    }
}
