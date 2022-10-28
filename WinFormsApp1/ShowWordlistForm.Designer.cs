namespace WinFormsApp1
{
    partial class ShowWordlistForm
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
            this.listboxWordlists = new System.Windows.Forms.ListBox();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbWordCount = new System.Windows.Forms.Label();
            this.listBoxtranslations = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxWordlists
            // 
            this.listboxWordlists.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listboxWordlists.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listboxWordlists.FormattingEnabled = true;
            this.listboxWordlists.ItemHeight = 18;
            this.listboxWordlists.Location = new System.Drawing.Point(30, 55);
            this.listboxWordlists.Name = "listboxWordlists";
            this.listboxWordlists.Size = new System.Drawing.Size(229, 274);
            this.listboxWordlists.TabIndex = 0;
            this.listboxWordlists.SelectedIndexChanged += new System.EventHandler(this.listboxWordlists_SelectedIndexChanged);
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBoxLanguages.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 18;
            this.listBoxLanguages.Location = new System.Drawing.Point(292, 58);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(120, 274);
            this.listBoxLanguages.TabIndex = 1;
            this.listBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Word lists:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Languages:";
            // 
            // btnNewList
            // 
            this.btnNewList.BackColor = System.Drawing.Color.Aqua;
            this.btnNewList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewList.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewList.ForeColor = System.Drawing.Color.Black;
            this.btnNewList.Location = new System.Drawing.Point(30, 346);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(75, 23);
            this.btnNewList.TabIndex = 4;
            this.btnNewList.Text = "New list";
            this.btnNewList.UseVisualStyleBackColor = false;
            this.btnNewList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Aqua;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(405, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(111, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add new word";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbWordCount
            // 
            this.lbWordCount.Location = new System.Drawing.Point(127, 37);
            this.lbWordCount.Name = "lbWordCount";
            this.lbWordCount.Size = new System.Drawing.Size(132, 15);
            this.lbWordCount.TabIndex = 9;
            this.lbWordCount.Text = "Word count:";
            this.lbWordCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBoxtranslations
            // 
            this.listBoxtranslations.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBoxtranslations.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxtranslations.FormattingEnabled = true;
            this.listBoxtranslations.ItemHeight = 17;
            this.listBoxtranslations.Location = new System.Drawing.Point(441, 58);
            this.listBoxtranslations.Name = "listBoxtranslations";
            this.listBoxtranslations.Size = new System.Drawing.Size(120, 276);
            this.listBoxtranslations.TabIndex = 10;
            this.listBoxtranslations.SelectedIndexChanged += new System.EventHandler(this.listBoxtranslations_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(436, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Translations:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aqua;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(486, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Aqua;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(216, 346);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove word";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.Aqua;
            this.btnPractice.Enabled = false;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPractice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPractice.Location = new System.Drawing.Point(324, 346);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(75, 23);
            this.btnPractice.TabIndex = 14;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // ShowWordlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(585, 389);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxtranslations);
            this.Controls.Add(this.lbWordCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.listboxWordlists);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowWordlistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ShowWordlistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listboxWordlists;
        private ListBox listBoxLanguages;
        private Label label1;
        private Label label2;
        private Button btnNewList;
        private Button btnCancel;
        private Button btnAdd;
        private Label lbWordCount;
        private ListBox listBoxtranslations;
        private Label label3;
        private Button btnSave;
        private Button btnRemove;
        private Button btnPractice;
    }
}