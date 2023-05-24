using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JabRegister
{
    class cl_dbconnection
    {
        public MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=dbJabRegister;User=root;Pwd=@Mudar123");

        public string connect()
        {
            try
            {
                con.Open();
                return ("Successfully Connected!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string disconnect()
        {
            try
            {
                con.Close();
                return ("Successfully Disconnected!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
