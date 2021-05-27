using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasSomov
{
    class Pay
    {
        int Day { get; set; }
        double Oklad { get; set; }
        double result;
        public Pay(int days, double sumoOklad)
        {
            Day = days;
            Oklad = sumoOklad;
        }
        public void Summa()
        {
            result = Oklad / 22 * Day;
        }
        public void Print()
        {
            Console.WriteLine($"Зп = {Math.Round(result,3)}");
        }

    }
}
