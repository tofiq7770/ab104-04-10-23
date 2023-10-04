using System;

namespace Ab104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(SumNums()));
            //Task 1
            //int[] nums = { 2, 3, 4, 5, 1, 6, -1, 7 };

            //Console.WriteLine(Min(nums));


            //static int Min(int[] nums)
            //{

            //    int min = nums[0];

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] < min)
            //        {
            //            min = nums[i];
            //        }


            //    }
            //    return min;
            //}

            //Console.WriteLine(Area(7));
            //Console.WriteLine(Area(7,3));
            //Console.WriteLine(Area(7,3,4));
            //Console.WriteLine(Area(7,3,4,8));
        }

        //Task 2
        //public static int Area(int radius)
        //{
        //    int p = 3;
        //    int s = radius * radius * p;
        //    return s;
        //}

        //public static int Area(int a, int b)
        //{
        //    int s = a * b;
        //    return s;
        //}
        //public static int Area(int a, int b, int c)
        //{
        //    int s = 2 * ((a * b) + (a * c) + (b * c));
        //    return s;
        //}
        //public static int Area(int a, int b, int c, int radius)
        //{
        //    int s = ((a + b + c) / 2) * radius;
        //    return s;
        //}


        //Task 3
        static int Nums(int a)
        {
            SumNums();
            return a;
        }

        static int SumNums()
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0) 
            {
                return Nums(a);
            }
            else
            {
                return a;
            }
        }

        static int GetSum(int a)
        {
            int sum = 0;
            int m = 0;
            while (a > 0)
            {
                m = a % 10;
                sum = sum + m;
                a /= 10;
            }
                return sum;
        }
    }
}
