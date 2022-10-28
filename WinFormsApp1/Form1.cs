using Word_library;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private WordList wordList;
        private Word currentPracticeWord;
        private int ifCorrect = 0;
        private int ifIncorrect = 0;
        private int everyUserAnswer = 0;
        public Form1(WordList wordList)
        {
            this.wordList = wordList;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            NextWordPractice();
        }

        private void NextWordPractice()
        {
            currentPracticeWord = wordList.GetWordToPractice();
            lbTranslation.Text =
                $"Translate the {wordList.Languages[currentPracticeWord.FromLanguage]} " +
                $"word \'{currentPracticeWord.Translations[currentPracticeWord.FromLanguage]}\' " +
                $"to {wordList.Languages[currentPracticeWord.ToLanguage]}";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess();
        }

        private void Guess()
        {
            btnGuess.Enabled = false;
            btnNext.Enabled = true;
            if (currentPracticeWord.Translations[currentPracticeWord.ToLanguage].Trim().ToLower() == tbUserInput.Text.ToLower())
            {
                //ifCorrect++;
                lbCorrectOrIncorrect.Text = "Good Job!";
                RightAnswers();
            }
            else
            {
                lbCorrectOrIncorrect.Text =
                    $"Wrong answer! The right answer is \'{currentPracticeWord.Translations[currentPracticeWord.ToLanguage]}\'";
                WrongAnswers();
            }

           
        }

        private void RightAnswers()
        {
            ifCorrect++;
            lbRightAnswer.Text = $"Right answers: {ifCorrect}";
        }

        private void WrongAnswers()
        {
            ifIncorrect++;
            lbWrongAnswer.Text = $"Wrong answers: {ifIncorrect}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lbCorrectOrIncorrect.Text = "";
            tbUserInput.Text = "";
            everyUserAnswer++;
            lbTotalGuesses.Text = $"Total guesses: {everyUserAnswer}";
            NextWordPractice();
            btnNext.Enabled = false;
            btnGuess.Enabled = true;
            lbPercentages.Text = $"Percentage right answers: {(float)ifCorrect / everyUserAnswer * 100:F0}%";
        }

        private void tbUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Guess();
            }
            
        }

    }
}