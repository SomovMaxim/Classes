using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasSomov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во отработанных дней: ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму оклада: ");
            double oklad = double.Parse(Console.ReadLine());
            Pay pay = new Pay(days,oklad);
            pay.Summa();
            pay.Print();
            Console.ReadKey();
        }
    }
}
