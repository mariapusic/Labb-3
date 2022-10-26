namespace WinFormsApp1
{
    public partial class NewListForm : Form
    {
        public string[] Languages;
        public string ListName;
        public NewListForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddLanguage();
        }

        private void AddLanguage()
        {
            if (!string.IsNullOrEmpty(txtLanguage.Text))
            {
                lbLanguages.Items.Add(txtLanguage.Text);
                txtLanguage.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> languageList = new();
            foreach (var language in lbLanguages.Items)
            {
                languageList.Add(language.ToString());
            }

            Languages = languageList.ToArray();
            ListName = txtListName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddLanguage();
            }
        }
    }
}
