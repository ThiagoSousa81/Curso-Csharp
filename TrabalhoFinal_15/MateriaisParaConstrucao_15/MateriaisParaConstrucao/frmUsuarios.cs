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
    public partial class frmUsuarios : Form
    {
        RegraNegocio.UsuariosRegraNegocio novoUsuario;
        RegraNegocio.NiveisRegraNegocio novoNivel;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public void ListarNiveis() //Método que retorna os níveis dos usuários através do método Listar da classe NiveisRegraNegocio.
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();

                cboNivel.DataSource = novoNivel.Listar();
                cboNivel.DisplayMember = "NOME_NIVEL";
                cboNivel.ValueMember = "ID_NIVEL";

                cboNivel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarUsuarios() //Método que retorna os usuários através do método Listar da classe UsuarioRegraNegocio.
        {
            try
            {
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                dtgUsuarios.DataSource = novoUsuario.Listar();

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgUsuarios.Rows.Count; i += 2)
            {
                dtgUsuarios.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtSenha2.Clear();
            cboNivel.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            dtpDataCadastro.Value = DateTime.Today;
        }

        private void btnNiveis_Click(object sender, EventArgs e)
        {
            frmNiveis niveis = new frmNiveis(this);
            niveis.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "0")
                {
                    novoUsuario = new RegraNegocio.UsuariosRegraNegocio();

                    novoUsuario.Salvar(txtNome.Text, dtpDataCadastro.Value.Date, txtLogin.Text, Convert.ToInt32(cboNivel.SelectedValue), txtSenha.Text, txtSenha2.Text, cboStatus.Text);
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoUsuario.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, dtpDataCadastro.Value.Date, txtLogin.Text, Convert.ToInt32(cboNivel.SelectedValue), txtSenha.Text, txtSenha2.Text, cboStatus.Text);
                    MessageBox.Show("Usuário alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ListarUsuarios();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            ListarNiveis();
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e) //Evento do DataGrid que detecta o clique em suas células.
        {
            try
            {
                //Verifica se a coluna clicada foi referente ao btnEditar.
                if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Se a condição for verdadeira, carrega o conteúdo dos componentes do código, nome e login do formulário com as suas respectivas colunas do DataGrid.
                    txtCodigo.Text = dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value.ToString();
                    txtNome.Text = dtgUsuarios.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                    txtLogin.Text = dtgUsuarios.Rows[e.RowIndex].Cells["LOGIN"].Value.ToString();

                    //E, se a senha tiver no total de 32 caracteres,
                    if (dtgUsuarios.Rows[e.RowIndex].Cells["SENHA"].Value.ToString().Trim().Length == 32)
                    {
                        /*é criada uma nova variável que será responsável por armazenar o valor da senha capturada da célula Senha do DataGrid,
                         * e que capture apenas os oito primeiros caracteres e deixando os componentes que recebem a senha receberem esse conteúdo.*/
                        string novaSenha = dtgUsuarios.Rows[e.RowIndex].Cells["SENHA"].Value.ToString().Substring(0, 8);
                        txtSenha.Text = novaSenha;
                        txtSenha2.Text = novaSenha;
                    }
                    //Os valores dos ComboBoxes que recebem os níveis e as opções de status carregam os valores das suas respectivas células do DataGrid.
                    cboNivel.SelectedValue = dtgUsuarios.Rows[e.RowIndex].Cells["ID_NIVEL"].Value.ToString();
                    cboStatus.Text = dtgUsuarios.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();

                }
                //Caso o clique não foi no btnEditar, verifica se foi no btExcluir e se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
                else if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                         MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Se sim, realiza o método Excluir, mostra mensagem do sucesso dessa ação, lista os clientes no DataGrid e limpa todos os campos.
                    novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                    novoUsuario.Excluir(Convert.ToInt32(dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value));
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarUsuarios();
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
