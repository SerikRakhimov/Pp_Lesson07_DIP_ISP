using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pp_ISP
{
    public class After : IRunnable
    {
        #region Principle start

        public interface FigureInterfaceArea
        {
            double CalcArea();
        }

        public interface FigureInterfaceVolume
        {
            double CalcVolume();
        }

        public class Rectangle : FigureInterfaceArea // прямоугольник
        {
            public double CalcArea()
            {
                return 100;
            }

        }

        public class Cube : FigureInterfaceArea, FigureInterfaceVolume  // куб
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
            Console.WriteLine("ISP After run:");
        }
    }
}
