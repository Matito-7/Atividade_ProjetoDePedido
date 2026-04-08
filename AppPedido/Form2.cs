using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPedido
{
    public partial class Form2 : Form
    {
        Conexao Conexao = new Conexao();
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbClientes.DataSource = new ClienteDAO().Listar();

            cbClientes.DisplayMember = "nome";
            cbClientes.ValueMember = "id_cliente";

            cbItens.DataSource = new ItemDAO().Listar();
            cbItens.DisplayMember = "nome_produto";
            cbItens.ValueMember = "id_item";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relatorio telaRelatorio = new Relatorio();
            telaRelatorio.ShowDialog();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            int idCliente = Convert.ToInt32(cbClientes.SelectedValue);
            int idItem = Convert.ToInt32(cbItens.SelectedValue);
            int quantidade = Convert.ToInt32(numQuantidade.Value);

            ClasseCompras compras = new ClasseCompras();
            compras.Inserir(idCliente, idItem, quantidade);

            MessageBox.Show("Compra salva com sucesso!");

        }
    }
}
