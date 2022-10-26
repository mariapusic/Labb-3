using Word_library;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWordlistForm showWordlistForm = new ShowWordlistForm();
            showWordlistForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewListForm newListForm = new NewListForm();
            newListForm.ShowDialog();
            if (newListForm.DialogResult != DialogResult.Cancel)
            {
                WordList newWordList = new WordList(newListForm.ListName, newListForm.Languages);
                newWordList.Save();
            }
        }
    }
}