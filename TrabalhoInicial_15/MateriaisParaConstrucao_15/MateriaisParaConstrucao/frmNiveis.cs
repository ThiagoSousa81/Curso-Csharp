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
    public partial class frmNiveis : Form
    {
        RegraNegocio.NiveisRegraNegocio novoNivel;
        frmUsuarios formularioUsuarios;

        public frmNiveis(frmUsuarios usuarios)
        {
            InitializeComponent();
            formularioUsuarios = usuarios;
        }

        private void ListarNiveis()
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();

                dtgNiveis.DataSource = novoNivel.Listar();
                Estilo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgNiveis.Rows.Count; i += 2)
            {
                dtgNiveis.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();

                if (txtCodigo.Text == "0")
                {
                    novoNivel.Salvar(txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoNivel.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ListarNiveis();
                Limpar();

                formularioUsuarios.ListarNiveis();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgNiveis.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgNiveis.Rows[e.RowIndex].Cells["ID_NIVEL"].Value.ToString();
                    txtNome.Text = dtgNiveis.Rows[e.RowIndex].Cells["NOME_NIVEL"].Value.ToString();
                    txtDescricao.Text = dtgNiveis.Rows[e.RowIndex].Cells["DESCRICAO_NIVEL"].Value.ToString();

                }
                else if (dtgNiveis.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                         MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoNivel = new RegraNegocio.NiveisRegraNegocio();
                    novoNivel.Excluir(Convert.ToInt32(dtgNiveis.Rows[e.RowIndex].Cells["ID_NIVEL"].Value));
                    MessageBox.Show("Categoria excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarNiveis();
                    formularioUsuarios.ListarNiveis();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNiveis_Load(object sender, EventArgs e)
        {
            ListarNiveis();
        }
    }
}
