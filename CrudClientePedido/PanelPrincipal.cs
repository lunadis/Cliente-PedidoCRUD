using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace CrudClientePedido
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
           /* Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();*/
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            screCliente screClie = new screCliente();
            screClie.MdiParent = this;
            screClie.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            screProduto screProd = new screProduto();
            screProd.MdiParent = this;
            screProd.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScreClientePedido screCliPed = new ScreClientePedido();
            screCliPed.MdiParent = this;
            screCliPed.Show();
        }
    }
}
