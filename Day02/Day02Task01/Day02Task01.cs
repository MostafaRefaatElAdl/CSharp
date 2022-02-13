namespace Day02Task01
{
    internal class Day02Task01
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter Size Of Array");
            int ArrSize = int.Parse(Console.ReadLine());
            int[] myArr = new int[ArrSize];
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write($"enter elemnts value number {i+1} : ");
                myArr[i] = int.Parse(Console.ReadLine());
            }
            //int[] myArr = { 1, 2, 9, 4, 5, 8, 9, 9 };

            int max = 0;
            int indexJ = 0;
            int indexI = 0;
            for (int i = 0; i < myArr.Length; i++)
            {

                for (int j = i + 1; j < myArr.Length; j++)
                {
                    //if found two equal numbers
                    if (myArr[i] == myArr[j])
                    {
                        //assign these number indeses to vars
                        indexJ = j;
                        indexI = i;
                    }

                    //1st distance is the highest untill comes higher distance to overwirte it
                    if (indexJ - indexI > max)
                    {
                        max = indexJ - indexI;
                    }
                }
            }
            Console.WriteLine($"longest distance between two equal cells is : { max - 1}");

        }
    }
}
