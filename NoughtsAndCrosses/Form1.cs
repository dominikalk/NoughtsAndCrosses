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
    public partial class Form1 : Form
    {
        public bool isSinglePlayer;

        bool started;

        bool player1Using;
        bool isPlayer1Winner;

        int[,] boardList = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        int[,] locations = new int[,] { { 0, 0 }, { 0, 100 }, { 0, 200 }, { 100, 0 }, { 100, 100 }, { 100, 200 }, { 200, 0 }, { 200, 100 }, { 200, 200 } };

        string player1;
        string player2;

        public Color player1Colour = Color.Red;
        public Color player2Colour = Color.Blue;

        Panel pic1;
        Panel pic2;
        Panel pic3;
        Color[] winColours = { Color.Red, Color.Blue, Color.Green, Color.Purple, Color.Orange, Color.Pink };
        int winColour;

        bool win;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Winnerlbl.Text = "";
            player1 = "";
            player2 = "";
            drawingpnl.Invalidate();
            player1Colourpnl.Invalidate();
            player2Colourpnl.Invalidate();
            colourModebox.SelectedIndex = 0;
            diffbox.SelectedIndex = 0;
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

        public void singlePlayer()
        {
            started = false;
            player1Using = true;
            player1 = "You";
            player2 = "Computer";
            diffbox.Visible = true;
            difflbl.Visible = true;
            player1Colourpnl.Visible = false;
            player2Colourpnl.Visible = false;
            player1lbl.Visible = false;
            player2lbl.Visible = false;
            player1txt.Visible = false;
            player2txt.Visible = false;
        }

        void changePicture(Panel pictureBox)
        {
            System.Drawing.Graphics g;
            g = pictureBox.CreateGraphics();

            if (player1Using)
            {
                System.Drawing.Pen p = new System.Drawing.Pen(player1Colour);
                p.Width = 5;
                g.DrawEllipse(p, 0, 0, 80, 80);
            }
            else
            {
                System.Drawing.Pen p = new System.Drawing.Pen(player2Colour);
                p.Width = 5;
                g.DrawLine(p, 0, 0, 80, 80);
                g.DrawLine(p, 0, 80, 80, 0);
            }
        }

        void changeArray(int xVal, int yVal, Panel picBox)
        {
            if (!isSinglePlayer)
            {
                if (win)
                {
                    MessageBox.Show("Someone has won, you cannot carry on");
                }
                else if (checkPlayers())
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
                        player1Using = !player1Using;
                        whosGo();
                        checkWin();
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
                            if (boardList[i, v] == 0)
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

                    if (!carryOn && !win)
                    {
                        Winnerlbl.Text = "No one wins !";
                    }
                }
                else
                {
                    MessageBox.Show("You must type in the player names ...");
                }
            }
            else
            {
                if (win)
                {
                    MessageBox.Show("The match has finished, you cannot carry on");
                }
                else if (!started)
                {
                    MessageBox.Show("You must press start");
                }
                else if (player1Using)
                {
                    bool tempHasPut = false;

                    if (boardList[xVal, yVal] == 0)
                    {
                        tempHasPut = true;
                        boardList[xVal, yVal] = 1;
                        changePicture(picBox);
                        player1Using = !player1Using;
                        whosGo();
                        checkWin();
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
                            if (boardList[i, v] == 0)
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

                    if (tempHasPut && carryOn && !win)
                    {
                        computerWait.Enabled = true;
                    }

                    if (!carryOn && !win)
                    {
                        Winnerlbl.Text = "No one wins !";
                    }
                }
                else
                {
                    boardList[xVal, yVal] = 10;
                    changePicture(picBox);
                    player1Using = !player1Using;
                    whosGo();
                    checkWin(); //Check here

                    bool carryOn = false;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int v = 0; v < 3; v++)
                        {
                            if (boardList[i, v] == 0)
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

                    if (!carryOn && !win)
                    {
                        Winnerlbl.Text = "No one wins !";
                    }
                }
            }
        }

        void checkWin()
        {
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
                if (boardList[0, 3] == 3)
                {
                    pic1 = TopLeftpic;
                    pic2 = TopMidpic;
                    pic3 = TopRightpic;
                }
                else if (boardList[1, 3] == 3)
                {
                    pic1 = MidLeftpic;
                    pic2 = MidMidpic;
                    pic3 = MidRightpic;
                }
                else if (boardList[2, 3] == 3)
                {
                    pic1 = BotLeftpic;
                    pic2 = BotMidpic;
                    pic3 = BotRightpic;
                }
                else if (boardList[3, 0] == 3)
                {
                    pic1 = TopLeftpic;
                    pic2 = MidLeftpic;
                    pic3 = BotLeftpic;
                }
                else if (boardList[3, 1] == 3)
                {
                    pic1 = TopMidpic;
                    pic2 = MidMidpic;
                    pic3 = BotMidpic;
                }
                else if (boardList[3, 2] == 3)
                {
                    pic1 = TopRightpic;
                    pic2 = MidRightpic;
                    pic3 = BotRightpic;
                }
                else if (tempDiagonal1 == 3)
                {
                    pic1 = TopLeftpic;
                    pic2 = MidMidpic;
                    pic3 = BotRightpic;
                }
                else if (tempDiagonal2 == 3)
                {
                    pic1 = TopRightpic;
                    pic2 = MidMidpic;
                    pic3 = BotLeftpic;
                }

                if (!isSinglePlayer)
                {
                    Winnerlbl.Text = player1 + " wins!";
                }
                else
                {
                    Winnerlbl.Text = "You win!";
                }

                win = true;
                isPlayer1Winner = true;
                winChangeColour.Enabled = true;
            }
            if (boardList[0, 3] == 30 || boardList[1, 3] == 30 || boardList[2, 3] == 30 || boardList[3, 0] == 30 || boardList[3, 1] == 30 || boardList[3, 2] == 30 || tempDiagonal1 == 30 || tempDiagonal2 == 30)
            {
                if (boardList[0, 3] == 30)
                {
                    pic1 = TopLeftpic;
                    pic2 = TopMidpic;
                    pic3 = TopRightpic;
                }
                else if (boardList[1, 3] == 30)
                {
                    pic1 = MidLeftpic;
                    pic2 = MidMidpic;
                    pic3 = MidRightpic;
                }
                else if (boardList[2, 3] == 30)
                {
                    pic1 = BotLeftpic;
                    pic2 = BotMidpic;
                    pic3 = BotRightpic;
                }
                else if (boardList[3, 0] == 30)
                {
                    pic1 = TopLeftpic;
                    pic2 = MidLeftpic;
                    pic3 = BotLeftpic;
                }
                else if (boardList[3, 1] == 30)
                {
                    pic1 = TopMidpic;
                    pic2 = MidMidpic;
                    pic3 = BotMidpic;
                }
                else if (boardList[3, 2] == 30)
                {
                    pic1 = TopRightpic;
                    pic2 = MidRightpic;
                    pic3 = BotRightpic;
                }
                else if (tempDiagonal1 == 30)
                {
                    pic1 = TopLeftpic;
                    pic2 = MidMidpic;
                    pic3 = BotRightpic;
                }
                else if (tempDiagonal2 == 30)
                {
                    pic1 = TopRightpic;
                    pic2 = MidMidpic;
                    pic3 = BotLeftpic;
                }

                if (!isSinglePlayer)
                {
                    Winnerlbl.Text = player2 + " wins!";
                }
                else
                {
                    Winnerlbl.Text = "The computer wins!";
                }

                win = true;
                isPlayer1Winner = false;
                winChangeColour.Enabled = true;
            }
        }

        private void TopLeftpic_Click(object sender, EventArgs e)
        {
            if (!isSinglePlayer)
            {
                changeArray(0, 0, TopLeftpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(0, 0, TopLeftpic);
                }
            }
        }

        private void TopMidtpic_Click(object sender, EventArgs e)
        {
            if (!isSinglePlayer)
            {
                changeArray(0, 1, TopMidpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(0, 1, TopMidpic);
                }
            }
        }

        private void TopRighttpic_Click(object sender, EventArgs e)
        {
            if (!isSinglePlayer)
            {
                changeArray(0, 2, TopRightpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(0, 2, TopRightpic);
                }
            }
        }

        private void MidLeftpic_Click(object sender, EventArgs e)
        {

            if (!isSinglePlayer)
            {
                changeArray(1, 0, MidLeftpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(1, 0, MidLeftpic);
                }
            }
        }

        private void MidMidpic_Click(object sender, EventArgs e)
        {

            if (!isSinglePlayer)
            {
                changeArray(1, 1, MidMidpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(1, 1, MidMidpic);
                }
            }
        }

        private void MidRightpic_Click(object sender, EventArgs e)
        {

            if (!isSinglePlayer)
            {
                changeArray(1, 2, MidRightpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(1, 2, MidRightpic);
                }
            }
        }

        private void BotLeftpic_Click(object sender, EventArgs e)
        {

            if (!isSinglePlayer)
            {
                changeArray(2, 0, BotLeftpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(2, 0, BotLeftpic);
                }
            }
        }

        private void BotMidpic_Click(object sender, EventArgs e)
        {

            if (!isSinglePlayer)
            {
                changeArray(2, 1, BotMidpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(2, 1, BotMidpic);
                }
            }
        }

        private void BotRightpic_Click(object sender, EventArgs e)
        {

            if (!isSinglePlayer)
            {
                changeArray(2, 2, BotRightpic);
            }
            else
            {
                if (player1Using)
                {
                    changeArray(2, 2, BotRightpic);
                }
            }
        }

        private void drawingpnl_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g;
            g = drawingpnl.CreateGraphics();
            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Purple);
            p.Width = 5;
            g.DrawRectangle(p, 81, 0, 3, 250);
            g.DrawRectangle(p, 168, 0, 3, 250);
            g.DrawRectangle(p, 0, 81, 250, 3);
            g.DrawRectangle(p, 0, 168, 250, 3);
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (!isSinglePlayer)
            {
                if (player1txt.Text == "" || player2txt.Text == "")
                {
                    MessageBox.Show("You must type in the player names ...");
                }
                else
                {
                    colourbtn.Enabled = false;
                    startbtn.Enabled = false;
                    player1 = player1txt.Text;
                    player2 = player2txt.Text;
                    choosePlayer();
                }
            }
            else
            {
                diffbox.Enabled = false;
                started = true;
                colourbtn.Enabled = false;
                startbtn.Enabled = false;
                choosePlayer();
                if (!player1Using)
                {
                    computerWait.Enabled = true;
                }
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
            diffbox.Enabled = true;
            started = false;
            computerWait.Enabled = false;
            winChangeColour.Enabled = false;
            colourbtn.Enabled = true;
            startbtn.Enabled = true;
            win = false;
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
            int temp = rnd.Next(0, 2);
            if (!isSinglePlayer)
            {
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
            else
            {
                if (temp == 0)
                {
                    player1Using = true;
                    Winnerlbl.Text = "It is your go first";
                }
                else
                {
                    player1Using = false;
                    Winnerlbl.Text = "It is the computer's go first";
                    computerWait.Enabled = true;
                }
            }
        }

        void whosGo()
        {
            if (!isSinglePlayer)
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
            else
            {
                if (player1Using)
                {
                    Winnerlbl.Text = "It is your go";
                }
                else
                {
                    Winnerlbl.Text = "It is the computer's go";
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }

        private void colourModebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (colourModebox.SelectedIndex == 0)
            //{
            //    this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            //    difflbl.ForeColor = Color.Black;
            //    player1lbl.ForeColor = Color.Black;
            //    player2lbl.ForeColor = Color.Black;
            //    Winnerlbl.ForeColor = Color.Black;
            //    startbtn.BackColor = Color.Transparent;
            //    restartbtn.BackColor = Color.Transparent;
            //    colourbtn.BackColor = Color.Transparent;
            //    menubtn.BackColor = Color.Transparent;
            //}
            //else
            //{
            //    this.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            //    difflbl.ForeColor = Color.White;
            //    player1lbl.ForeColor = Color.White;
            //    player2lbl.ForeColor = Color.White;
            //    Winnerlbl.ForeColor = Color.White;
            //    startbtn.BackColor = Color.DarkGray;
            //    restartbtn.BackColor = Color.DarkGray;
            //    colourbtn.BackColor = Color.DarkGray;
            //    menubtn.BackColor = Color.DarkGray;
            //}
        }

        private void colourbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.player1colour = player1Colour;
            form4.player2colour = player2Colour;
            form4.setColours();
            form4.form1 = this;
            if (isSinglePlayer)
            {
                form4.singlePlayer();
            }

            if (colourModebox.SelectedIndex == 1)
            {
                form4.darkMode();
            }

            form4.Show();
        }

        public void setPanelColours()
        {
            System.Drawing.Graphics g;
            g = player1Colourpnl.CreateGraphics();

            System.Drawing.Graphics h;
            h = player2Colourpnl.CreateGraphics();

            System.Drawing.Pen p1Pen = new System.Drawing.Pen(player1Colour);
            System.Drawing.Pen p2Pen = new System.Drawing.Pen(player2Colour);

            p1Pen.Width = 5;
            p2Pen.Width = 5;

            g.DrawRectangle(p1Pen, 0, 0, 13, 13);
            h.DrawRectangle(p2Pen, 0, 0, 13, 13);
        }

        private void player1Colourpnl_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g;
            g = player1Colourpnl.CreateGraphics();
            System.Drawing.Pen p1Pen = new System.Drawing.Pen(player1Colour);
            p1Pen.Width = 5;
            g.DrawRectangle(p1Pen, 0, 0, 13, 13);
        }

        private void player2Colourpnl_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics h;
            h = player2Colourpnl.CreateGraphics();
            System.Drawing.Pen p2Pen = new System.Drawing.Pen(player2Colour);
            p2Pen.Width = 5;
            h.DrawRectangle(p2Pen, 0, 0, 13, 13);
        }

        private void winChangeColour_Tick(object sender, EventArgs e)
        {
            if (winColour < winColours.Length - 1)
            {
                winColour += 1;
            }
            else
            {
                winColour = 0;
            }
            changePic(pic1, pic2, pic3);
        }

        void changePic(Panel thePic1, Panel thePic2, Panel thePic3)
        {
            Panel[] tempArray = { thePic1, thePic2, thePic3 };
            if (isPlayer1Winner)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    System.Drawing.Graphics g;
                    g = tempArray[i].CreateGraphics();
                    System.Drawing.Pen p = new System.Drawing.Pen(winColours[winColour]);
                    p.Width = 5;
                    g.DrawEllipse(p, 0, 0, 80, 80);
                }
            }
            else
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    System.Drawing.Graphics g;
                    g = tempArray[i].CreateGraphics();
                    System.Drawing.Pen p = new System.Drawing.Pen(winColours[winColour]);
                    p.Width = 5;
                    g.DrawLine(p, 0, 0, 80, 80);
                    g.DrawLine(p, 0, 80, 80, 0);
                }
            }
        }

        private void computerWait_Tick(object sender, EventArgs e)
        {
            if (diffbox.SelectedIndex == 0)
            {
                easySingle();
            }
            else if (diffbox.SelectedIndex == 1)
            {
                mediumSingle();
            }
            else if (diffbox.SelectedIndex == 2)
            {
                hardSingle();
            }
        }

        void easySingle()
        {
            // Finds free spaces
            bool[,] tempUsed = { { true, true, true }, { true, true, true }, { true, true, true } };
            int noFree = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    if (boardList[i, v] == 0)
                    {
                        tempUsed[i, v] = false;
                        noFree += 1;
                    }
                }
            }

            // Choses random free position
            int tempRand = rnd.Next(0, noFree);
            int x = 0;
            int y = 0;
            bool hasChosen = false;
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    if (tempUsed[i, v] == false)
                    {

                        if (tempRand == 0)
                        {
                            hasChosen = true;
                            x = i;
                            y = v;
                            break;
                        }
                        else
                        {
                            tempRand -= 1;
                        }
                    }

                }
                if (hasChosen)
                {
                    break;
                }
            }

            // Calls changeArray for that position
            switch (x)
            {
                case 0:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, TopLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, TopMidpic);
                            break;
                        case 2:
                            changeArray(x, y, TopRightpic);
                            break;
                    }
                    break;
                case 1:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, MidLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, MidMidpic);
                            break;
                        case 2:
                            changeArray(x, y, MidRightpic);
                            break;
                    }
                    break;
                case 2:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, BotLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, BotMidpic);
                            break;
                        case 2:
                            changeArray(x, y, BotRightpic);
                            break;
                    }
                    break;
            }
            computerWait.Enabled = false;
        }

        int virtualCheckWin(int x, int y, bool tryingWin, int[,] arrayGiven)
        {
            // 0 = nothing
            // 1 = player would have won
            // 2 = player would have lost

            //int[,] tempVirtualArray = new boardList;

            int[,] tempVirtualArray = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            for (int i = 0; i < 4; i++)
            {
                for (int v = 0; v < 4; v++)
                {
                    tempVirtualArray[i, v] = arrayGiven[i, v];
                }
            }

            if (tryingWin)
            {
                tempVirtualArray[x, y] = 10;
            }
            else
            {
                tempVirtualArray[x, y] = 1;
            }

            Console.WriteLine("Arrays");
            Console.WriteLine(boardList[x, y]);
            Console.WriteLine(tempVirtualArray[x, y]);

            int tempDiagonal1 = 0;
            int tempDiagonal2 = 0;

            tempVirtualArray[0, 3] = tempVirtualArray[0, 0] + tempVirtualArray[0, 1] + tempVirtualArray[0, 2];
            tempVirtualArray[1, 3] = tempVirtualArray[1, 0] + tempVirtualArray[1, 1] + tempVirtualArray[1, 2];
            tempVirtualArray[2, 3] = tempVirtualArray[2, 0] + tempVirtualArray[2, 1] + tempVirtualArray[2, 2];

            tempVirtualArray[3, 0] = tempVirtualArray[0, 0] + tempVirtualArray[1, 0] + tempVirtualArray[2, 0];
            tempVirtualArray[3, 1] = tempVirtualArray[0, 1] + tempVirtualArray[1, 1] + tempVirtualArray[2, 1];
            tempVirtualArray[3, 2] = tempVirtualArray[0, 2] + tempVirtualArray[1, 2] + tempVirtualArray[2, 2];

            tempDiagonal1 = tempVirtualArray[0, 0] + tempVirtualArray[1, 1] + tempVirtualArray[2, 2];
            tempDiagonal2 = tempVirtualArray[2, 0] + tempVirtualArray[1, 1] + tempVirtualArray[0, 2];

            if (tempVirtualArray[0, 3] == 3 || tempVirtualArray[1, 3] == 3 || tempVirtualArray[2, 3] == 3 || tempVirtualArray[3, 0] == 3 || tempVirtualArray[3, 1] == 3 || tempVirtualArray[3, 2] == 3 || tempDiagonal1 == 3 || tempDiagonal2 == 3)
            {
                if (tempVirtualArray[0, 3] == 3)
                {
                    return (1);
                }
                else if (tempVirtualArray[1, 3] == 3)
                {
                    return (1);
                }
                else if (tempVirtualArray[2, 3] == 3)
                {
                    return (1);
                }
                else if (tempVirtualArray[3, 0] == 3)
                {
                    return (1);
                }
                else if (tempVirtualArray[3, 1] == 3)
                {
                    return (1);
                }
                else if (tempVirtualArray[3, 2] == 3)
                {
                    return (1);
                }
                else if (tempDiagonal1 == 3)
                {
                    return (1);
                }
                else if (tempDiagonal2 == 3)
                {
                    return (1);
                }
                else
                {
                    return (0);
                }
            }
            else if (tempVirtualArray[0, 3] == 30 || tempVirtualArray[1, 3] == 30 || tempVirtualArray[2, 3] == 30 || tempVirtualArray[3, 0] == 30 || tempVirtualArray[3, 1] == 30 || tempVirtualArray[3, 2] == 30 || tempDiagonal1 == 30 || tempDiagonal2 == 30)
            {
                if (tempVirtualArray[0, 3] == 30)
                {
                    return (2);
                }
                else if (tempVirtualArray[1, 3] == 30)
                {
                    return (2);
                }
                else if (tempVirtualArray[2, 3] == 30)
                {
                    return (2);
                }
                else if (tempVirtualArray[3, 0] == 30)
                {
                    return (2);
                }
                else if (tempVirtualArray[3, 1] == 30)
                {
                    return (2);
                }
                else if (tempVirtualArray[3, 2] == 30)
                {
                    return (2);
                }
                else if (tempDiagonal1 == 30)
                {
                    return (2);
                }
                else if (tempDiagonal2 == 30)
                {
                    return (2);
                }
                else
                {
                    return (0);
                }
            }
            else
            {
                return (0);
            }

        }

        void mediumSingle()
        {
            // Finds free spaces
            bool[,] tempUsed = { { true, true, true }, { true, true, true }, { true, true, true } };
            int noFree = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    if (boardList[i, v] == 0)
                    {
                        tempUsed[i, v] = false;
                        noFree += 1;
                    }
                }
            }

            int tempRand = rnd.Next(0, noFree); // only if will get to random
            int x = 0;
            int y = 0;
            bool hasChosen = false;

            // check if can win
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    if (tempUsed[i, v] == false)
                    {
                        if (virtualCheckWin(i, v, true, boardList) == 2)
                        {
                            x = i;
                            y = v;
                            hasChosen = true;
                            break;
                        }
                    }
                }
                if (hasChosen)
                {
                    break;
                }
            }


            // check if would have lost
            if (!hasChosen)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int v = 0; v < 3; v++)
                    {
                        if (tempUsed[i, v] == false)
                        {
                            if (virtualCheckWin(i, v, false, boardList) == 1)
                            {
                                x = i;
                                y = v;
                                hasChosen = true;
                                break;
                            }
                        }
                    }
                    if (hasChosen)
                    {
                        break;
                    }
                }
            }


            // Random
            if (!hasChosen)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int v = 0; v < 3; v++)
                    {
                        if (tempUsed[i, v] == false)
                        {

                            if (tempRand == 0)
                            {
                                hasChosen = true;
                                x = i;
                                y = v;
                                break;
                            }
                            else
                            {
                                tempRand -= 1;
                            }
                        }

                    }
                    if (hasChosen)
                    {
                        break;
                    }
                }
            }

            switch (x)
            {
                case 0:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, TopLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, TopMidpic);
                            break;
                        case 2:
                            changeArray(x, y, TopRightpic);
                            break;
                    }
                    break;
                case 1:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, MidLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, MidMidpic);
                            break;
                        case 2:
                            changeArray(x, y, MidRightpic);
                            break;
                    }
                    break;
                case 2:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, BotLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, BotMidpic);
                            break;
                        case 2:
                            changeArray(x, y, BotRightpic);
                            break;
                    }
                    break;
            }
            computerWait.Enabled = false;
        }

        void hardSingle()
        {
            // Finds free spaces
            bool[,] tempUsed = { { true, true, true }, { true, true, true }, { true, true, true } };
            int noFree = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    if (boardList[i, v] == 0)
                    {
                        tempUsed[i, v] = false;
                        noFree += 1;
                    }
                }
            }

            int tempRand = rnd.Next(0, noFree); // only if will get to random
            int x = 0;
            int y = 0;
            bool hasChosen = false;

            // check if can win
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    if (tempUsed[i, v] == false)
                    {
                        if (virtualCheckWin(i, v, true, boardList) == 2)
                        {
                            x = i;
                            y = v;
                            hasChosen = true;
                            break;
                        }
                    }
                }
                if (hasChosen)
                {
                    break;
                }
            }

            // check if would have lost
            if (!hasChosen)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int v = 0; v < 3; v++)
                    {
                        if (tempUsed[i, v] == false)
                        {
                            if (virtualCheckWin(i, v, false, boardList) == 1)
                            {
                                x = i;
                                y = v;
                                hasChosen = true;
                                break;
                            }
                        }
                    }
                    if (hasChosen)
                    {
                        break;
                    }
                }
            }

            if (!hasChosen)
            {
                if (boardList[1, 1] == 0)
                {
                    x = 1;
                    y = 1;
                    hasChosen = true;
                }
                else if (boardList[1, 1] == 10)
                {
                    //TopMid
                    if (boardList[1, 0] == 1)
                    {
                        if (boardList[0, 2] == 0)
                        {
                            x = 0;
                            y = 2;
                            hasChosen = true;
                        }
                        else if (boardList[2, 2] == 0)
                        {
                            x = 2;
                            y = 2;
                            hasChosen = true;
                        }
                    }
                    // Mid Right
                    else if (boardList[2, 1] == 1)
                    {
                        if (boardList[0, 0] == 0)
                        {
                            x = 0;
                            y = 0;
                            hasChosen = true;
                        }
                        else if (boardList[0, 2] == 0)
                        {
                            x = 0;
                            y = 2;
                            hasChosen = true;
                        }
                    }
                    // Bot Mid
                    else if (boardList[1, 2] == 1)
                    {
                        if (boardList[0, 0] == 0)
                        {
                            x = 0;
                            y = 0;
                            hasChosen = true;
                        }
                        else if (boardList[2, 0] == 0)
                        {
                            x = 2;
                            y = 0;
                            hasChosen = true;
                        }
                    }

                    // Mid left
                    else if (boardList[0, 1] == 1)
                    {
                        if (boardList[2, 0] == 0)
                        {
                            x = 2;
                            y = 0;
                            hasChosen = true;
                        }
                        else if (boardList[2, 2] == 0)
                        {
                            x = 2;
                            y = 2;
                            hasChosen = true;
                        }
                    }
                }
                else if (boardList[1, 1] == 1)
                {
                    if (boardList[0, 0] == 10 || boardList[2, 0] == 10 || boardList[2, 2] == 10 || boardList[0, 2] == 10)
                    {

                    }
                    else if (boardList[0, 0] == 0)
                    {
                        x = 2;
                        y = 0;
                        hasChosen = true;
                    }
                    else if (boardList[2, 0] == 0)
                    {
                        x = 2;
                        y = 0;
                        hasChosen = true;
                    }
                    else if (boardList[2, 2] == 0)
                    {
                        x = 2;
                        y = 2;
                        hasChosen = true;
                    }
                    else if (boardList[0, 2] == 0)
                    {
                        x = 0;
                        y = 2;
                        hasChosen = true;
                    }
                }
            }

            // Random
            if (!hasChosen)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int v = 0; v < 3; v++)
                    {
                        if (tempUsed[i, v] == false)
                        {

                            if (tempRand == 0)
                            {
                                hasChosen = true;
                                x = i;
                                y = v;
                                break;
                            }
                            else
                            {
                                tempRand -= 1;
                            }
                        }

                    }
                    if (hasChosen)
                    {
                        break;
                    }
                }
            }

            switch (x)
            {
                case 0:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, TopLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, TopMidpic);
                            break;
                        case 2:
                            changeArray(x, y, TopRightpic);
                            break;
                    }
                    break;
                case 1:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, MidLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, MidMidpic);
                            break;
                        case 2:
                            changeArray(x, y, MidRightpic);
                            break;
                    }
                    break;
                case 2:
                    switch (y)
                    {
                        case 0:
                            changeArray(x, y, BotLeftpic);
                            break;
                        case 1:
                            changeArray(x, y, BotMidpic);
                            break;
                        case 2:
                            changeArray(x, y, BotRightpic);
                            break;
                    }
                    break;
            }
            computerWait.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
