using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class ProdutosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void SalvarCategoria(string nomeCategoria, string descricaoCategoria)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Categoria_produtos (NOME_CATEGORIA_PRODUTOS, DESCRICAO_CATEGORIA_PRODUTOS)");
                    sql.Append(" VALUES (@nomeCategoria, @descricaoCategoria)");

                    comandoSql.Parameters.Add(new SqlParameter("@nomeCategoria", nomeCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoCategoria", descricaoCategoria));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarCategoria. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarCategoria(int idCategoria, string nomeCategoria, string descricaoCategoria)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Categoria_produtos");
                    sql.Append(" SET NOME_CATEGORIA_PRODUTOS=@nomeCategoria, DESCRICAO_CATEGORIA_PRODUTOS=@descricaoCategoria");
                    sql.Append(" WHERE (ID_CATEGORIA_PRODUTOS = @idCategoria)");

                    comandoSql.Parameters.Add(new SqlParameter("@nomeCategoria", nomeCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoCategoria", descricaoCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarCategoria. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirCategoria(int idCategoria)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Categoria_produtos");
                    sql.Append(" WHERE (ID_CATEGORIA_PRODUTOS = @idCategoria)");

                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ExcluirCategoria. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarCategorias()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Categoria_produtos");
                    sql.Append(" ORDER BY ID_CATEGORIA_PRODUTOS");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarCategorias. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public void SalvarUnidade(string nomeUnidade, string descricaoUnidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Unidade_produtos (NOME_UNIDADE_PRODUTOS, DESCRICAO_UNIDADE_PRODUTOS)");
                    sql.Append(" VALUES (@nomeUnidade, @descricaoUnidade)");

                    comandoSql.Parameters.Add(new SqlParameter("@nomeUnidade", nomeUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoUnidade", descricaoUnidade));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarUnidade. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarUnidade(int idUnidade, string nomeUnidade, string descricaoUnidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Unidade_produtos");
                    sql.Append(" SET NOME_UNIDADE_PRODUTOS=@nomeUnidade, DESCRICAO_UNIDADE_PRODUTOS=@descricaoUnidade");
                    sql.Append(" WHERE (ID_UNIDADE_PRODUTOS = @idUnidade)");

                    comandoSql.Parameters.Add(new SqlParameter("@nomeUnidade", nomeUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoUnidade", descricaoUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarUnidade. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirUnidade(int idUnidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Unidade_produtos");
                    sql.Append(" WHERE (ID_UNIDADE_PRODUTOS = @idUnidade)");

                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ExcluirUnidade. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarUnidades()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Unidade_produtos");
                    sql.Append(" ORDER BY ID_UNIDADE_PRODUTOS");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarUnidades. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public void Salvar(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                           decimal valorCompra, decimal valorVenda, decimal margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Produtos (CODIGO_BARRAS_PRODUTO, NOME_PRODUTO, DESCRICAO_PRODUTO, ID_UNIDADE, ID_CATEGORIA, ESTOQUE_MINIMO, ESTOQUE_ATUAL,");
                    sql.Append(" VALOR_COMPRA, VALOR_VENDA, MARGEM, ANOTACOES_PRODUTO, SITUACAO_PRODUTO, DATA_CADASTRO_PRODUTO)");
                    sql.Append(" VALUES (@codigoBarras, @nome, @descricao, @idUnidade, @idCategoria, @estoqueMinimo, @estoqueAtual, @valorCompra, @valorVenda, @margem,");
                    sql.Append(" @anotacoesProdutos, @situacaoProdutos, @dataCadastroProduto)");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueMinimo", estoqueMinimo));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));
                    comandoSql.Parameters.Add(new SqlParameter("@valorCompra", valorCompra));
                    comandoSql.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@margem", margem));
                    comandoSql.Parameters.Add(new SqlParameter("@anotacoesProdutos", anotacoesProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@situacaoProdutos", situacaoProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastroProduto", dataCadastroProduto));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Alterar(int idProduto, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                            decimal valorCompra, decimal valorVenda, decimal margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Produtos");
                    sql.Append(" SET CODIGO_BARRAS_PRODUTO=@codigoBarras, NOME_PRODUTO=@nome, DESCRICAO_PRODUTO=@descricao,");
                    sql.Append(" ID_UNIDADE=@idUnidade, ID_CATEGORIA=@idCategoria, ESTOQUE_MINIMO=@estoqueMinimo,");
                    sql.Append(" ESTOQUE_ATUAL=@estoqueAtual, VALOR_COMPRA=@valorCompra, VALOR_VENDA=@valorVenda, MARGEM=@margem,");
                    sql.Append(" ANOTACOES_PRODUTO=@anotacoesProdutos, SITUACAO_PRODUTO=@situacaoProdutos, DATA_CADASTRO_PRODUTO=@dataCadastroProduto");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueMinimo", estoqueMinimo));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));
                    comandoSql.Parameters.Add(new SqlParameter("@valorCompra", valorCompra));
                    comandoSql.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@margem", margem));
                    comandoSql.Parameters.Add(new SqlParameter("@anotacoesProdutos", anotacoesProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@situacaoProdutos", situacaoProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastroProduto", dataCadastroProduto));
                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Excluir(int idProduto)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Produtos");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS_PRODUTO, Produtos.NOME_PRODUTO, Produtos.DESCRICAO_PRODUTO,");
                    sql.Append(" Produtos.ID_UNIDADE, Unidade_produtos.NOME_UNIDADE_PRODUTOS, Produtos.ID_CATEGORIA, Produtos.ESTOQUE_MINIMO, Produtos.ESTOQUE_ATUAL,");
                    sql.Append(" Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.MARGEM, Produtos.ANOTACOES_PRODUTO, Produtos.SITUACAO_PRODUTO, Produtos.DATA_CADASTRO_PRODUTO");
                    sql.Append(" FROM (Produtos INNER JOIN Unidade_produtos ON Produtos.ID_UNIDADE = Unidade_produtos.ID_UNIDADE_PRODUTOS)");
                    sql.Append(" ORDER BY Produtos.NOME_PRODUTO ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaCodigoBarras(string codigoBarras)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS_PRODUTO, Produtos.NOME_PRODUTO, Produtos.DESCRICAO_PRODUTO,");
                    sql.Append(" Produtos.ID_UNIDADE, Unidade_produtos.NOME_UNIDADE_PRODUTOS, Produtos.ID_CATEGORIA, Produtos.ESTOQUE_MINIMO, Produtos.ESTOQUE_ATUAL,");
                    sql.Append(" Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.MARGEM, Produtos.ANOTACOES_PRODUTO, Produtos.SITUACAO_PRODUTO, Produtos.DATA_CADASTRO_PRODUTO");
                    sql.Append(" FROM (Produtos INNER JOIN Unidade_produtos ON Produtos.ID_UNIDADE = Unidade_produtos.ID_UNIDADE_PRODUTOS)");
                    sql.Append(" WHERE Produtos.CODIGO_BARRAS_PRODUTO LIKE '%'+@codigoBarras+'%'");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaCodigoBarras. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable RetornarProduto(string codigoBarras)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Produtos");
                    sql.Append(" WHERE CODIGO_BARRAS_PRODUTO = @codigoBarras");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarProdutos. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public int RetornarEstoqueProduto(int idProduto)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT ESTOQUE_ATUAL FROM Produtos");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    int estoqueProduto = (Int32)comandoSql.ExecuteScalar();
                    return estoqueProduto;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarEstoqueProduto. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AtualizarEstoque(int idProduto, int estoqueAtual)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Produtos");
                    sql.Append(" SET ESTOQUE_ATUAL = @estoqueAtual");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarEstoque. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaNome(string nome)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.*, NOME_CATEGORIA from Produtos INNER JOIN Categorias ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" WHERE Produtos.NOME_PRODUTO LIKE '%'+@nome+'%'");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaNome. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
