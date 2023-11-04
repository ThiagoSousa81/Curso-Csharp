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
    public partial class frmProdutos : Form
    {
        RegraNegocio.ProdutosRegraNegocio novoProduto;

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            //Evento Click do btnCategoria em que o formulário frmCategoria é instanciado e exibido.
            frmCategoria formCategoria = new frmCategoria();
            formCategoria.ShowDialog();
        }

        private void btnUnidade_Click(object sender, EventArgs e)
        {
            //Evento Click do btnUnidade em que o formulário frmUnidades é instanciado e exibido.
            frmUnidades formUnidades = new frmUnidades();
            formUnidades.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Botão responsável por limpar os componentes do formulário.
            Limpar();
        }

        private void Limpar()
        {
            dtpData.Value = DateTime.Today;
            txtCodigoBarras.Clear();
            txtNome.Text = "";
            txtCodigo.Text = "0";
            cboCategoria.SelectedIndex = -1;
            txtDescricao.Clear();
            txtEstoqueAtual.Text = "";
            txtEstoqueMinimo.Text = "";
            cboUnidadeProduto.SelectedIndex = -1;
            txtCusto.Text = "";
            txtMargemLucro.Text = "";
            txtVenda.Text = "";
            txtAnotacoes.Text = "";
            txtEstoqueAtual.Text = "0";
            txtEstoqueMinimo.Text = "0";
            txtCusto.Text = "0";
            txtMargemLucro.Text = "0";
            txtVenda.Text = "0";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento do botão Salvar o qual grava as informações através dos métodos Salvar ou Alterar, criados na classe Produtos.
            try
            {
                if (txtCodigo.Text == "0")
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                    //novoProduto.Salvar(txtCodigoBarras.Text, txtNome.Text, txtDescricao.Text, Convert.ToInt32(cboUnidadeProduto.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtEstoqueMinimo.Text));

                    novoProduto.Salvar(txtCodigoBarras.Text, txtNome.Text, txtDescricao.Text, Convert.ToInt32(cboUnidadeProduto.SelectedValue),
                        Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtEstoqueMinimo.Text), Convert.ToInt32(txtEstoqueAtual.Text),
                        txtCusto.Text, txtVenda.Text, txtMargemLucro.Text,
                        txtAnotacoes.Text, Convert.ToBoolean(cbAtivo.Checked), dtpData.Value.Date);
                    

                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();

                    novoProduto.Alterar(Convert.ToInt32(txtCodigo.Text), txtCodigoBarras.Text, txtNome.Text, txtDescricao.Text,
                        Convert.ToInt32(cboUnidadeProduto.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtEstoqueMinimo.Text),
                        Convert.ToInt32(txtEstoqueAtual.Text), txtCusto.Text, txtVenda.Text,
                        txtMargemLucro.Text, txtAnotacoes.Text, Convert.ToBoolean(cbAtivo.Checked), dtpData.Value.Date);

                    MessageBox.Show("Produto alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Limpar();
                ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCategoria()
        {
            //Método que listará as categorias cadastradas no ComboBox cboCategoria, mostrando os nomes, mas se baseando pelo seu ID. 
            try
            {
                novoProduto = new RegraNegocio.ProdutosRegraNegocio();

                cboCategoria.DataSource = novoProduto.ListarCategorias();
                cboCategoria.DisplayMember = "NOME_CATEGORIA_PRODUTOS";
                cboCategoria.ValueMember = "ID_CATEGORIA_PRODUTOS";

                cboCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarUnidade()
        {
            //Método que listará as unidades cadastradas no ComboBox cboUnidadeProduto, mostrando os nomes, mas se baseando pelo seu ID. 
            try
            {
                novoProduto = new RegraNegocio.ProdutosRegraNegocio();

                cboUnidadeProduto.DataSource = novoProduto.ListarUnidades();
                cboUnidadeProduto.DisplayMember = "NOME_UNIDADE_PRODUTOS";
                cboUnidadeProduto.ValueMember = "ID_UNIDADE_PRODUTOS";

                cboUnidadeProduto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ListarProdutos();
            ListarCategoria();
            ListarUnidade();
        }

        private void dtgListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Verifica se a coluna clicada foi referente ao btnEditar.
                if (dtgListaProdutos.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //se a condição for verdadeira, cada componente do formulário receberá as informações do DataGrid correspondentes a eles.
                    txtCodigo.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value.ToString();
                    txtCodigoBarras.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["CODIGO_BARRAS_PRODUTO"].Value.ToString();
                    txtNome.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["NOME_PRODUTO"].Value.ToString();
                    txtDescricao.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["DESCRICAO_PRODUTO"].Value.ToString();
                    cboUnidadeProduto.SelectedValue = dtgListaProdutos.Rows[e.RowIndex].Cells["ID_UNIDADE"].Value.ToString();
                    cboCategoria.SelectedValue = dtgListaProdutos.Rows[e.RowIndex].Cells["ID_CATEGORIA"].Value.ToString();
                    txtEstoqueMinimo.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ESTOQUE_MINIMO"].Value.ToString();
                    txtEstoqueAtual.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ESTOQUE_ATUAL"].Value.ToString();
                    txtCusto.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["VALOR_COMPRA"].Value.ToString();
                    txtVenda.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["VALOR_VENDA"].Value.ToString();
                    txtMargemLucro.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["MARGEM"].Value.ToString();
                    txtAnotacoes.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ANOTACOES"].Value.ToString();
                    dtpData.Value = Convert.ToDateTime(dtgListaProdutos.Rows[e.RowIndex].Cells["DATA_CADASTRO_PRODUTO"].Value);
                    cbAtivo.Checked = Convert.ToBoolean(dtgListaProdutos.Rows[e.RowIndex].Cells["SITUACAO_PRODUTO"].Value);
                }
                //Caso o clique não foi no btnEditar, verifica se foi no btExcluir e se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
                else if (dtgListaProdutos.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                    MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Se sim, realiza o método Excluir, mostra mensagem do sucesso dessa ação, lista os produtos no DataGrid e limpa todos os campos.
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio(); 
                    novoProduto.Excluir(Convert.ToInt32(dtgListaProdutos.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value));
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                    ListarProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarProdutos()
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutosRegraNegocio(); 
                dtgListaProdutos.DataSource = novoProduto.Listar();

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgListaProdutos.Rows.Count; i += 2)
            {
                dtgListaProdutos.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }
    }
}
