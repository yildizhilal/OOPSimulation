using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class MortgageManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage kredisi hesaplandı.");
        }
    }
}
