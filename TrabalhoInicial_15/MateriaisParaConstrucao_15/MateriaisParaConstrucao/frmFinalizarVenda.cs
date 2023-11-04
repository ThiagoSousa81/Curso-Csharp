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
    public partial class frmFinalizarVenda : Form
    {
        private DataGridView dadosProdutos;
        private string documentoCliente;
        private int idUsuario, idCliente, idVenda, IRetorno;
        frmVendas frmVendas;

        string auxAcrescimoDesconto = "";
        string valorAcrescimoDesconto = "0";

        public frmFinalizarVenda(string subTotal, DataGridView produtos, string documentoCliente, int idCliente, int idUsuario, int idVenda, frmVendas frmVendas)
        {
            InitializeComponent();
            this.dadosProdutos = produtos;
            this.txtSubTotal.Text = subTotal;
            this.documentoCliente = documentoCliente;
            this.idCliente = idCliente;
            this.idUsuario = idUsuario;
            this.idVenda = idVenda;
            this.frmVendas = frmVendas;
        }

        private void frmFinalizarVenda_Load(object sender, EventArgs e)
        {
            string novoItem;
            decimal total = 0;

            for (int i = 0; i < dadosProdutos.Rows.Count; i++)
            {
                novoItem = i + 1 + "\t" + dadosProdutos["CODIGO_BARRAS", i].Value + "\t" +
                            dadosProdutos["NOME_PRODUTO", i].Value + "\t" + dadosProdutos["QUANTIDADE", i].Value +
                            "\t" + dadosProdutos["VALOR_VENDA", i].Value + "\t" + dadosProdutos["SUBTOTAL", i].Value;

                ltCupomFiscal.Items.Add(novoItem);

                total = Convert.ToDecimal(dadosProdutos["SUBTOTAL", i].Value) + total;
            }

            novoItem = "SUB-TOTAL  R$ \t \t \t \t \t \t" + total;

            ltCupomFiscal.Items.Add(novoItem);  
        }

        public void CancelarVenda()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente cancelar a venda?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dadosProdutos.Rows.Count > 0)
                {

                    for (int i = 0; i < dadosProdutos.Rows.Count; i++)
                    {
                        //Verifica a quantidade em estoque do produto e, logo em seguida, soma com a quantidade comprada.
                        RegraNegocio.ProdutosRegraNegocio produtos = new RegraNegocio.ProdutosRegraNegocio();
                        int estoqueAtual = produtos.RetornarEstoqueProduto(Convert.ToInt32(dadosProdutos.Rows[i].Cells["ID_PRODUTO"].Value));
                        estoqueAtual = estoqueAtual + Convert.ToInt32(dadosProdutos.Rows[i].Cells["QUANTIDADE"].Value);

                        //Utilizando o método BaixarEstoque atualiza o estoque, voltando para o banco a quantidade que seria comprada.
                        produtos = new RegraNegocio.ProdutosRegraNegocio();
                        produtos.AtualizarEstoque(Convert.ToInt32(dadosProdutos.Rows[i].Cells["ID_PRODUTO"].Value), estoqueAtual);

                        //Exclui o item comprado.
                        RegraNegocio.VendasRegraNegocio venda = new RegraNegocio.VendasRegraNegocio();
                        venda.ExcluirDetalhes(Convert.ToInt32(dadosProdutos.Rows[i].Cells["ID_DETALHES"].Value));

                        //Verifica se está na última linha do datagrid. Se estiver, a venda poderá ser excluída.
                        if ((dadosProdutos.Rows.Count - 1) == i)
                        {
                            venda = new RegraNegocio.VendasRegraNegocio();
                            venda.ExcluirVenda(Convert.ToInt32(dadosProdutos.Rows[i].Cells["ID_VENDA"].Value));

                            MessageBox.Show("Venda cancelada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                        frmVendas.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void chkAcrescimo_Click(object sender, EventArgs e)
        {
            txtAcrescimo.Enabled = true;
            chkAcrescimo.CheckState = CheckState.Checked;
            auxAcrescimoDesconto = "A";

            if (chkAcrescimo.Checked)
            {
                chkDesconto.CheckState = CheckState.Unchecked;
                txtDesconto.Enabled = false;
                txtDesconto.Text = "0";
            }
        }

        private void chkDesconto_Click(object sender, EventArgs e)
        {
            txtDesconto.Enabled = true;
            chkDesconto.CheckState = CheckState.Checked;
            auxAcrescimoDesconto = "D";

            if (chkDesconto.Checked)
            {
                chkAcrescimo.CheckState = CheckState.Unchecked;
                txtAcrescimo.Enabled = false;
                txtAcrescimo.Text = "0";
            }
        }

        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
            string subTotal = txtSubTotal.Text.Substring(3);

            decimal acrescimo = (Convert.ToDecimal(subTotal) * Convert.ToDecimal(txtAcrescimo.Text)) / 100;
            decimal total = (Convert.ToDecimal(subTotal) + acrescimo);

            txtTotal.Text = total.ToString("c");

            valorAcrescimoDesconto = txtAcrescimo.Text + ",00";
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            string subTotal = txtSubTotal.Text.Substring(3);

            decimal desconto = (Convert.ToDecimal(subTotal) * Convert.ToDecimal(txtDesconto.Text)) / 100;
            decimal total = (Convert.ToDecimal(subTotal) - desconto);

            txtTotal.Text = total.ToString("c");

            valorAcrescimoDesconto = txtDesconto.Text + ",00";
        }

        private void txtValorPago_Enter(object sender, EventArgs e)
        {
            if (chkAcrescimo.Checked == false && chkDesconto.Checked == false)
            {
                txtTotal.Text = txtSubTotal.Text;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtValorPago.Text);
            txtValorPago.Text = valor.ToString("c");

            string total = txtTotal.Text.Substring(3);

            txtTroco.Text = (Convert.ToDecimal(valor) - Convert.ToDecimal(total)).ToString("c");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                IRetorno = RegraNegocio.CupomFiscal.Bematech_FI_AbreCupom(documentoCliente);
                RegraNegocio.CupomFiscal.Analisa_iRetorno(IRetorno);

                for (int i = 0; i < dadosProdutos.Rows.Count; i++)
                {
                    IRetorno = RegraNegocio.CupomFiscal.Bematech_FI_VendeItem(dadosProdutos["CODIGO_BARRAS", i].Value.ToString(),
                        dadosProdutos["NOME_PRODUTO", i].Value.ToString(), "FF", "I",
                        dadosProdutos["QUANTIDADE", i].Value.ToString(), 2, dadosProdutos["VALOR_VENDA", i].Value.ToString(), "%", "0");

                    RegraNegocio.CupomFiscal.Analisa_iRetorno(IRetorno);
                }

                IRetorno = RegraNegocio.CupomFiscal.Bematech_FI_IniciaFechamentoCupom(auxAcrescimoDesconto, "%", valorAcrescimoDesconto);
                RegraNegocio.CupomFiscal.Analisa_iRetorno(IRetorno);

                IRetorno = RegraNegocio.CupomFiscal.Bematech_FI_EfetuaFormaPagamento(cboPagamento.Text, txtValorPago.Text.Substring(3));
                RegraNegocio.CupomFiscal.Analisa_iRetorno(IRetorno);

                IRetorno = RegraNegocio.CupomFiscal.Bematech_FI_TerminaFechamentoCupom("OBRIGADO! VOLTE SEMPRE!");
                RegraNegocio.CupomFiscal.Analisa_iRetorno(IRetorno);

                RegraNegocio.VendasRegraNegocio venda = new RegraNegocio.VendasRegraNegocio();
                venda.AlterarVenda(idVenda, idUsuario, idCliente, DateTime.Now, true);

                MessageBox.Show("Venda finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                frmVendas.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
