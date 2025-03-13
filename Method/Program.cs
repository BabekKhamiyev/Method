namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, -1 };
            Console.WriteLine(hasil(ints));
        }

        //Verilmiş integer array-in  bütün elementlərini  string şəkildə qaytaran metod.
        //Misalçün parametr olaraq {1,-4,9,-8} dəyərləri olan array daxil edilsə arqument
        //kimi metod bizə "1 -4 9 -8" dəyərləri olan qaytarmalıdır.
        //Hemin methodu butun elementlerin cəmini geriyə qaytaran şəkildə,
        //içərisində mənfi dəyər olub-olmadığını geriyə qaytaran şəkildə və içərisinə n sayda parametr qəbul edib,
        //həmin parametrlərin hasilini geri qaytaran şəkildə yazırsınız (method overloading).

        static string UniversalMethod(int[] ints)
        {
            string str = "";
            for (int i = 0; i < ints.Length; i++)
            {
                str += ints[i] + " ";
            }
            return str;
        }

        static int sum (int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i] ;
            }
            return sum;
        }

        static bool Menfivar(int[] ints)
        {
            bool var= false;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < 0)
                {
                    var = true;
                }
            }
            return var;
        }

        static int hasil(int[] ints)
        {
            int hasil = 1;
            for (int i = 0; i < ints.Length; i++)
            {
                hasil *= ints[i];
            }
            return hasil;
        }








    }
}
