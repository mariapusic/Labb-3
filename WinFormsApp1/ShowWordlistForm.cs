using Word_library;

namespace WinFormsApp1
{
    public partial class ShowWordlistForm : Form
    {
        private string[] lists;
        private WordList loadedList;
        private int selectedLanguage;
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
            int index = listboxWordlists.SelectedIndex;
            if (index >= 0)
            {
                loadedList = WordList.LoadList(lists[index]);
                listBoxLanguages.Items.Clear();
                foreach (string language in loadedList.Languages)
                {
                    listBoxLanguages.Items.Add(language);
                }
                UpdateWordCountLabel();
                btnPractice.Enabled = true;
            }
        }

        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLanguage = listBoxLanguages.SelectedIndex;
            UpdateTranslationListBox();
        }

        public void AddTranslationToListBox(string[] translations)
        {
            listBoxtranslations.Items.Add(translations[selectedLanguage]);
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
                AddWordsForm addWordsForm = new(loadedList);
                addWordsForm.ShowDialog();
                UpdateWordCountLabel();
                UpdateTranslationListBox();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadedList.Save();
            Close();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string wordToRemove = listBoxtranslations.SelectedItem.ToString();
            loadedList.Remove(selectedLanguage, wordToRemove);
            listBoxtranslations.Items.RemoveAt(listBoxtranslations.SelectedIndex);
            btnRemove.Enabled = false;
        }

        private void UpdateWordCountLabel()
        {
            lbWordCount.Text = $"Word count: {loadedList.Count().ToString()}";
        }

        private void UpdateTranslationListBox()
        {
            listBoxtranslations.Items.Clear();
            loadedList.List(selectedLanguage, AddTranslationToListBox);
        }

        private void listBoxtranslations_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            Form1 practiceForm = new Form1(loadedList);
            practiceForm.ShowDialog();
        }
    }
}
