using Word_library;

if (args.Length > 0)
{
    if ("-lists" == args[0])
    {
        if (args.Length == 1)
        {
            string[] lists = WordList.Getlists();
            foreach (var list in lists)
            {
                Console.WriteLine(list);
            }
        }
        else
        {
            Console.WriteLine("Error: -lists doesn't take additional arguments.");
        }
    }
    else if ("-count" == args[0])
    {
        if (args.Length == 2)
        {
            string listName = args[1];
            WordList wordList = WordList.LoadList(listName);
            if (wordList is null) PrintListDoesNotExistAndExit(listName);

            int numberOfWords = wordList.Count();
            Console.WriteLine($"Number of words in list \"{listName}\": {numberOfWords}");

        }
        else if (args.Length == 1)
        {
            Console.WriteLine("Error: -count must have a listname.");
        }
        else
        {
            Console.WriteLine("Error: -count only takes one listname.");
        }

    }
    else if ("-practice" == args[0])
    {
        if (args.Length == 2)
        {
            int points = 0;
            int guesses = 0;
            string listName = args[1];
            WordList wordList = WordList.LoadList(listName);
            if (wordList is null) PrintListDoesNotExistAndExit(listName);

            while (true)
            {
                Word practiceWords = wordList.GetWordToPractice();
                Console.WriteLine($"Translate the {wordList.Languages[practiceWords.FromLanguage]} word \"{practiceWords.Translations[practiceWords.FromLanguage]}\" to " +
                    $"{wordList.Languages[practiceWords.ToLanguage]} :");
                string answer = Console.ReadLine();
                if (answer == "")
                {
                    var partOf = Convert.ToDouble(points) / guesses;
                    partOf = partOf * 100;
                    Console.WriteLine($"Correct answers are {points}/{guesses}. " +
                        $"That equals {partOf:f0}% correct answers!");
                    break;
                }
                if (practiceWords.Translations[practiceWords.ToLanguage].ToLower() == answer.ToLower())
                {
                    points++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCorrect answer! Good job!\n***************************\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nWrong answer! \nThe right answer is: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\"{practiceWords.Translations[practiceWords.ToLanguage]}\"");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("********************************");

                }
                guesses++;
            }
        }
        else if (args.Length == 1)
        {
            Console.WriteLine("Error: -practice must have a listname.");
        }
        else
        {
            Console.WriteLine("Error: -practice only takes one listname.");
        }
    }
    else if ("-add" == args[0])
    {
        if (args.Length == 2)
        {
            string listName = args[1];
            WordList wordList = WordList.LoadList(listName);
            if (wordList is null) PrintListDoesNotExistAndExit(listName);

            InputWords(wordList);
        }
        else if (args.Length == 1)
        {
            Console.WriteLine("Error: -add must have a listname.");
        }
        else
        {
            Console.WriteLine("Error: -add only takes one listname.");
        }
    }
    else if ("-new" == args[0])
    {
        if (args.Length >= 4)
        {
            string listName = args[1];
            string[] languages = new string[args.Length - 2];
            for (int i = 2; i < args.Length; i++)
            {
                languages[i - 2] = args[i];
            }

            WordList wordList = new WordList(listName, languages);
            InputWords(wordList);
        }
        else if (args.Length == 1)
        {
            Console.WriteLine("Error: -new must have a listname.");
        }
        else if (args.Length >= 2)
        {
            Console.WriteLine("Error: -new at least two languages.");
        }
    }
    else if ("-remove" == args[0])
    {
        if (args.Length >= 4)
        {
            string listName = args[1];
            string selectedLanguage = args[2];
            WordList wordList = WordList.LoadList(listName);
            if (wordList is null) PrintListDoesNotExistAndExit(listName);
            int selectedLanguageIndex = GetLanguageIndex(wordList.Languages, selectedLanguage);


            if (selectedLanguageIndex >= 0)
            {
                int wordCount = 0;
                for (int i = 3; i < args.Length; i++)
                {
                    bool removed = wordList.Remove(selectedLanguageIndex, args[i]);
                    if (removed)
                    {
                        wordCount++;
                    }
                }
                Console.WriteLine($"Removed {wordCount} words from \"{listName}\".");
                wordList.Save();
            }
        }
        else if (args.Length == 3)
        {
            Console.WriteLine("Error: Please select word to remove. ");
        }
        else if (args.Length == 2)
        {
            Console.WriteLine("Error: -remove takes language as second argument.");
        }
        else if (args.Length == 1)
        {
            Console.WriteLine("Error: -remove takes listname as first argument.");
        }
    }
    else if ("-words" == args[0])
    {
        if (args.Length == 2 || args.Length == 3)
        {
            string listName = args[1];
            int selectedLanguageIndex = 0;
            WordList wordList = WordList.LoadList(listName);
            if (wordList is null) PrintListDoesNotExistAndExit(listName);

            if (args.Length == 3)
            {
                string sortByLanguage = args[2];
                selectedLanguageIndex = GetLanguageIndex(wordList.Languages, sortByLanguage);
                if (selectedLanguageIndex == -1)
                {
                    Console.WriteLine($"Error: The language \"{sortByLanguage}\" does not exist in \"{listName}\"!");
                    return;
                }
            }
            foreach (var language in wordList.Languages)
            {
                Console.Write(language.PadRight(20).ToUpper());
            }
            Console.WriteLine();
            Console.WriteLine(new String('-', 20 * wordList.Languages.Count()));
            wordList.List(selectedLanguageIndex, PrintTranslations);
        }
    }
}
else
{
    Console.WriteLine("Use any of the following parameters: \r\n" +
        "-lists \r\n" +
        "-new <list name> <language 1> <language 2> .. <langauge n> \r\n" +
        "-add <list name> \r\n" +
        "-remove <list name> <language> <word 1> <word 2> .. <word n> \r\n" +
        "-words <listname> <sortByLanguage> \r\n" +
        "-count <listname> \r\n" +
        "-practice <listname> \r\n");
}


void PrintTranslations(string[] translations)
{
    foreach (var translation in translations)
    {
        Console.Write(translation.PadRight(20));
    }
    Console.WriteLine();
}

void InputWords(WordList wordlist)
{
    bool keepGoing = true;
    while (keepGoing)
    {
        var translations = new string[wordlist.Languages.Length];

        for (int i = 0; i < translations.Length; i++)
        {
            Console.WriteLine($"Please enter a word in: {wordlist.Languages[i]}");
            string input = Console.ReadLine();

            if (input == "")
            {
                keepGoing = false;
                break;
            }
            translations[i] = input;
        }
        if (keepGoing)
        {
            wordlist.Add(translations);
        }
    }
    wordlist.Save();
}

int GetLanguageIndex(string[] languages, string selectedLanguage)
{
    int selectedLanguageIndex = -1;
    for (int i = 0; i < languages.Count(); i++)
    {
        if (languages[i].ToLower() == selectedLanguage.ToLower())
        {
            selectedLanguageIndex = i;
        }

    }
    return selectedLanguageIndex;
}

void PrintListDoesNotExistAndExit(string listName)
{
    Console.WriteLine($"Error: There is no list named \"{listName}\".");
    Environment.Exit(0);
}



