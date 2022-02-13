namespace Day02Task02
{
    internal class Day02Task02
    {
        public static void Main() 
        {
            Console.WriteLine("Enter String:");

            string userInput = Console.ReadLine();

            string[] tempSplit = userInput.Split(' ');

            Array.Reverse(tempSplit);

            Console.WriteLine("Resault after reverse is:");

            for (int i = 0; i <= tempSplit.Length - 1; i++)

            {
                Console.Write(tempSplit[i] + ' ');
            }
        }
    }
}
