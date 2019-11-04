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
    public partial class Form4 : Form
    {

        public Color player1colour;
        public Color player2colour;

        public Form1 form1;

        public Form4()
        {
            InitializeComponent();
        }

        public void singlePlayer()
        {
            player1lbl.Text = "You";
            player2lbl.Text = "Computer";
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            switch(player1box.SelectedIndex)
            {
                case 0:
                    player1colour = Color.Red;
                    break;
                case 1:
                    player1colour = Color.Blue;
                    break;
                case 2:
                    player1colour = Color.Green;
                    break;
                case 3:
                    player1colour = Color.Black;
                    break;
                case 4:
                    player1colour = Color.Purple;
                    break;
                case 5:
                    player1colour = Color.Orange;
                    break;
                case 6:
                    player1colour = Color.Pink;
                    break;       
            }

            switch (player2box.SelectedIndex)
            {
                case 0:
                    player2colour = Color.Red;
                    break;
                case 1:
                    player2colour = Color.Blue;
                    break;
                case 2:
                    player2colour = Color.Green;
                    break;
                case 3:
                    player2colour = Color.Black;
                    break;
                case 4:
                    player2colour = Color.Purple;
                    break;
                case 5:
                    player2colour = Color.Orange;
                    break;
                case 6:
                    player2colour = Color.Pink;
                    break;
            }

            if (player1colour == player2colour)
            {
                MessageBox.Show("Both players cannot use the same colour");
            }
            else 
            {
                form1.player1Colour = player1colour;
                form1.player2Colour = player2colour;

                form1.setPanelColours();

                this.Hide();
            }
        }

        public void setColours() 
        {
            if (player1colour == Color.Red) 
            {
                player1box.SelectedIndex = 0;
            }
            else if (player1colour == Color.Blue)
            {
                player1box.SelectedIndex = 1;
            }
            else if (player1colour == Color.Green)
            {
                player1box.SelectedIndex = 2;
            }
            else if (player1colour == Color.Black)
            {
                player1box.SelectedIndex = 3;
            }
            else if (player1colour == Color.Purple)
            {
                player1box.SelectedIndex = 4;
            }
            else if (player1colour == Color.Orange)
            {
                player1box.SelectedIndex = 5;
            }
            else if (player1colour == Color.Pink)
            {
                player1box.SelectedIndex = 6;
            }

            if (player2colour == Color.Red)
            {
                player2box.SelectedIndex = 0;
            }
            else if (player2colour == Color.Blue)
            {
                player2box.SelectedIndex = 1;
            }
            else if (player2colour == Color.Green)
            {
                player2box.SelectedIndex = 2;
            }
            else if (player2colour == Color.Black)
            {
                player2box.SelectedIndex = 3;
            }
            else if (player2colour == Color.Purple)
            {
                player2box.SelectedIndex = 4;
            }
            else if (player2colour == Color.Orange)
            {
                player2box.SelectedIndex = 5;
            }
            else if (player2colour == Color.Pink)
            {
                player2box.SelectedIndex = 6;
            }
        }

        public void darkMode() 
        {
            this.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            player1lbl.ForeColor = Color.White;
            player2lbl.ForeColor = Color.White;
            confirmbtn.BackColor = Color.DarkGray;
        }
    }
}
