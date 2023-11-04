using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmLogin : Form
    {
        RegraNegocio.Criptografia criptografia;
        RegraNegocio.UsuariosRegraNegocio novoUsuario;
        public int idUsuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Realiza o cancelamento da aplicação, fechando-a.
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                criptografia = new RegraNegocio.Criptografia();
                string senhaCripto = criptografia.Criptografar(txtSenha.Text);

                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.Login(txtUsuario.Text, senhaCripto);  //verifica se o nome do usuário e senha informados foram encontrados no banco

                if (dadosTabela.Rows.Count == 0) //Se não retornou nenhum registro com o nome de usuário e senha informados, envia uma mensagem de alerta.
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dadosTabela.Rows[0]["STATUS_USUARIO"].ToString() == "Inativo") //Também verifica se o status do usuário está inativo. Se for verdade, envia uma mensagem de aviso,
                    {
                        MessageBox.Show("Conta de usuário inativa.\nContate o administrador do sistema!", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else //senão aparecerá uma mensagem de boas-vindas e realizará a abertura da aplicação. A seguir, fecha essa janela de login.
                    {
                        MessageBox.Show("Olá, " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString() + ".\nBem-vindo ao sistema!", "Bem-vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["ID_USUARIO"]);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
