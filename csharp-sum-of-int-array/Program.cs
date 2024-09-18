namespace SumOfIntArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            CalcSumArray(array);

            Console.WriteLine($"The sum of the array is {CalcSumArrayWithReturn(array)} with a function that return a value.");

            int sum = 0;
            CalcSumArrayByRef(array, ref sum);
            Console.WriteLine($"The sum of the array is {sum} by ref");
        }

        static void CalcSumArray(int[] pArray)
        {
            int sum = 0;
            for(int i = 0; i <= pArray.Length - 1; i++)
            {
                sum = sum + pArray[i];
            }

            Console.WriteLine($"The sum of the array is {sum}");
        }

        static int CalcSumArrayWithReturn(int[] pArray)
        {
            int sum = 0;
            for (int i = 0; i <= pArray.Length - 1; i++)
            {
                sum = sum + pArray[i];
            }

            return sum;
        }

        static void CalcSumArrayByRef(int[] pArray, ref int pSum)
        {
            for (int i = 0; i <= pArray.Length - 1; i++)
            {
                pSum = pSum + pArray[i];
            }
        }
    }
}