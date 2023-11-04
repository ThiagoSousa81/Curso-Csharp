using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ProdutosRegraNegocio
    {
        AcessoDados.ProdutosAcessoDados novoProduto;

        public void SalvarCategoria(string nomeCategoria, string descricaoCategoria)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.SalvarCategoria(nomeCategoria, descricaoCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarCategoria(int idCategoria, string nomeCategoria, string descricaoCategoria)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.AlterarCategoria(idCategoria, nomeCategoria, descricaoCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCategoria(int idCategoria)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.ExcluirCategoria(idCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarCategorias()
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.ListarCategorias();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarUnidade(string nomeUnidade, string descricaoUnidade)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.SalvarUnidade(nomeUnidade, descricaoUnidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarUnidade(int idUnidade, string nomeUnidade, string descricaoUnidade)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.AlterarUnidade(idUnidade, nomeUnidade, descricaoUnidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirUnidade(int idUnidade)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.ExcluirUnidade(idUnidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarUnidades()
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.ListarUnidades();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Salvar(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                           string valorCompra, string valorVenda, string margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto)
        {
            try
            {
                Validar(codigoBarras, nome, descricao, idCategoria, estoqueAtual, estoqueMinimo, idUnidade, valorCompra, margem, valorVenda);

                novoProduto = new AcessoDados.ProdutosAcessoDados();

                DataTable dadosTabela = new DataTable();
                //Verifica se existem produtos cadastrados com o mesmo código de barras. Se existir(em), serão armazenados em dadosTabela.
                dadosTabela = novoProduto.PesquisaCodigoBarras(codigoBarras);

                if (dadosTabela.Rows.Count > 0) //Verifica se a pesquisa retornou linhas. Se verdadeiro, o cadastro é interrompido.
                {
                    //Informa ao usuário que já existe um produto cadastrado, mostrando o nome dele.
                    throw new Exception("Já existe um produto cadastrado com esse código de barras! \n Produto: " + dadosTabela.Rows[0]["NOME_PRODUTO"].ToString());
                }
                else //Caso contrário, o cadastro é efetuado.
                {
                    novoProduto = new AcessoDados.ProdutosAcessoDados();
                    novoProduto.Salvar(codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(valorCompra), Convert.ToDecimal(valorVenda), Convert.ToDecimal(margem), anotacoesProdutos, situacaoProdutos, dataCadastroProduto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idProduto, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                            string valorCompra, string valorVenda, string margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto)
        {
            try
            {
                Validar(codigoBarras, nome, descricao, idCategoria, estoqueAtual, estoqueMinimo, idUnidade, valorCompra, margem, valorVenda);

                novoProduto = new AcessoDados.ProdutosAcessoDados();

                DataTable dadosTabela = new DataTable();
                //Verifica se existem produtos cadastrados com o mesmo código de barras. Se existir(em), serão armazenados em dadosTabela.
                dadosTabela = novoProduto.PesquisaCodigoBarras(codigoBarras);

                //Verifica se a pesquisa retornou linhas. Se sim, precisamos verificar se o retorno trata-se do produto que estamos alterando.
                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++) //Percorre cada linha da tabela em memória.
                    {
                        //Verifica se o conteúdo da coluna ID_PRODUTO presente na tabela é igual ao valor do parâmetro idProduto. Se for igual, altera.
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_PRODUTO"]) == idProduto)
                        {
                            novoProduto = new AcessoDados.ProdutosAcessoDados();
                            novoProduto.Alterar(idProduto, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(valorCompra), Convert.ToDecimal(valorVenda),
                                                Convert.ToDecimal(margem), anotacoesProdutos, situacaoProdutos, dataCadastroProduto);
                        }
                        else //Caso contrário, trata-se de outro produto, portanto, não pode ser alterado.
                        {
                            //Informa ao usuário que já existe um produto cadastrado, mostrando o nome dele.
                            throw new Exception("Já existe um produto cadastrado com esse código de barras! \n Produto: " + dadosTabela.Rows[0]["NOME_PRODUTO"].ToString());
                        }
                    }
                }
                else //Se não retornou linhas, significa que não existe nenhum código de barras igual a este cadastrado, portanto, pode ser alterado.
                {
                    novoProduto = new AcessoDados.ProdutosAcessoDados();
                    novoProduto.Alterar(idProduto, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(valorCompra), Convert.ToDecimal(valorVenda),
                                        Convert.ToDecimal(margem), anotacoesProdutos, situacaoProdutos, dataCadastroProduto);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idProduto)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.Excluir(idProduto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validar(string codigoBarras, string nome, string descricao, int idCategoria, int estoqueAtual,
          int estoqueMinimo, int idUnidade, string valorCompra, string margem, string valorVenda)
        {
            if (codigoBarras.Trim().Length == 0)
            {
                throw new Exception("O campo Código de Barras deve ser preenchido!");
            }

            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (descricao.Trim().Length == 0)
            {
                throw new Exception("O campo Descrição não pode ser vazio!");
            }

            if (idCategoria == 0)
            {
                throw new Exception("O campo Categoria não pode ser vazio!");
            }

            if (estoqueAtual == 0)
            {
                throw new Exception("O campo Estoque Atual não pode ser vazio!");
            }

            if (estoqueMinimo == 0)
            {
                throw new Exception("O campo Estoque Mínimo não pode ser vazio!");
            }

            if (idUnidade == 0)
            {
                throw new Exception("O campo Unidade do Produto não pode ser vazio!");
            }


            try
            {
                decimal valor = Convert.ToDecimal(valorCompra);
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico no campo Custo.");
            }

            if (Convert.ToDecimal(valorCompra) == 0)
            {
                throw new Exception("O campo Custo não pode ser vazio!");
            }


            try
            {
                decimal valor = Convert.ToDecimal(margem);
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico no campo Margem de Lucro %.");
            }

            if (Convert.ToDecimal(margem) == 0)
            {
                throw new Exception("O campo Margem de Lucro % não pode ser vazio!");
            }


            try
            {
                decimal valor = Convert.ToDecimal(valorVenda);
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico no campo Venda.");
            }

            if (Convert.ToDecimal(valorVenda) == 0)
            {
                throw new Exception("O campo Venda não pode ser vazio!");
            }
        }

        public DataTable PesquisaCodigoBarras(string codigoBarras)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.PesquisaCodigoBarras(codigoBarras);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarProduto(string codigoBarras)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.RetornarProduto(codigoBarras);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int RetornarEstoqueProduto(int idProduto)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                int quantidadeAtual = novoProduto.RetornarEstoqueProduto(idProduto);
                return quantidadeAtual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarEstoque(int idProduto, int estoqueAtual)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.AtualizarEstoque(idProduto, estoqueAtual);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaNome(string nome)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.PesquisaNome(nome);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
