using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class FuncionariosRegraNegocio
    {
        AcessoDados.FuncionariosAcessoDados novoFuncionario;

        //Método cuja função é chamar o método Salvar da classe FuncionariosAcessoDados.
        public void Salvar(string nome, string endereco, string bairro, string cep, string cidade, string email,
                          DateTime nascimento, string telefone1, string telefone2, string rg, string cpf,
                          string observacoes, DateTime dataCadastro)
        {
            try
            {
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                novoFuncionario.Salvar(nome, endereco, bairro, cep, cidade, email, nascimento, telefone1, telefone2, rg, cpf, observacoes, dataCadastro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método Listar da classe FuncionariosAcessoDados e retornar essas informações ao objeto dadosTabela.
        public DataTable Listar()
        {
            try
            {
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoFuncionario.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método Alterar da classe FuncionariosAcessoDados.
        public void Alterar(int idFuncionario, string nome, string endereco, string bairro, string cep,
                            string cidade, string email, DateTime nascimento, string telefone1, string telefone2,
                            string rg, string cpf, string observacoes, DateTime dataCadastro)
        {
            try
            {
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                novoFuncionario.Alterar(idFuncionario, nome, endereco, bairro, cep, cidade, email, nascimento, telefone1, telefone2, rg, cpf, observacoes, dataCadastro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método Excluir da classe FuncionariosAcessoDados.
        public void Excluir(int idFuncionario)
        {
            try
            {
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                novoFuncionario.Excluir(idFuncionario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método PesquisarNome da classe FuncionariosAcessoDados, baseados pelo nome do funcionário e retornar essa informação ao objeto dadosTabela.
        public DataTable PesquisarNome(string nome)
        {
            try
            {
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoFuncionario.PesquisarNome(nome);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método PesquisarCpf da classe FuncionariosAcessoDados, baseados pelo CPF do funcionário e retornar essa informação ao objeto dadosTabela.
        public DataTable PesquisarCpf(string cpf)
        {
            try
            {
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoFuncionario.PesquisarCpf(cpf);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
