using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPedido
{
    public class Conexao
    {
        private static string conex = "server=localhost; " +
            "database=loja_tecnologia; user=root; password=;";
        
        public MySqlConnection Conection()
        {
            return new MySqlConnection(conex);
        }
    }
}
