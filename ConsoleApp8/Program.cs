namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilən ədədə və ya ondan böyük ən yaxın ədədə qədər fibonaççi ardıcıllığını ekrana çap edin
            //int a = 0;
            //int b = 1;
            //int nums = 250;
            //int c = 0;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //while (c < nums)
            //{
            //    c = a + b;
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //}




            //2 dəyişənin dəyərlərini 3cü dəyişən istifadə etmədən dəyişin.
            int x = 6;
            int y = 7;

            Console.WriteLine("Qiymetler deyisdirilmeden once:");
            Console.WriteLine("x-in ilk qiymeti: " + x);
            Console.WriteLine("y-in ilk qiymeti: " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Qiymetler deyisdirildikden sonra");
            Console.WriteLine("x-in son qiymeti: " + x);
            Console.WriteLine("y-in son qiymeti: " + y);




        }
    }
}