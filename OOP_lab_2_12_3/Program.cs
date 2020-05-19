using System;

namespace OOP_lab_2_12_3
{
    class Program
    {
        public static int Multiplication(int[] array)
        {
            int d = 1;

            bool b = false;

            foreach (int a in array)
            {
                if (a < 0)
                {
                    b = true;

                    d *= a;
                }
            }

            if (!b)
            {
                return 0;
            }

            return d;
        }

        public static int IndexMin(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[index] >= array[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = IndexMin(array) + 1; i < array.Length; ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            var random = new Random();

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("Добуток вiд’ємних елементiв масиву: {0}", Multiplication(array));
            Console.WriteLine("Cумa елементiв масиву, розташованих пiсля мiнiмального елемента: {0}", Sum(array));
        }
    }
}
