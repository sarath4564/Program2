using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MethodParateterTypes2
{
    class Program
    {
        static void Main()
        {
            int Sum = 0;
            int Product = 0;
            Claculate(50, 30, out Sum, out Product);
            Console.WriteLine("Sum is:{0} and Product is:{1}",Sum,Product);
        }
        static void Claculate(int FN,int SN,out int Sum,out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
    }
}
Output:
Sum is:80 and Product is:1500
Press any key to continue . . .


