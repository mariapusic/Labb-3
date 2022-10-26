namespace Word_library
{
    public class WordList
    {
        private List<Word> Words = new List<Word>();

        public string Name { get; }
        public string[] Languages { get; }

        public WordList(string name, params string[] languages)
        {
            this.Name = name;
            this.Languages = languages;

        }
        public static string[] Getlists()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(path, "Labb3");
            string[] files = Directory.GetFiles(fullPath, "*.dat");
            string[] lists = files.Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();

            return lists;
        }
        public static WordList LoadList(string name)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fileName = name + ".dat";
            string pathAndFile = Path.Combine(path, "Labb3", fileName);
            WordList myWordList;
            try
            {
                using (StreamReader reader = new StreamReader(pathAndFile))
                {

                    string firstLine = reader.ReadLine();
                    string[] langugages = firstLine.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    myWordList = new WordList(name, langugages);
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] translations = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
                        myWordList.Add(translations);
                    }
                }
                
            }
            catch
            {
                return null;
            }
            return myWordList;

        }
        public void Save()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fileName = Name + ".dat";
            string pathAndFile = Path.Combine(path, "Labb3", fileName);
            using (StreamWriter writer = new StreamWriter(pathAndFile))
            {
                writer.WriteLine(String.Join(';', Languages));
                foreach (Word word in Words)
                {
                    writer.WriteLine(String.Join(';', word.Translations));
                }
            }

        }
        public void Add(params string[] translations)
        {
            if (translations.Count() != Languages.Count())
            {
                throw new ArgumentException("Number of translations does not match number of languages!");
            }
            Words.Add(new Word(translations));

        }
        public bool Remove(int translation, string word)
        {
            foreach (Word w in Words)
            {
                if (w.Translations[translation] == word)
                {
                    Words.Remove(w);
                    return true;
                }
            }
            return false;
        }
        public int Count()
        {
            return Words.Count;
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            if (sortByTranslation >= 0 && sortByTranslation <= Languages.Length)
            {
                var sorted = Words.OrderBy(x => x.Translations[sortByTranslation]);

                foreach (Word word in sorted)
                {
                    showTranslations(word.Translations);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("This language does not exist!");
            }
        }
        public Word GetWordToPractice()
        {
            Random random = new Random();
            int randomNumber = random.Next(Words.Count);
            Word randomWord = Words[randomNumber];
            int randomFrom = random.Next(Languages.Length);
            int randomTo = random.Next(Languages.Length);

            while (randomFrom == randomTo)
            {
                randomTo = random.Next(Languages.Length);
            }

            return new Word(randomFrom, randomTo, randomWord.Translations);
        }
    }
}
