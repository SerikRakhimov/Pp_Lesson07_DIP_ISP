using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_DIP
{
    public class Before : IRunnable
    {
        #region Principle start
        public class MySQLConnection
        {
            public string Connect()
            {
                return "MySQLConnection";
            }
        }

        public class Data
        {
            private MySQLConnection _dbConnection;
 
            public void Construct(MySQLConnection dbConnection)
            {
                _dbConnection = dbConnection;
            }
        }
        #endregion

        public void Run()
        {
            Console.WriteLine("DIP Before run:");
        }
    }
}
