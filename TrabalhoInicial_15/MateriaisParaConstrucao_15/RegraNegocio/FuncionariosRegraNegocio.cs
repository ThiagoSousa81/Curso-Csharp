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
