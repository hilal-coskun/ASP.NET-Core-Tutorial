using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted");
            }
        }

        class SqlServer : Database
        {
            public override void Add()
            {

                //base.Add();
            }
        }

        class MySql : Database
        {

        }
    }
}
