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

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value.ToString();
                    txtNome.Text = dtgUsuarios.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                    txtLogin.Text = dtgUsuarios.Rows[e.RowIndex].Cells["LOGIN"].Value.ToString();

                    if (dtgUsuarios.Rows[e.RowIndex].Cells["SENHA"].Value.ToString().Trim().Length == 32)
                    {
                        string novaSenha = dtgUsuarios.Rows[e.RowIndex].Cells["SENHA"].Value.ToString().Substring(0, 8);
                        txtSenha.Text = novaSenha;
                        txtSenha2.Text = novaSenha;
                    }
                    cboNivel.SelectedValue = dtgUsuarios.Rows[e.RowIndex].Cells["ID_NIVEL"].Value.ToString();
                    cboStatus.Text = dtgUsuarios.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();

                }
                else if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                         MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
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
