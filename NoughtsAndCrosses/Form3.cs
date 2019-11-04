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
    public partial class Form3 : Form
    {
        bool player1Using;
        int[,] boardList = new int[,] {{0,0,0,0},{0,0,0,0},{0,0,0,0}, {0,0,0,0}};
        int[,] locations = new int[,] { { 0, 0 }, { 0, 100 }, {0, 200}, {100, 0}, {100, 100}, {100, 200}, {200, 0}, {200, 100}, {200, 200}};

        string player1;
        string player2;

        Random rnd = new Random();

        public Form3()
        {
            InitializeComponent();
            Winnerlbl.Text = "";
            player1 = "";
            player2 = "";
            drawingpnl.Invalidate();
        }

        /*
        void drawLines()
        {
            System.Drawing.Graphics g;
            g = drawingpnl.CreateGraphics();
            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Black);
            p.Width = 5;
            g.DrawRectangle(p, 81, 0, 3, 250);
            g.DrawRectangle(p, 168, 0, 3, 250);
            g.DrawRectangle(p, 0, 81, 250, 3);
            g.DrawRectangle(p, 0, 168, 250, 3);
        }
          */

        void changePicture(Panel pictureBox) 
        {
            System.Drawing.Graphics g;
            g = pictureBox.CreateGraphics();
            //System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Black);
            //p.Width = 5;

            if (player1Using)
            {
                //pictureBox.Image = theImagesList.Images[0];
                System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Red);
                p.Width = 5;
                g.DrawEllipse(p, 0, 0, 80, 80);
            }
            else
            {
                //pictureBox.Image = theImagesList.Images[1];
                System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Blue);
                p.Width = 5;
                g.DrawLine(p, 0, 0, 80, 80);
                g.DrawLine(p, 0, 80, 80, 0);
            }
            whosGo();
        }

        void changeArray(int xVal, int yVal, Panel picBox)
        {
            if (checkPlayers())
            {
                if (boardList[xVal, yVal] == 0)
                {
                    if (player1Using)
                    {
                        boardList[xVal, yVal] = 1;
                    }
                    else
                    {
                        boardList[xVal, yVal] = 10;
                    }
                    changePicture(picBox);
                    checkWin();
                    player1Using = !player1Using;
                }
                else
                {
                    Winnerlbl.Text = "You cant reuse a square";
                }

                bool carryOn = false;

                for (int i = 0; i < 3; i++)
                {
                    for (int v = 0; v < 3; v++)
                    {
                        if (boardList[i,v] == 0)
                        {
                            carryOn = true;
                            break;
                        }
                        if (carryOn) 
                        {
                            break;
                        }
                    }        
                }

                if (!carryOn) 
                {
                    Winnerlbl.Text = "No one wins !";
                }
            }
            else 
            {
                MessageBox.Show("You must type in the player names ...");
            }
        }

        void checkWin() 
        {
            //drawLines();
            int tempDiagonal1 = 0;
            int tempDiagonal2 = 0;

            boardList[0, 3] = boardList[0, 0] + boardList[0, 1] + boardList[0, 2];
            boardList[1, 3] = boardList[1, 0] + boardList[1, 1] + boardList[1, 2];
            boardList[2, 3] = boardList[2, 0] + boardList[2, 1] + boardList[2, 2];

            boardList[3, 0] = boardList[0, 0] + boardList[1, 0] + boardList[2, 0];
            boardList[3, 1] = boardList[0, 1] + boardList[1, 1] + boardList[2, 1];
            boardList[3, 2] = boardList[0, 2] + boardList[1, 2] + boardList[2, 2];

            tempDiagonal1 = boardList[0, 0] + boardList[1, 1] + boardList[2, 2];
            tempDiagonal2 = boardList[2, 0] + boardList[1, 1] + boardList[0, 2];

            if (boardList[0, 3] == 3 || boardList[1, 3] == 3 || boardList[2, 3] == 3 || boardList[3, 0] == 3 || boardList[3, 1] == 3 || boardList[3, 2] == 3 || tempDiagonal1 == 3 || tempDiagonal2 == 3) 
            {
                Winnerlbl.Text = player1 + " wins!";
            }
            if (boardList[0, 3] == 30 || boardList[1, 3] == 30 || boardList[2, 3] == 30 || boardList[3, 0] == 30 || boardList[3, 1] == 30 || boardList[3, 2] == 30 || tempDiagonal1 == 30 || tempDiagonal2 == 30)
            {
                Winnerlbl.Text = player2 + " wins!";
            }
        }

        private void TopLeftpic_Click(object sender, EventArgs e)
        {
            changeArray(0, 0, TopLeftpic);
        }

        private void TopMidtpic_Click(object sender, EventArgs e)
        {
            changeArray(0, 1, TopMidpic);
        }

        private void TopRighttpic_Click(object sender, EventArgs e)
        {
            changeArray(0, 2, TopRightpic);
        }

        private void MidLeftpic_Click(object sender, EventArgs e)
        {
            changeArray(1, 0, MidLeftpic);
        }

        private void MidMidpic_Click(object sender, EventArgs e)
        {
            changeArray(1, 1, MidMidpic);
        }

        private void MidRightpic_Click(object sender, EventArgs e)
        {
            changeArray(1, 2, MidRightpic);
        }

        private void BotLeftpic_Click(object sender, EventArgs e)
        {
            changeArray(2, 0, BotLeftpic);
        }

        private void BotMidpic_Click(object sender, EventArgs e)
        {
            changeArray(2, 1, BotMidpic);
        }

        private void BotRightpic_Click(object sender, EventArgs e)
        {
            changeArray(2, 2, BotRightpic);
        }

        private void drawingpnl_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g;
            g = drawingpnl.CreateGraphics();
            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Black);
            p.Width = 5;
            g.DrawRectangle(p, 81, 0, 3, 250);
            g.DrawRectangle(p, 168, 0, 3, 250);
            g.DrawRectangle(p, 0, 81, 250, 3);
            g.DrawRectangle(p, 0, 168, 250, 3);
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (player1txt.Text == "" || player2txt.Text == "")
            {
                MessageBox.Show("You must type in the player names ...");
            }
            else 
            {
                startbtn.Enabled = false;
                player1 = player1txt.Text;
                player2 = player2txt.Text;
                choosePlayer();
            }
        }

        bool checkPlayers() 
        {
            if (player1 == "" || player2 == "")
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            startbtn.Enabled = true;
            player1 = "";
            player2 = "";
            player1txt.Text = "";
            player2txt.Text = "";
            Winnerlbl.Text = "";
            Refresh();
            locations = new int[,] { { 0, 0 }, { 0, 100 }, { 0, 200 }, { 100, 0 }, { 100, 100 }, { 100, 200 }, { 200, 0 }, { 200, 100 }, { 200, 200 } };
            boardList = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            player1Using = true; 
        }

        void choosePlayer() 
        {
            int temp = rnd.Next(0,2);
            if (temp == 0)
            {
                player1Using = true;
                Winnerlbl.Text = player1 + " goes first";
            }
            else 
            {
                player1Using = false;
                Winnerlbl.Text = player2 + " goes first";
            }
        }

        void whosGo() 
        {
            if (player1Using)
            {
                Winnerlbl.Text = "It is " + player1 + "'s go";
            }
            else 
            {
                Winnerlbl.Text = "It is " + player2 + "'s go";
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }
    }
}
