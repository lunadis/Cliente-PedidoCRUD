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
    public partial class screProduto : Form
    {

        List<Produto> listaProdutos = new List<Produto>();  

        public screProduto()
        {
            InitializeComponent();
        }

        private void screProduto_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        public void carregarGrid() {

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;

        }
        public void inserirProduto() {

            Produto prod = new Produto();
            prod.idProduto = Convert.ToInt32(txtIdProduto.Text);
            prod.nmProduto = txtNome.Text;
            prod.nmFabricante = txtFabricante.Text;
            prod.qtd = Convert.ToInt32(txtQtd.Text);
            prod.telefone = txtTelefone.Text;
            prod.validade = Convert.ToDateTime(txtValidade.Text);

            listaProdutos.Add(prod);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = null;
            inserirProduto();
            carregarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Produto> listaPesquisaProduto = new List<Produto>();
            listaPesquisaProduto = listaProdutos;

            listaPesquisaProduto = listaPesquisaProduto.Where(i => i.nmProduto.Contains(txtNome.Text)).ToList();

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaPesquisaProduto;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           
            txtNome.Text = "";
            txtFabricante.Text = "";
            txtIdProduto.Text = "";
            txtPreco.Text = "";
            txtQtd.Text = "";
            txtTelefone.Text = "";
            txtValidade.Text = "";

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;
        }
    }
}
