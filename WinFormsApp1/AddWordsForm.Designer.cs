namespace WinFormsApp1
{
    partial class AddWordsForm
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
            this.gbLanguages = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLanguages
            // 
            this.gbLanguages.Controls.Add(this.btnSave);
            this.gbLanguages.Location = new System.Drawing.Point(-1, 12);
            this.gbLanguages.Name = "gbLanguages";
            this.gbLanguages.Size = new System.Drawing.Size(348, 149);
            this.gbLanguages.TabIndex = 2;
            this.gbLanguages.TabStop = false;
            this.gbLanguages.Text = "Add word";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 194);
            this.Controls.Add(this.gbLanguages);
            this.Name = "AddWordsForm";
            this.Text = "AddWordsForm";
            this.Load += new System.EventHandler(this.AddWordsForm_Load);
            this.gbLanguages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbLanguages;
        private Button btnSave;
    }
}