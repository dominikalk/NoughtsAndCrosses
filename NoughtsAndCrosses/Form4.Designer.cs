namespace NoughtsAndCrosses
{
    partial class Form4
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
            this.player1lbl = new System.Windows.Forms.Label();
            this.player1box = new System.Windows.Forms.ComboBox();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.player2box = new System.Windows.Forms.ComboBox();
            this.player2lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1lbl
            // 
            this.player1lbl.AutoSize = true;
            this.player1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1lbl.Location = new System.Drawing.Point(12, 9);
            this.player1lbl.Name = "player1lbl";
            this.player1lbl.Size = new System.Drawing.Size(91, 25);
            this.player1lbl.TabIndex = 1;
            this.player1lbl.Text = "Player 1";
            // 
            // player1box
            // 
            this.player1box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player1box.FormattingEnabled = true;
            this.player1box.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Black",
            "Purple",
            "Orange",
            "Pink"});
            this.player1box.Location = new System.Drawing.Point(17, 46);
            this.player1box.Name = "player1box";
            this.player1box.Size = new System.Drawing.Size(96, 21);
            this.player1box.TabIndex = 2;
            // 
            // confirmbtn
            // 
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(91, 73);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(79, 38);
            this.confirmbtn.TabIndex = 3;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // player2box
            // 
            this.player2box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player2box.FormattingEnabled = true;
            this.player2box.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Black",
            "Purple",
            "Orange",
            "Pink"});
            this.player2box.Location = new System.Drawing.Point(148, 46);
            this.player2box.Name = "player2box";
            this.player2box.Size = new System.Drawing.Size(96, 21);
            this.player2box.TabIndex = 4;
            // 
            // player2lbl
            // 
            this.player2lbl.AutoSize = true;
            this.player2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2lbl.Location = new System.Drawing.Point(143, 9);
            this.player2lbl.Name = "player2lbl";
            this.player2lbl.Size = new System.Drawing.Size(91, 25);
            this.player2lbl.TabIndex = 5;
            this.player2lbl.Text = "Player 2";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 129);
            this.Controls.Add(this.player2lbl);
            this.Controls.Add(this.player2box);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.player1box);
            this.Controls.Add(this.player1lbl);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1lbl;
        private System.Windows.Forms.ComboBox player1box;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.ComboBox player2box;
        private System.Windows.Forms.Label player2lbl;
    }
}