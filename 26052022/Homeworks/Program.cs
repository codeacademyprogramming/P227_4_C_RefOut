using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adlarin sayini daxil edin:");
            string namesCountStr = Console.ReadLine();
            int namesCount = Convert.ToInt32(namesCountStr);

            string[] names = new string[namesCount];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i+1}. adi daxil et:");
                names[i] = Console.ReadLine();
            }

            int result = FindWordCount(names);
            Console.WriteLine($"result: {result}");


            int[] nums = { 34, 456, 23, 5678, 987, 890 };

            Console.WriteLine(FindNumberCount(nums,3));

            int[] newArr = MakeEvenArr(nums);

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }

            Console.WriteLine($"Pow: {Pow(5,8)}");

            int[] numbers = { 1, 2, 3 };

            var newNumbers = AddToArr(numbers, 4);

            foreach (var item in newNumbers)
            {
                Console.WriteLine(item);
            }
        }

        #region Task1
        //Verilmis adlar siyahisinda (string array) nece adin uzunlugunun
        //5-den boyuk oldugunu tapan method
        static int FindWordCount(string[] names)
        {
            int count = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5)
                    count++;
            }

            return count;
        }

        static int FindNumberCount(int[] numbers, int n)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (FindDigitCount(numbers[i]) > n)
                    count++;
            }

            return count;
        }

        static int FindDigitCount(int num)
        {
            int digitCount = 0;
            while (num != 0)
            {
                num = (num - num % 10) / 10;
                digitCount++;
            }

            return digitCount;
        }
        #endregion

        #region Task2
        // Verilmis ededler siyahisindaki cut ededlerden ibraret yeni
        // bir array qaytaran method

        static int[] MakeEvenArr(int[] numbers)
        {
            int newArrSize = FindEvenCount(numbers);

            int[] evenNumbers = new int[newArrSize];

            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[index] = numbers[i];
                    index++;
                }
            }

            return evenNumbers;
        }

        static int FindEvenCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    count++;
            }

            return count;
        }
        #endregion

        #region Task2
        //Verilmis n ededini verilmis m quvvetine yukselden metod

        static int Pow(int n,int m)
        {
            int result = 1;
            for (int i = 0;i < m; i++)
            {
                result *= n;
            }

            return result;
        }
        #endregion

        #region Task4
        //Verilmis ededler siyahisina verilmis n 
        //ededini elave edib qaytaran metod

        static int[] AddToArr(int[] arr,int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            return newArr;
        }
        #endregion

    }
}
