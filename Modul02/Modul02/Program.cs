using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul02
{
    class MainClass
    {
         public static void Main(string[] args)
        {

             //Дефинира на променливи
            int a = 0, b = 0;
            int sum = 0;

             //Събиране на числа
            a = 5;
            b = 10;

            sum = a + b;

             //писане на променливи
            Console.Write(a);
            Console.Write(" + ");
            Console.Write(b);
            Console.Write(" = ");
            Console.WriteLine(sum);

             //Допълнителни оператори
            Console.WriteLine("\nИзползване на  += ");
            a += b; //a = 10 + 5, a = a + b
             Console.WriteLine(a);

             Console.WriteLine("\nИзползване на  -= ");
             a -= b;
             Console.WriteLine(a);

             Console.WriteLine("\nИзползване на  *= ");
             a *= b; 
             Console.WriteLine(a);

             Console.WriteLine("\nИзползване на  ++ ");
             a ++ ;  
             Console.WriteLine(a);

             Console.WriteLine("Стандартно делене: " + (7 / 3).ToString()); //-> 2 ( 7 / 3 = 2,3333)
             Console.WriteLine("Остатък от делене: " + (7 % 3).ToString()); //-> 1 ( 1 / 3 = 0,3333)
        }
    }
}
