using Word_library;

namespace WinFormsApp1
{
    public partial class ShowWordlistForm : Form
    {
        private string[] lists;
        public ShowWordlistForm()
        {
            InitializeComponent();
        }

        private void ShowWordlistForm_Load(object sender, EventArgs e)
        {
            Loadlists();
        }

        private void Loadlists()
        {
            lists = WordList.Getlists();
            listboxWordlists.Items.Clear();
            foreach (var list in lists)
            {
                listboxWordlists.Items.Add(list);
            }
        }

        private void listboxWordlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            WordList loadedList = WordList.LoadList(lists[listboxWordlists.SelectedIndex]);
            listBoxLanguages.Items.Clear();
            foreach (string language in loadedList.Languages)
            {
                listBoxLanguages.Items.Add(language);
            }
            // this.Text = lists[listboxWordlists.SelectedIndex]; 

        }

        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewListForm newListForm = new NewListForm();
            newListForm.ShowDialog();
            if (newListForm.DialogResult != DialogResult.Cancel)
            {
                WordList newWordList = new WordList(newListForm.ListName, newListForm.Languages);
                newWordList.Save();
                Loadlists();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listboxWordlists.SelectedItem != null)
            {
                AddWordsForm addWordsForm = new(listboxWordlists.SelectedItem.ToString());
                addWordsForm.ShowDialog();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Loadlists();
        }
    }
}
