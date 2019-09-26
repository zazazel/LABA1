using System;

namespace LAB_1._2
{
    class Program
    {
        public static void Main()
        {
            #region  Проверка числа на четность 
            Console.WriteLine("Введите число для проверки на четность");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(parity(A));
            #endregion
            Console.WriteLine("Введите числа M и N");
            int M = Convert.ToInt32(Console.ReadLine()), N = Convert.ToInt32(Console.ReadLine());
        }
        public static string parity(int A)
        {
            String Parity_A;
            if (A % 2 == 0)
            {
                Parity_A = "The number is even";
            }
            else
            {
                Parity_A = "The number is not even";
            }
            return Parity_A;
        

        }
        public static
        
           
    
    }
}