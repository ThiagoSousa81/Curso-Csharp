using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmPrincipal : Form
    {
        RegraNegocio.UsuariosRegraNegocio novoUsuario;

        string nomeUsuario, nivelUsuario;
        int idUsuario;

        public frmPrincipal(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //Evento Click do btnFuncionarios em que o formulário frmFuncionarios é instanciado e exibido.
            frmFuncionarios formFuncionarios = new frmFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Evento Click do btnClientes em que o formulário frmClientes é instanciado e exibido.
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            //Evento Click do btnProdutos em que o formulário frmProdutos é instanciado e exibido.
            frmProdutos formProdutos = new frmProdutos();
            formProdutos.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        public void CarregaDadosUsuario() //Carrega os dados do usuário logado nos labels dos componentes StatusStrip. 
        {
            try
            {
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarUsuario(idUsuario);

                nomeUsuario = dadosTabela.Rows[0]["NOME_USUARIO"].ToString();
                nivelUsuario = dadosTabela.Rows[0]["NOME_NIVEL"].ToString();

                lblUsuario.Text = "Usuário: " + nomeUsuario;
                lblNivel.Text = "Nível: " + nivelUsuario;
                lblData.Text = DateTime.Today.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDadosUsuario();
            VerificaNivelUsuario();
        }

        private void VerificaNivelUsuario()
        {
            switch (nivelUsuario)
            {
                case "Administrador":
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorios.Enabled = true;
                    break;

                case "Gerente":
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = true;
                    btnUsuarios.Enabled = false;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorios.Enabled = true;
                    break;

                case "Vendedor":
                    btnClientes.Enabled = false;
                    btnProdutos.Enabled = false;
                    btnFuncionarios.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorios.Enabled = false;
                    break;

                case "Conferente":
                    btnClientes.Enabled = false;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnOrcamentos.Enabled = false;
                    btnVendas.Enabled = false;
                    btnRelatorios.Enabled = false;
                    break;

                default:
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorios.Enabled = true;
                    break;
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas(idUsuario, lblUsuario.Text);
            vendas.ShowDialog();
        }
    }
}
