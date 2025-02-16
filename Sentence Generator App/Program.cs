class SentenceGeneratorLogic
{
    static void Main(string[] args)
    {
        string[] names = { "Maria", "Hawk", "Jessie", "Nick", "Rebecca", "Anna", "Henry", "Robby", "Jack", "Jake", "Milena"};
        string[] locations = { "Sofia", "London", "New York", "Hamburg", "Seoul", "Tokyo", "Moskow" };
        string[] verbs = { "eats", "sees", "talks with", "chases", "plays with" };
        string[] nouns = { "stones", "apples", "cats", "smartphones", "statues", "friends" };
        string[] adverbs = { "studiously", "rapidly", "slowly", "passionately", "happily", "sadly" };
        string[] details = { "near a river", "at home", "at the cafeteria", "in the park", "on the top of a building", "on Mount Everest" };
        Console.WriteLine("Welcome to the random sentence generator!\nHere is a random sentence for you:");
        while (true)
        {
            Console.WriteLine($"{GetRandomWord(names)} from {GetRandomWord(locations)} {GetRandomWord(adverbs)}" +
                              $" {GetRandomWord(verbs)} {GetRandomWord(nouns)} {GetRandomWord(details)}.");
            Console.WriteLine("Click [Enter] to generate a new sentence.");
            Console.ReadLine();
        }
    }
    static string GetRandomWord(string[] words)
    {
        Random rnd = new Random();
        return words[rnd.Next(words.Length)];
    }
}