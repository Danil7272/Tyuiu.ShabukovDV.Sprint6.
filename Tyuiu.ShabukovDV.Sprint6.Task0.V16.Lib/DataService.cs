using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShabukovDV.Sprint6.Task0.V16.Lib
{
    public class DataService
    {
        public double Calculate(int x)
        {
            double res = (1 + Math.Pow(x, 3)) / Math.Pow(x, 2);
            return Math.Round(res, 3);
        }
    }
}
