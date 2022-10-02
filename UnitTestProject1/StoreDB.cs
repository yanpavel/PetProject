using LinqToDB;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JollyHeisenberg
{
    public class StoreDataBase : LinqToDB.Data.DataConnection
    {

        public StoreDataBase() : base("begetdatabase")
        { }
        
        //public ITable<PayData> Pays { get { return GetTable<PayData>(); } }

       

        /*private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=193.168.48.193;Port=5432;Database=itcourse_db;User Id=itcourse_user;Password=root");
        }

        private static void SelectPayInfo()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query=@"select*from buys where pay_info_id=(select id from pay_info where card_number=)"
            }
        }*/


       
    }
}
