using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number=Convert.ToInt32(Console.ReadLine());

            int result = CheckArmstrong(number);
            if(result==number)
                Console.WriteLine($"{number} is an Armstrong Number");
            else 
                Console.WriteLine($"{number} is not an Armstrong Number");
        }
        public static int CheckArmstrong(int number)
        {
            int sum = 0;
            while (number>0)
            {
                int remainder=number%10;
                sum += (remainder*remainder*remainder);
                number = number/10;
            }

            return sum;
        }
    }
}
