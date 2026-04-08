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
    public partial class win : Form
    {
        public win()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ItemDAO itm = new ItemDAO();
            itm.InserirItem(txtNomeProduto.Text, Convert.ToInt32(txtPreco.Text));

            MessageBox.Show("Produto cadastrado!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 telaPedidos = new Form2();
            telaPedidos.Show();
            this.Hide();
        }
    }
}
