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
    public partial class frmUnidades : Form
    {
        RegraNegocio.ProdutosRegraNegocio novoProduto;

        public frmUnidades()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Botão que realizará a limpeza dos campos do formulário.
            Limpar();
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Botão que realizará o método salvar caso o código seja 0, caso contrário, irá alterar os dados.
            novoProduto = new RegraNegocio.ProdutosRegraNegocio();

            if (txtCodigo.Text == "0")
            {
                novoProduto.SalvarUnidade(txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Unidade salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                novoProduto.AlterarUnidade(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Unidade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarUnidade();
            Limpar();
        }

        private void ListarUnidade()
        {
            //Lista as unidades no DataGridView.
            novoProduto = new RegraNegocio.ProdutosRegraNegocio();
            dtgUnidades.DataSource = novoProduto.ListarUnidades();
            Estilo();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgUnidades.Rows.Count; i += 2)
            {
                dtgUnidades.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void dtgUnidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Verifica se foi clicado na coluna btnEditar e carrega os campos com os dados da unidade 
             * ou se foi no botão excluir e apaga a unidade de acordo com o seu ID.*/
            try
            {
                if (dtgUnidades.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgUnidades.Rows[e.RowIndex].Cells["ID_UNIDADE_PRODUTOS"].Value.ToString();
                    txtNome.Text = dtgUnidades.Rows[e.RowIndex].Cells["NOME_UNIDADE_PRODUTOS"].Value.ToString();
                    txtDescricao.Text = dtgUnidades.Rows[e.RowIndex].Cells["DESCRICAO_UNIDADE_PRODUTOS"].Value.ToString();
                }
                else if (dtgUnidades.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                    MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                    novoProduto.ExcluirUnidade(Convert.ToInt32(dtgUnidades.Rows[e.RowIndex].Cells["ID_UNIDADE_PRODUTOS"].Value));
                    MessageBox.Show("Unidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarUnidade();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUnidades_Load(object sender, EventArgs e)
        {
            ListarUnidade();
        }
    }
}
