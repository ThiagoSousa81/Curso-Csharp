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
    public partial class frmCategoria : Form
    {
        RegraNegocio.ProdutosRegraNegocio novoProduto;

        public frmCategoria()
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
                novoProduto.SalvarCategoria(txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                novoProduto.AlterarCategoria(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarCategoria();
            Limpar();
        }

        private void ListarCategoria()
        {
            //Lista as categorias no DataGridView.
            novoProduto = new RegraNegocio.ProdutosRegraNegocio();
            dtgCategorias.DataSource = novoProduto.ListarCategorias();
            Estilo();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgCategorias.Rows.Count; i += 2)
            {
                dtgCategorias.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void dtgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Verifica se foi clicado na coluna btnEditar e carrega os campos com os dados da categoria 
             * ou se foi no botão excluir e apaga a categoria de acordo com o seu ID.*/
            try
            {
                if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgCategorias.Rows[e.RowIndex].Cells["ID_CATEGORIA_PRODUTOS"].Value.ToString();
                    txtNome.Text = dtgCategorias.Rows[e.RowIndex].Cells["NOME_CATEGORIA_PRODUTOS"].Value.ToString();
                    txtDescricao.Text = dtgCategorias.Rows[e.RowIndex].Cells["DESCRICAO_CATEGORIA_PRODUTOS"].Value.ToString();
                }
                else if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                    MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                    novoProduto.ExcluirCategoria(Convert.ToInt32(dtgCategorias.Rows[e.RowIndex].Cells["ID_CATEGORIA_PRODUTOS"].Value));
                    MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            ListarCategoria();
        }
    }
}
