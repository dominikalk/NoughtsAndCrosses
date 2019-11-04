namespace NoughtsAndCrosses
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.theImagesList = new System.Windows.Forms.ImageList(this.components);
            this.Winnerlbl = new System.Windows.Forms.Label();
            this.drawingpnl = new System.Windows.Forms.Panel();
            this.BotRightpic = new System.Windows.Forms.Panel();
            this.MidMidpic = new System.Windows.Forms.Panel();
            this.BotMidpic = new System.Windows.Forms.Panel();
            this.TopLeftpic = new System.Windows.Forms.Panel();
            this.BotLeftpic = new System.Windows.Forms.Panel();
            this.TopMidpic = new System.Windows.Forms.Panel();
            this.MidRightpic = new System.Windows.Forms.Panel();
            this.TopRightpic = new System.Windows.Forms.Panel();
            this.MidLeftpic = new System.Windows.Forms.Panel();
            this.player1txt = new System.Windows.Forms.TextBox();
            this.player1lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2txt = new System.Windows.Forms.TextBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.restartbtn = new System.Windows.Forms.Button();
            this.menubtn = new System.Windows.Forms.Button();
            this.drawingpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // theImagesList
            // 
            this.theImagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("theImagesList.ImageStream")));
            this.theImagesList.TransparentColor = System.Drawing.Color.Black;
            this.theImagesList.Images.SetKeyName(0, "x.png");
            this.theImagesList.Images.SetKeyName(1, "0.png");
            // 
            // Winnerlbl
            // 
            this.Winnerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winnerlbl.Location = new System.Drawing.Point(12, 287);
            this.Winnerlbl.Name = "Winnerlbl";
            this.Winnerlbl.Size = new System.Drawing.Size(254, 25);
            this.Winnerlbl.TabIndex = 9;
            this.Winnerlbl.Text = "Test";
            // 
            // drawingpnl
            // 
            this.drawingpnl.Controls.Add(this.BotRightpic);
            this.drawingpnl.Controls.Add(this.MidMidpic);
            this.drawingpnl.Controls.Add(this.BotMidpic);
            this.drawingpnl.Controls.Add(this.TopLeftpic);
            this.drawingpnl.Controls.Add(this.BotLeftpic);
            this.drawingpnl.Controls.Add(this.TopMidpic);
            this.drawingpnl.Controls.Add(this.MidRightpic);
            this.drawingpnl.Controls.Add(this.TopRightpic);
            this.drawingpnl.Controls.Add(this.MidLeftpic);
            this.drawingpnl.Location = new System.Drawing.Point(12, 12);
            this.drawingpnl.Name = "drawingpnl";
            this.drawingpnl.Size = new System.Drawing.Size(252, 252);
            this.drawingpnl.TabIndex = 10;
            this.drawingpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingpnl_Paint);
            // 
            // BotRightpic
            // 
            this.BotRightpic.BackColor = System.Drawing.Color.Silver;
            this.BotRightpic.Location = new System.Drawing.Point(172, 172);
            this.BotRightpic.Name = "BotRightpic";
            this.BotRightpic.Size = new System.Drawing.Size(80, 80);
            this.BotRightpic.TabIndex = 15;
            this.BotRightpic.Click += new System.EventHandler(this.BotRightpic_Click);
            // 
            // MidMidpic
            // 
            this.MidMidpic.BackColor = System.Drawing.Color.Silver;
            this.MidMidpic.Location = new System.Drawing.Point(86, 86);
            this.MidMidpic.Name = "MidMidpic";
            this.MidMidpic.Size = new System.Drawing.Size(80, 80);
            this.MidMidpic.TabIndex = 15;
            this.MidMidpic.Click += new System.EventHandler(this.MidMidpic_Click);
            // 
            // BotMidpic
            // 
            this.BotMidpic.BackColor = System.Drawing.Color.Silver;
            this.BotMidpic.Location = new System.Drawing.Point(86, 172);
            this.BotMidpic.Name = "BotMidpic";
            this.BotMidpic.Size = new System.Drawing.Size(80, 80);
            this.BotMidpic.TabIndex = 15;
            this.BotMidpic.Click += new System.EventHandler(this.BotMidpic_Click);
            // 
            // TopLeftpic
            // 
            this.TopLeftpic.BackColor = System.Drawing.Color.Silver;
            this.TopLeftpic.Location = new System.Drawing.Point(0, 0);
            this.TopLeftpic.Name = "TopLeftpic";
            this.TopLeftpic.Size = new System.Drawing.Size(80, 80);
            this.TopLeftpic.TabIndex = 11;
            this.TopLeftpic.Click += new System.EventHandler(this.TopLeftpic_Click);
            // 
            // BotLeftpic
            // 
            this.BotLeftpic.BackColor = System.Drawing.Color.Silver;
            this.BotLeftpic.Location = new System.Drawing.Point(0, 172);
            this.BotLeftpic.Name = "BotLeftpic";
            this.BotLeftpic.Size = new System.Drawing.Size(80, 80);
            this.BotLeftpic.TabIndex = 15;
            this.BotLeftpic.Click += new System.EventHandler(this.BotLeftpic_Click);
            // 
            // TopMidpic
            // 
            this.TopMidpic.BackColor = System.Drawing.Color.Silver;
            this.TopMidpic.Location = new System.Drawing.Point(86, 0);
            this.TopMidpic.Name = "TopMidpic";
            this.TopMidpic.Size = new System.Drawing.Size(80, 80);
            this.TopMidpic.TabIndex = 12;
            this.TopMidpic.Click += new System.EventHandler(this.TopMidtpic_Click);
            // 
            // MidRightpic
            // 
            this.MidRightpic.BackColor = System.Drawing.Color.Silver;
            this.MidRightpic.Location = new System.Drawing.Point(172, 86);
            this.MidRightpic.Name = "MidRightpic";
            this.MidRightpic.Size = new System.Drawing.Size(80, 80);
            this.MidRightpic.TabIndex = 15;
            this.MidRightpic.Click += new System.EventHandler(this.MidRightpic_Click);
            // 
            // TopRightpic
            // 
            this.TopRightpic.BackColor = System.Drawing.Color.Silver;
            this.TopRightpic.Location = new System.Drawing.Point(172, 0);
            this.TopRightpic.Name = "TopRightpic";
            this.TopRightpic.Size = new System.Drawing.Size(80, 80);
            this.TopRightpic.TabIndex = 13;
            this.TopRightpic.Click += new System.EventHandler(this.TopRighttpic_Click);
            // 
            // MidLeftpic
            // 
            this.MidLeftpic.BackColor = System.Drawing.Color.Silver;
            this.MidLeftpic.Location = new System.Drawing.Point(0, 86);
            this.MidLeftpic.Name = "MidLeftpic";
            this.MidLeftpic.Size = new System.Drawing.Size(80, 80);
            this.MidLeftpic.TabIndex = 14;
            this.MidLeftpic.Click += new System.EventHandler(this.MidLeftpic_Click);
            // 
            // player1txt
            // 
            this.player1txt.Location = new System.Drawing.Point(309, 28);
            this.player1txt.Name = "player1txt";
            this.player1txt.Size = new System.Drawing.Size(113, 20);
            this.player1txt.TabIndex = 11;
            // 
            // player1lbl
            // 
            this.player1lbl.AutoSize = true;
            this.player1lbl.Location = new System.Drawing.Point(306, 12);
            this.player1lbl.Name = "player1lbl";
            this.player1lbl.Size = new System.Drawing.Size(79, 13);
            this.player1lbl.TabIndex = 12;
            this.player1lbl.Text = "Player 1 Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Player 2 Name:";
            // 
            // player2txt
            // 
            this.player2txt.Location = new System.Drawing.Point(309, 75);
            this.player2txt.Name = "player2txt";
            this.player2txt.Size = new System.Drawing.Size(113, 20);
            this.player2txt.TabIndex = 14;
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(309, 112);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 15;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // restartbtn
            // 
            this.restartbtn.Location = new System.Drawing.Point(309, 141);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(75, 23);
            this.restartbtn.TabIndex = 16;
            this.restartbtn.Text = "Restart";
            this.restartbtn.UseVisualStyleBackColor = true;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // menubtn
            // 
            this.menubtn.Location = new System.Drawing.Point(309, 170);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(75, 23);
            this.menubtn.TabIndex = 17;
            this.menubtn.Text = "Menu";
            this.menubtn.UseVisualStyleBackColor = true;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 327);
            this.Controls.Add(this.menubtn);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.player2txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player1lbl);
            this.Controls.Add(this.player1txt);
            this.Controls.Add(this.drawingpnl);
            this.Controls.Add(this.Winnerlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.drawingpnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList theImagesList;
        private System.Windows.Forms.Label Winnerlbl;
        private System.Windows.Forms.Panel drawingpnl;
        private System.Windows.Forms.Panel TopLeftpic;
        private System.Windows.Forms.Panel TopMidpic;
        private System.Windows.Forms.Panel TopRightpic;
        private System.Windows.Forms.Panel MidLeftpic;
        private System.Windows.Forms.Panel MidMidpic;
        private System.Windows.Forms.Panel MidRightpic;
        private System.Windows.Forms.Panel BotLeftpic;
        private System.Windows.Forms.Panel BotMidpic;
        private System.Windows.Forms.Panel BotRightpic;
        private System.Windows.Forms.TextBox player1txt;
        private System.Windows.Forms.Label player1lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player2txt;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.Button menubtn;
    }
}

