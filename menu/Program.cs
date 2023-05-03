using System;
namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, choice;
            Console.WriteLine("Введите числа А и В:");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 1, чтобы сложить, 2 - отнять, 3 - умножить  4 - разделить");

            switch (choice)
            {
                case '1':
                    int sum = A + B;
                    Console.WriteLine($"сумма:{sum}");
                    break;
                case '2':
                    
                    break;
                case '3':
                    
                    break;

                case '4':

                    break;
            }

        }
    }
}