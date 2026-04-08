using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedido
{
    internal class ClienteDAO
    {
        public void Inserir(string nome, string cpf)
        {

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conection();

            con.Open();

            string sql = "INSERT INTO Clientes (nome,cpf) values (@nome, @cpf)";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);

            cmd.ExecuteNonQuery();
        }

        public DataTable Listar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conection();

            string sql = "SELECT * FROM Clientes";
            MySqlDataAdapter cmd = new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();
            cmd.Fill(dt);

            return dt;
        }
        

    }
}
