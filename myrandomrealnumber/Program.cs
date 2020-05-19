using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum = random.Next(1000);
            Console.WriteLine(randomNum);
            while (true)
            {
                Console.Write("숫자를 입력해주세요 : ");
                Double num = Double.Parse(Console.ReadLine());
                if (num > randomNum)
                {
                    Console.WriteLine(num + "보다는 작은 숫자 입니다.");
                }
                else if (num < randomNum)
                {
                    Console.WriteLine(num + "보다는 큰 숫자 입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}
