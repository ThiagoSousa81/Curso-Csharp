using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class UsuariosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, DateTime data, string login, int idNivel, string senha, string status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
                {
                    conn.Open();

                    sql.Append("INSERT INTO Usuarios (NOME_USUARIO, DATA_CADASTRO, LOGIN_USUARIO, SENHA_USUARIO, STATUS_USUARIO, ID_NIVEL)");
                    sql.Append(" VALUES (@nome, @data, @login, @senha, @status, @idNivel)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conn;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Alterar(int idUsuario, string nome, DateTime data, string login, int idNivel, string senha, string status)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Usuarios");
                    sql.Append(" SET NOME_USUARIO = @nome, DATA_CADASTRO = @data, LOGIN_USUARIO = @login, SENHA_USUARIO = @senha, STATUS_USUARIO = @status, ID_NIVEL = @idNivel");
                    sql.Append(" WHERE (ID_USUARIO = @idUsuario)");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

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

        public void Excluir(int idUsuario)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Usuarios");
                    sql.Append(" WHERE (ID_USUARIO = @idUsuario)");
                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

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

                    sql.Append("SELECT Usuarios.*, NOME_NIVEL FROM Usuarios INNER JOIN Nivel_Acesso");
                    sql.Append(" ON Usuarios.ID_NIVEL = Nivel_Acesso.ID_NIVEL");
                    sql.Append(" ORDER BY NOME_USUARIO ASC");

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

        public DataTable Login(string login, string senha) //Seleciona o usuário e retorna aquele que informamos o login e senha.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Usuarios");
                    sql.Append(" WHERE LOGIN_USUARIO = @login AND SENHA_USUARIO = @senha");

                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));

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

        public DataTable RetornarLogin(string login) //Seleciona o usuário e retorna aquele que informamos o login.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Usuarios");
                    sql.Append(" WHERE LOGIN_USUARIO = @login");

                    comandoSql.Parameters.Add(new SqlParameter("@login", login));

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

        public DataTable RetornarUsuario(int idUsuario) //Seleciona todas as informações da tabela Usuários e a coluna NOME_NIVEL da tabela Nivel_Acesso   
        {                                               //realizando a junção entre elas, em que o ID_NIVEL for igual em ambas, retornando os dados quando o ID_USUARIO for o que informamos.
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Usuarios.*, NOME_NIVEL FROM Usuarios INNER JOIN Nivel_Acesso");
                    sql.Append(" ON Usuarios.ID_NIVEL = Nivel_Acesso.ID_NIVEL");
                    sql.Append(" WHERE ID_USUARIO = @idUsuario");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarUsuario. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
