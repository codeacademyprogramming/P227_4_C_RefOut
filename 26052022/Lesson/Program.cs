using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 45;

            Console.WriteLine(number);

            int age = number;

            string word = "Hello";

            int[] numbers = { 1, 2, 3 };
            numbers[0] = 6;


            SetZero(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            int n = 50;
            n = 55;
            n = 60;

            SetZero(n);
            Console.WriteLine(n);

            string name = "Abbas";
            Console.WriteLine(name);

            name = "Abdulla";

            char[] letters = { 'a', 'b', 'c' };

            string letterWord = "";

            foreach (var item in letters)
            {
                letterWord += item;
            }
            Console.WriteLine(letterWord);

            string str = "Abbas";
            SetZero(ref str);
            Console.WriteLine(str);

            int num1 = 45;

            AddInt(ref num1, 10);

            Console.WriteLine(num1);

            word = "Hello";
            AddChars(ref word, new char[] { ',', 'W', 'o','r','l','d' }); ;
            Console.WriteLine(word);

            int[] numbers2 = {1, 2, 3 };

            AddToInt(ref numbers2, 10);

            Console.WriteLine("Numbers");
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ededi daxil edin");
            string numberStr = Console.ReadLine();
            int num2;
            ConvertType(out num2, numberStr);
            Console.WriteLine(num2);

        }

        static void SetZero(int[] nums)
        {
            nums[0] = 0;
        }

        static void SetZero(int num)
        {
            num = 0;
        }

        static void SetZero(ref string str)
        {
            str = str + '0';
        }

        static void AddInt(ref int num,int value)
        {
            num =num+ value;
        }

        static void AddChars(ref string str,char[] letter)
        {
            for (int i = 0; i < letter.Length; i++)
            {
                str += letter[i];
            }
        }

        static void AddToInt(ref int[] arr, int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = value;

            arr = newArr;
        }

        static void ConvertType(out int num,string numStr)
        {
            num = Convert.ToInt32(numStr);
        }

    }
}
