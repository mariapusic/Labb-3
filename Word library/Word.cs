using System.Diagnostics;

namespace Word_library
{
    [DebuggerDisplay("{Translations[0]}")]
    public class Word
    {

        public string[] Translations { get; }
        public int FromLanguage { get; }


        public int ToLanguage { get; }


        public Word(params string[] translations)
        {
            this.Translations = translations;
        }
        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            this.Translations = translations;
            this.FromLanguage = fromLanguage;
            this.ToLanguage = toLanguage;
        }

    }

}