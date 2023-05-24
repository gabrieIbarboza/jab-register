using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JabRegister
{
    class cl_controluser
    {
        cl_dbconnection db = new cl_dbconnection();

        public string register(cl_user user)
        {
            try
            {
                string sqlQuery = ($"call SP_RegistraUser('{user.Nome}','{user.Cpf}','{user.Tel}','{user.Email}','{user.Genero}','{user.Endereco}','{user.Dtnasc}')");

                MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, db.con);

                db.connect();
                    sqlCommand.ExecuteNonQuery();
                db.disconnect();
                return ($"Cadastro de {user.Nome} realizado com sucesso!");
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return ($"Falha ao cadastrar usuário! " + e.ToString());
            }
        }
    }
}
