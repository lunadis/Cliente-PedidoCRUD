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
    public partial class screCliente : Form
    {
        public screCliente()
        {
            InitializeComponent();
        }

        List<Cliente> listaCliente = new List<Cliente>();
        

        private void screCliente_Load(object sender, EventArgs e)
        {
            //inserirCliente();
            carregarGrid();
        }

        public void carregarGrid() {

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaCliente;
        
        }

        public void inserirCliente() {


            Cliente cli = new Cliente();
            cli.codigoCliente = Convert.ToInt32(txtIdClie.Text);
            cli.nmCliente = txtNome.Text;
            cli.dtNascimento = Convert.ToDateTime(txtDataNasc.Text);
            cli.nrTelefone = txtNmTelefone.Text;
            cli.dsEndereco = txtdsEndereco.Text;

                  

            listaCliente.Add(cli);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            inserirCliente();
            carregarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaPesquisa = new List<Cliente>();
            listaPesquisa = listaCliente;

            listaPesquisa = listaPesquisa.Where(i => i.nmCliente.Contains(txtNome.Text) || i.codigoCliente.Equals(Convert.ToInt32(txtIdClie.Text))).ToList();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaPesquisa;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNome.Text = "";
            txtNmTelefone.Text = "";
            txtIdClie.Text = "";
            txtdsEndereco.Text = "";
            txtDataNasc.Text = "";
            
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaCliente;
        }



    }
}
