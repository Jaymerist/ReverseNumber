namespace CharacterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string phrase,
                character;
            int length,
                characterCount = 0;

            //input phrase
            Console.Write("Input a string (it can be anything): ");
            phrase = Console.ReadLine();
            Console.Write("Input a character you'd like to count within the string: ");
            character = Console.ReadLine();
            length = phrase.Length;
            //loop
            //- get length of string
            //- Go through letters and add to characterCount if substring = character
            for(int start = length - 1; start >= 0; start--)
            {
                if (phrase.Substring(start, 1) == character)
                {
                    characterCount++;
                }
            }

            Console.WriteLine($"Character count: {characterCount}");
            Console.ReadLine();
               
        }
    }
}
