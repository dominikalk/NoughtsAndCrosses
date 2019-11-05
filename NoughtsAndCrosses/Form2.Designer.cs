namespace NoughtsAndCrosses
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.singlePlayerbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.twoPlayerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singlePlayerbtn
            // 
            this.singlePlayerbtn.BackColor = System.Drawing.Color.Violet;
            this.singlePlayerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singlePlayerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayerbtn.Location = new System.Drawing.Point(191, 98);
            this.singlePlayerbtn.Name = "singlePlayerbtn";
            this.singlePlayerbtn.Size = new System.Drawing.Size(117, 36);
            this.singlePlayerbtn.TabIndex = 0;
            this.singlePlayerbtn.Text = "Single Player";
            this.singlePlayerbtn.UseVisualStyleBackColor = false;
            this.singlePlayerbtn.Click += new System.EventHandler(this.singlePlayerbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Noughts And Crosses";
            // 
            // twoPlayerbtn
            // 
            this.twoPlayerbtn.BackColor = System.Drawing.Color.Violet;
            this.twoPlayerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoPlayerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPlayerbtn.Location = new System.Drawing.Point(191, 153);
            this.twoPlayerbtn.Name = "twoPlayerbtn";
            this.twoPlayerbtn.Size = new System.Drawing.Size(117, 37);
            this.twoPlayerbtn.TabIndex = 3;
            this.twoPlayerbtn.Text = "Two Player";
            this.twoPlayerbtn.UseVisualStyleBackColor = false;
            this.twoPlayerbtn.Click += new System.EventHandler(this.twoPlayerbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 243);
            this.Controls.Add(this.twoPlayerbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.singlePlayerbtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singlePlayerbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button twoPlayerbtn;
    }
}