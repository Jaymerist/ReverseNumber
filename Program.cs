namespace AgeForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string number;
            int  length;

            //input number/string
            Console.Write("Enter a number: ");
            number = Console.ReadLine();
            length = number.Length;
            //loop
            // - get length of the string
            // - start at the end of the string and change the index to the beginning (0) in a for loop

            for (int start = length - 1; start >= 0; start--)
            {
                Console.WriteLine(number.Substring(start, 1));
            }  

            Console.ReadLine();
        }
    }
}
