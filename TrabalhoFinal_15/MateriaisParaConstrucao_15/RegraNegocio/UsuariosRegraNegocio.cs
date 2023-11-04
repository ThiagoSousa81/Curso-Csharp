using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class UsuariosRegraNegocio
    {
        AcessoDados.UsuariosAcessoDados novoUsuario;
        Criptografia criptografar;

        public void Validar(string nome, string login, int idNivel, string senha, string senha2, string status)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio");
            }

            if (login.Trim().Length == 0)
            {
                throw new Exception("O campo Login não pode ser vazio");
            }

            if (idNivel == 0)
            {
                throw new Exception("O campo Nível não pode ser vazio");
            }

            if (senha.Trim().Length == 0 && senha2.Trim().Length == 0)
            {
                throw new Exception("O campo Senha não pode ser vazio");
            }

            if (senha.Trim().Length > 8)
            {
                throw new Exception("O campo Senha não pode ter mais de 8 (oito) caracteres.");
            }

            if (senha != senha2)
            {
                throw new Exception("As senhas não conferem. Digite-as novamente.");
            }

            if (status.Trim().Length == -1)
            {
                throw new Exception("O campo Status não pode ser vazio");
            }

        }

        public void Salvar(string nome, DateTime data, string login, int idNivel, string senha, string senha2, string status)
        {
            try
            {
                Validar(nome, login, idNivel, senha, senha2, status);

                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarLogin(login);

                if (dadosTabela.Rows.Count > 0)
                {
                    throw new Exception("Este Login já foi utilizado, cadastre outro! \nUsuário: " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString());
                }
                else
                {
                    criptografar = new Criptografia();
                    string senhaCripto = criptografar.Criptografar(senha); //Criptografa a senha para armazenar no banco.

                    novoUsuario = new AcessoDados.UsuariosAcessoDados();
                    novoUsuario.Salvar(nome, data, login, idNivel, senhaCripto, status);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idUsuario, string nome, DateTime data, string login, int idNivel, string senha, string senha2, string status)
        {
            try
            {
                Validar(nome, login, idNivel, senha, senha2, status);

                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarLogin(login);

                criptografar = new Criptografia();
                string senhaCripto = criptografar.Criptografar(senha); //Criptografa a senha para armazenar no banco.

                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_USUARIO"]) == idUsuario)
                        {
                            novoUsuario = new AcessoDados.UsuariosAcessoDados();
                            novoUsuario.Alterar(idUsuario, nome, data, login, idNivel, senhaCripto, status);
                        }
                        else
                        {
                            throw new Exception("Este Login já foi utilizado, cadastre outro! \nUsuario: " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString());
                        }
                    }
                }
                else
                {
                    novoUsuario = new AcessoDados.UsuariosAcessoDados();
                    novoUsuario.Alterar(idUsuario, nome, data, login, idNivel, senhaCripto, status);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idUsuario)
        {
            try
            {
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                novoUsuario.Excluir(idUsuario);
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
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoUsuario.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Login(string login, string senha)  //Realiza a verificação do Login do usuário, através do método Login da classe UsuariosAcessoDados.
        {
            try
            {
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoUsuario.Login(login, senha);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarUsuario(int idUsuario) //Retorna o usuário pelo seu ID, através do método RetornarUsuario da classe UsuariosAcessoDados.
        {
            try
            {
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoUsuario.RetornarUsuario(idUsuario);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
