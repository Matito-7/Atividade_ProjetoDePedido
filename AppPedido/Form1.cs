namespace AppPedido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteDAO clt = new ClienteDAO();
            clt.Inserir(txtNome.Text, txtCpf.Text);

            MessageBox.Show("Cliente cadastrado!");

            dgvClientes.DataSource = clt.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            win telaItens = new win();
            telaItens.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 telaPedidos = new Form2();
            telaPedidos.Show();
            this.Hide();
        }
    }
}
