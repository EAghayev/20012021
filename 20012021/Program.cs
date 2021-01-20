using System;

namespace _20012021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;

            #region if-else
            //if (a > 0)
            //{
            //    Console.WriteLine("eded musbetdir");
            //}
            //else if (a < 0)
            //{
            //    Console.WriteLine("eded menfidir");
            //}
            //else
            //{
            //    Console.WriteLine("Eded 0-dir");
            //}
            #endregion

            #region switchcase
            //switch (a)
            //{
            //    case 0:
            //        Console.WriteLine("Eded 0-dir");
            //        break;
            //    case 1:
            //        Console.WriteLine("Eded 1-dir");
            //        break;
            //    default:
            //        Console.WriteLine("Eded 1 ve 0 deyil");
            //        break;
            //}
            #endregion

            #region loops
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int num1 = 5;
            //while (num1 > 0)
            //{
            //    Console.WriteLine(num1);
            //    num1--;
            //}

            //int[] numbers = new int[] { 5, 10, 4 };


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Arraydaki tek ededlerin cemi
            //int[] numbers = new int[] { 10, 56, 17, 45, 10, 56, 104, 356 };

            //int sum = 0;

            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 1)
            //    {
            //        //sum = sum+num
            //        sum += num;
            //    }
            //}

            //Console.WriteLine($"Siyahidaki tek ededlerin cemi: {sum}");
            #endregion

            #region String arrayinde ucunlugu 5-den boyuk ad olub olmadigini tapan program
            //string[] names = new string[] { "Hikmet", "Abbas", "Abdulla", "Cefer" };


            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i].Length > 5)
            //    {
            //        Console.WriteLine(true);
            //        break;
            //        //return;
            //    }
            //}
            #endregion

            #region Verilmis string arrayinda evveli A ile baslayan adlari console yazdiran program
            //string[] names = new string[] { "Hikmet", "Abbas", "Abdulla", "Cefer" };

            //foreach (string name in names)
            //{
            //    if (name[0] == 'A')
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            #endregion
        }
    }
}
