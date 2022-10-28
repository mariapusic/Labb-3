namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPercentages = new System.Windows.Forms.Label();
            this.lbWrongAnswer = new System.Windows.Forms.Label();
            this.lbRightAnswer = new System.Windows.Forms.Label();
            this.lbTotalGuesses = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lbCorrectOrIncorrect = new System.Windows.Forms.Label();
            this.lbTranslation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPercentages);
            this.groupBox1.Controls.Add(this.lbWrongAnswer);
            this.groupBox1.Controls.Add(this.lbRightAnswer);
            this.groupBox1.Controls.Add(this.lbTotalGuesses);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnGuess);
            this.groupBox1.Controls.Add(this.lbCorrectOrIncorrect);
            this.groupBox1.Controls.Add(this.lbTranslation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbUserInput);
            this.groupBox1.Location = new System.Drawing.Point(41, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Practice Words";
            // 
            // lbPercentages
            // 
            this.lbPercentages.AutoSize = true;
            this.lbPercentages.Location = new System.Drawing.Point(172, 167);
            this.lbPercentages.Name = "lbPercentages";
            this.lbPercentages.Size = new System.Drawing.Size(0, 15);
            this.lbPercentages.TabIndex = 8;
            // 
            // lbWrongAnswer
            // 
            this.lbWrongAnswer.AutoSize = true;
            this.lbWrongAnswer.Location = new System.Drawing.Point(12, 167);
            this.lbWrongAnswer.Name = "lbWrongAnswer";
            this.lbWrongAnswer.Size = new System.Drawing.Size(91, 15);
            this.lbWrongAnswer.TabIndex = 7;
            this.lbWrongAnswer.Text = "Wrong answers:";
            // 
            // lbRightAnswer
            // 
            this.lbRightAnswer.AutoSize = true;
            this.lbRightAnswer.Location = new System.Drawing.Point(12, 152);
            this.lbRightAnswer.Name = "lbRightAnswer";
            this.lbRightAnswer.Size = new System.Drawing.Size(83, 15);
            this.lbRightAnswer.TabIndex = 6;
            this.lbRightAnswer.Text = "Right answers:";
            // 
            // lbTotalGuesses
            // 
            this.lbTotalGuesses.AutoSize = true;
            this.lbTotalGuesses.Location = new System.Drawing.Point(8, 22);
            this.lbTotalGuesses.Name = "lbTotalGuesses";
            this.lbTotalGuesses.Size = new System.Drawing.Size(0, 15);
            this.lbTotalGuesses.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Aqua;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(697, 132);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.Aqua;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuess.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuess.Location = new System.Drawing.Point(616, 132);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lbCorrectOrIncorrect
            // 
            this.lbCorrectOrIncorrect.AutoSize = true;
            this.lbCorrectOrIncorrect.Location = new System.Drawing.Point(328, 136);
            this.lbCorrectOrIncorrect.Name = "lbCorrectOrIncorrect";
            this.lbCorrectOrIncorrect.Size = new System.Drawing.Size(0, 15);
            this.lbCorrectOrIncorrect.TabIndex = 3;
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTranslation.Location = new System.Drawing.Point(328, 61);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(73, 18);
            this.lbTranslation.TabIndex = 2;
            this.lbTranslation.Text = "translation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type in translation here:";
            // 
            // tbUserInput
            // 
            this.tbUserInput.Location = new System.Drawing.Point(328, 98);
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(444, 23);
            this.tbUserInput.TabIndex = 0;
            this.tbUserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserInput_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(855, 268);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Label lbTranslation;
        private Label label1;
        private TextBox tbUserInput;
        private Label lbCorrectOrIncorrect;
        private Button btnGuess;
        private Button btnNext;
        private Label lbTotalGuesses;
        private Label lbWrongAnswer;
        private Label lbRightAnswer;
        private Label lbPercentages;
    }
}