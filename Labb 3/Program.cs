using Word_library;

Console.WriteLine(args.Length);
foreach (var item in args)
{
	Console.WriteLine(item);
}

WordList myWordList = new("Fruits", "English", "Swedish","Bosnian");
//WordList myWordList = WordList.LoadList("Test");

myWordList.Add("Apple", "Äpple", "Jabuka");
myWordList.Add("Banana", "Banan", "Banana");
myWordList.Add("Pear", "Päron", "Kruska");
myWordList.Add("Peach", "Persika", "Breskva");
myWordList.Add("Mango", "Mango", "Mango");
myWordList.Save();


myWordList.List(1, x => Console.WriteLine($"{x[0]} {x[1]} {x[2]}"));
Word training = myWordList.GetWordToPractice();
Console.WriteLine();
Console.WriteLine(String.Join (' ', training.Translations));
//Console.WriteLine($"Antal ord i listan: {myWordList.Count()}");
//Console.WriteLine(myWordList.Remove(0, "Apple"));


	//foreach (string name in WordList.Getlists())
//{
//	Console.WriteLine(name);
//}

//Console.WriteLine($"Antal ord i listan: {myWordList.Count()}");
