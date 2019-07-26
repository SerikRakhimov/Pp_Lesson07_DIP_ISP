using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_DIP
{

    public interface IRunnable
        {
            void Run();
        }

    class Program
    {
        static IRunnable execute = null;

        static void Main(string[] args)
            {
                execute = new Before();
                execute.Run();
                execute = new After();
                execute.Run();
            }
        }

    }
