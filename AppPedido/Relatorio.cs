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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            dgvCompras.DataSource = new ClasseCompras().ListarCompras();
        }
    }
}
