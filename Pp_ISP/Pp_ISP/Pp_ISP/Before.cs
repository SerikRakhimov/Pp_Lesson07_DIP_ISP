using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pp_ISP
{
    public class Before : IRunnable
    {
        #region Principle start
        public interface FigureInterface
        {
            double CalcArea();     // вычислить площадь
            double CalcVolume();   // вычислить объем
        }
        public class Rectangle : FigureInterface  // прямоугольник
        {
            public double CalcArea()
            {
                return 100;
            }

            public double CalcVolume()
            {
                // вычислять объем у прямоугольника смысла не имеет
                throw new NotImplementedException();
            }
        }

        public class Cube : FigureInterface  // куб
        {
            public double CalcArea()
            {
                return 100;
            }

            public double CalcVolume()
            {
                return 1500;
            }
        }
        #endregion

        public void Run()
        {
            Console.WriteLine("ISP Before run:");
        }
    }
}
