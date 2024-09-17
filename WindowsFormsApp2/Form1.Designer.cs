namespace WindowsFormsApp2
{
    partial class Guess_the_word
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
            this.tb_guess = new System.Windows.Forms.Button();
            this.Tb_answer = new System.Windows.Forms.TextBox();
            this.LB_MaskWord = new System.Windows.Forms.Label();
            this.Wrong_guesses = new System.Windows.Forms.Label();
            this.Wrong_guess_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_guess
            // 
            this.tb_guess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tb_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_guess.ForeColor = System.Drawing.Color.White;
            this.tb_guess.Location = new System.Drawing.Point(121, 345);
            this.tb_guess.Name = "tb_guess";
            this.tb_guess.Size = new System.Drawing.Size(240, 37);
            this.tb_guess.TabIndex = 0;
            this.tb_guess.Text = "Guess!";
            this.tb_guess.UseVisualStyleBackColor = false;
            this.tb_guess.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tb_answer
            // 
            this.Tb_answer.HideSelection = false;
            this.Tb_answer.Location = new System.Drawing.Point(86, 297);
            this.Tb_answer.Name = "Tb_answer";
            this.Tb_answer.Size = new System.Drawing.Size(319, 20);
            this.Tb_answer.TabIndex = 1;
            this.Tb_answer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LB_MaskWord
            // 
            this.LB_MaskWord.AutoSize = true;
            this.LB_MaskWord.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LB_MaskWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaskWord.Location = new System.Drawing.Point(224, 132);
            this.LB_MaskWord.Name = "LB_MaskWord";
            this.LB_MaskWord.Size = new System.Drawing.Size(98, 20);
            this.LB_MaskWord.TabIndex = 2;
            this.LB_MaskWord.Text = "Mask Word";
            this.LB_MaskWord.Click += new System.EventHandler(this.label1_Click);
            // 
            // Wrong_guesses
            // 
            this.Wrong_guesses.AutoSize = true;
            this.Wrong_guesses.Location = new System.Drawing.Point(584, 132);
            this.Wrong_guesses.Name = "Wrong_guesses";
            this.Wrong_guesses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wrong_guesses.Size = new System.Drawing.Size(67, 13);
            this.Wrong_guesses.TabIndex = 3;
            this.Wrong_guesses.Text = "wrong guess";
            // 
            // Wrong_guess_list
            // 
            this.Wrong_guess_list.FormattingEnabled = true;
            this.Wrong_guess_list.Location = new System.Drawing.Point(587, 222);
            this.Wrong_guess_list.Name = "Wrong_guess_list";
            this.Wrong_guess_list.Size = new System.Drawing.Size(120, 95);
            this.Wrong_guess_list.TabIndex = 4;
            // 
            // Guess_the_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wrong_guess_list);
            this.Controls.Add(this.Wrong_guesses);
            this.Controls.Add(this.LB_MaskWord);
            this.Controls.Add(this.Tb_answer);
            this.Controls.Add(this.tb_guess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Guess_the_word";
            this.Text = "Guess The Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tb_guess;
        private System.Windows.Forms.TextBox Tb_answer;
        private System.Windows.Forms.Label LB_MaskWord;
        private System.Windows.Forms.Label Wrong_guesses;
        private System.Windows.Forms.ListBox Wrong_guess_list;
    }
}

