using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedido
{
    internal class ItemDAO
    {
        public void InserirItem(string nome, int preco)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conection();

            con.Open();
            string sql ="INSERT INTO Itens (nome_produto, preco_unitario) " +
                         "VALUES (@nome, @preco)";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco);

            cmd.ExecuteNonQuery();
        }


        public DataTable Listar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conection();

            string sql = "SELECT * FROM Itens";
            MySqlDataAdapter cmd = new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();
            cmd.Fill(dt);

            return dt;
        }
    }
}
