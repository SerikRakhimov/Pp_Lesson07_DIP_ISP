using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_DIP
{
    public class After : IRunnable
    {
        #region Principle start
        public interface DBConnectionInterface
        {
            string Connect();
        }

        public class MySQLConnection: DBConnectionInterface
        {

            public string Connect()
            {
                return "MySQLConnection";
            }
        }

        public class Data
        {
        private DBConnectionInterface _dbConnection;
 
            public void Construct(DBConnectionInterface dbConnection)
            {
                _dbConnection = dbConnection;
            }
        }

    #endregion

    public void Run()
        {
            Console.WriteLine("DIP After run:");
        }
    }
}
