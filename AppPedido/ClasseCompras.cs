using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedido
{
    internal class ClasseCompras
    {
        public void Inserir(int cliente, int item, int quantidade)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conection();

            con.Open();


            string sql = @"INSERT INTO Compras 
                          (id_cliente, id_item, quantidade)
                          VALUES (@cliente, @item, @qtd)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cliente", cliente);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@qtd", quantidade);

            
            cmd.ExecuteNonQuery();

        }


        public DataTable ListarCompras()
        {

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conection();

            string sql = @"
        SELECT 
            Clientes.nome,
            Clientes.cpf,
            Itens.nome_produto,
            Compras.quantidade
        FROM Compras
        INNER JOIN Clientes ON Compras.id_cliente = Clientes.id_cliente
        INNER JOIN Itens ON Compras.id_item = Itens.id_item
    ";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
    }

    }

