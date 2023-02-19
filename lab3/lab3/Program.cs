using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    delegate void Del(object e);

    class date
    {
        static DateTime dt = new DateTime();
        public static void shownow(object e)
        {
            e = DateTime.Now;
            Console.WriteLine(e);
        }
        public static void showdate(object e)
        {
            e = DateTime.Today;
            Console.WriteLine(e);
        }
        public static void showdayweek(object e)
        {
            e = dt.DayOfWeek;
            Console.WriteLine(e);
        }
        public static void triangle(object e)
        {
            int a = 10, h = 5;
            e = (0, 5 * a * h);
            Console.WriteLine(e);
        }
        public static void rectangle(object e)
        {
            int a = 10, h = 5;
            e = (a * h);
            Console.WriteLine(e);
        }

        static void Main(string[] args)
        {

            Del d = new Del(shownow);
            d += showdate;
            d += showdayweek;
            d += triangle;
            d += rectangle;


        }


        delegate void MyDelegate(int[] arr);
        class array
        {
            public static void Even(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    { Console.Write("{0, 4}", arr[i]); }
                }
            }
            public static void Odd(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 3 == 0)
                    { Console.Write("{0, 4}", arr[i]); }
                }
            }
            public static void natural(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0 && arr[i] % 3 != 0)
                    { Console.Write("{0, 4}", arr[i]); }
                }
            }

            static void Main(string[] args)
            {
                int[] arr = new int[10];
                Random r = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(10);
                    Console.Write("{0, 4}", arr[i]);
                }
                Console.WriteLine();
                MyDelegate dg = new MyDelegate(Even);
                dg += Odd;
                dg += natural;
                //-------------------------

                Del d = new Del(shownow);
                d += showdate;
                d += showdayweek;
                d += triangle;
                d += rectangle;


            }
        }
    }
}
