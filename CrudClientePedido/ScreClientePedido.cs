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
    public partial class ScreClientePedido : Form
    {

        List<ClientePedido> listaPedido = new List<ClientePedido>();


        public ScreClientePedido()
        {
            InitializeComponent();
        }

        private void ScreClientePedido_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        public void carregarGrid() {

            dgvClientePedido.DataSource = null;
            dgvClientePedido.DataSource = listaPedido;
        }
        public void inserirPedido() {

            ClientePedido cliePed = new ClientePedido();
            cliePed.idPedido = Convert.ToInt32(txtIdPedido.Text);
            cliePed.idCliente = Convert.ToInt32(txtIdCliente.Text);
            cliePed.idProduto = Convert.ToInt32(txtIdProduto.Text);
            cliePed.dtPedido = Convert.ToDateTime(txtDataPedido.Text);
            cliePed.qtd = Convert.ToInt32(txtQtd.Text);
            cliePed.preco = txtPreco.Text;

            listaPedido.Add(cliePed);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            inserirPedido();
            dgvClientePedido.DataSource = null;
            dgvClientePedido.DataSource = listaPedido; 
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<ClientePedido> listaPesquisarPedido = new List<ClientePedido>();
            listaPesquisarPedido = listaPedido;

            listaPesquisarPedido = listaPesquisarPedido.Where(i => i.idPedido.Equals(Convert.ToInt32(txtIdPedido.Text))).ToList();
            dgvClientePedido.DataSource = null;
            dgvClientePedido.DataSource = listaPesquisarPedido;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdPedido.Text = "";
            txtDataPedido.Text = "";
            txtIdCliente.Text = "";
            txtIdProduto.Text = "";
            txtPreco.Text = "";
            txtQtd.Text = "";

            dgvClientePedido.DataSource = null;
            dgvClientePedido.DataSource = listaPedido;
        }



    }
}
