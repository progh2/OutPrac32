using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사용자 입력: ");
            int output;
            bool result = int.TryParse(
                Console.ReadLine(),
                out output);
            if (result)
            {
                Console.WriteLine("값: " + output);
            }
            else
            {
                Console.WriteLine("정수를 입력하세요!");
            }
        }
    }
}
