using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class VendasAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        #region Vendas

        public void SalvarVenda(int idUsuario, int idCliente, DateTime data, bool situacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Vendas(ID_USUARIO, ID_CLIENTE, DATA_VENDA, SITUACAO)");
                    sql.Append(" VALUES (@idUsuario, @idCliente, @data, @situacao)");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarVenda. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarVenda(int idVenda, int idUsuario, int idCliente, DateTime data, bool situacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Vendas");
                    sql.Append(" SET ID_USUARIO = @idUsuario, ID_CLIENTE = @idCliente, DATA_VENDA = @data, SITUACAO = @situacao");
                    sql.Append(" WHERE ID_VENDA = @idVenda");

                    comandoSql.Parameters.Add(new SqlParameter("@idVenda", idVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarVenda. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirVenda(int idVenda)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Vendas");
                    sql.Append(" WHERE ID_VENDA = @idVenda");

                    comandoSql.Parameters.Add(new SqlParameter("@idVenda", idVenda));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ExcluirVenda. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable RetornarVenda(int idCliente)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Vendas");
                    sql.Append(" WHERE ID_CLIENTE = @idCliente");
                    sql.Append(" ORDER BY ID_VENDA DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarVenda. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarVenda()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Vendas");
                    sql.Append(" ORDER BY ID_VENDA DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarVenda. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        #endregion

        #region DetalhesVenda

        public void SalvarDetalhes(int idVenda, int idProduto, int quantidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Detalhes_vendas(ID_VENDA, ID_PRODUTO, QUANTIDADE)");
                    sql.Append(" VALUES (@idVenda, @idProduto, @quantidade)");

                    comandoSql.Parameters.Add(new SqlParameter("@idVenda", idVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));
                    comandoSql.Parameters.Add(new SqlParameter("@quantidade", quantidade));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarDetalhes. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarDetalhes(int idDetalhes, int quantidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Detalhes_vendas");
                    sql.Append(" SET QUANTIDADE = @quantidade");
                    sql.Append(" WHERE ID_DETALHES = @idDetalhes");

                    comandoSql.Parameters.Add(new SqlParameter("@idDetalhes", idDetalhes));
                    comandoSql.Parameters.Add(new SqlParameter("@quantidade", quantidade));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarDetalhes. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirDetalhes(int idDetalhes)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Detalhes_vendas");
                    sql.Append(" WHERE ID_DETALHES = @idDetalhes");

                    comandoSql.Parameters.Add(new SqlParameter("@idDetalhes", idDetalhes));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ExcluirDetalhes. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable RetornarDetalhes(int idVenda)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.CODIGO_BARRAS_PRODUTO, Produtos.NOME_PRODUTO, Produtos.DESCRICAO_PRODUTO, Produtos.VALOR_VENDA, Detalhes_vendas.*");
                    sql.Append(" FROM Detalhes_vendas INNER JOIN Produtos ON Detalhes_vendas.ID_PRODUTO = Produtos.ID_PRODUTO");
                    sql.Append(" WHERE ID_VENDA = @idVenda");
                    sql.Append(" ORDER BY ID_DETALHES DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@idVenda", idVenda));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarDetalhes. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarDetalhes()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Detalhes_vendas");
                    sql.Append(" ORDER BY ID_DETALHES DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarDetalhes. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public int RetornarDetalhesVendas(int idDetalhes)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT QUANTIDADE FROM Detalhes_vendas");
                    sql.Append(" WHERE (ID_DETALHES = @idDetalhes)");

                    comandoSql.Parameters.Add(new SqlParameter("@idDetalhes", idDetalhes));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    int quantidade = (Int32)comandoSql.ExecuteScalar();
                    return quantidade;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarDetalhesVendas. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        #endregion
    }
}
