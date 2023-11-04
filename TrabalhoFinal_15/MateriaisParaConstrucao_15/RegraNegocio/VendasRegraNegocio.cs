using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class VendasRegraNegocio
    {
        AcessoDados.VendasAcessoDados novaVenda;
        AcessoDados.ProdutosAcessoDados novoProduto;

        #region Vendas

        public void SalvarVenda(int idUsuario, int idCliente, DateTime data, bool situacao)
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();
                novaVenda.SalvarVenda(idUsuario, idCliente, data, situacao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarVenda(int idVenda, int idUsuario, int idCliente, DateTime data, bool situacao)
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();
                novaVenda.AlterarVenda(idVenda, idUsuario, idCliente, data, situacao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirVenda(int idVenda)
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();
                novaVenda.ExcluirVenda(idVenda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarVenda()
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novaVenda.ListarVenda();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarVenda(int idCliente)
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novaVenda.RetornarVenda(idCliente);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Detalhes

        public void SalvarDetalhes(int idVenda, int idProduto, int quantidade)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                int estoqueAtual = novoProduto.RetornarEstoqueProduto(idProduto);

                if (quantidade > estoqueAtual)
                {
                    throw new Exception("Estoque insuficiente para a compra.");
                }

                else
                {
                    novaVenda = new AcessoDados.VendasAcessoDados();
                    novaVenda.SalvarDetalhes(idVenda, idProduto, quantidade);

                    novoProduto = new AcessoDados.ProdutosAcessoDados();
                    novoProduto.AtualizarEstoque(idProduto, estoqueAtual - quantidade);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarDetalhes(int idDetalhes, int quantidade, int idProduto)
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();
                int quantidadeAnterior = novaVenda.RetornarDetalhesVendas(idDetalhes);

                int quantidadeFinal = quantidade - quantidadeAnterior;

                novoProduto = new AcessoDados.ProdutosAcessoDados();
                int estoqueAtual = novoProduto.RetornarEstoqueProduto(idProduto);

                if (quantidadeFinal > estoqueAtual)
                {
                    throw new Exception("Estoque insuficiente para a compra.");
                }

                else
                {
                    novaVenda = new AcessoDados.VendasAcessoDados();
                    novaVenda.AlterarDetalhes(idDetalhes, quantidade);

                    novoProduto = new AcessoDados.ProdutosAcessoDados();
                    novoProduto.AtualizarEstoque(idProduto, estoqueAtual - quantidadeFinal);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirDetalhes(int idDetalhes)
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();
                novaVenda.ExcluirDetalhes(idDetalhes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarDetalhes()
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novaVenda.ListarDetalhes();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarDetalhes(int idVenda)
        {
            try
            {
                novaVenda = new AcessoDados.VendasAcessoDados();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novaVenda.RetornarDetalhes(idVenda);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
