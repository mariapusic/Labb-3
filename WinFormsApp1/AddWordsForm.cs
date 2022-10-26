using Word_library;

namespace WinFormsApp1
{
    public partial class AddWordsForm : Form
    {
        private WordList _wordList;
        private List<TextBox> textBoxes = new();
        public AddWordsForm(string listName)
        {
            InitializeComponent();
            _wordList = WordList.LoadList(listName);
        }

        private void AddWordsForm_Load(object sender, EventArgs e)
        {
            int height = 30;

            for (int i = 0; i < _wordList.Languages.Length; i++)
            {
                Label languageLabel = new Label();
                languageLabel.Text = _wordList.Languages[i];
                TextBox newWordTextBox = new TextBox();
                newWordTextBox.Size = new Size(130, 25);
                newWordTextBox.Location = new Point(180, height * i + 30);
                languageLabel.Location = new Point(10, height * i + 30);
                gbLanguages.Controls.Add(languageLabel);
                gbLanguages.Controls.Add(newWordTextBox);
                textBoxes.Add(newWordTextBox);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> translations = new();
            foreach (var textbox in textBoxes)
            {
                translations.Add(textbox.Text);
            }
            _wordList.Add(translations.ToArray());
            _wordList.Save();
            Close();
        }
    }
}

