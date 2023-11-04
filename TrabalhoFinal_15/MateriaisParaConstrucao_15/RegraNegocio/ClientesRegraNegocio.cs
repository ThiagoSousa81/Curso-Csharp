using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ClientesRegraNegocio
    {
        AcessoDados.ClientesAcessoDados novoCliente;

        //Método cuja função é chamar o método Salvar da classe ClientesAcessoDados.
        public void Salvar(string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1,
                                     string telefone2, string email, DateTime dataCadastro, DateTime nascimento, string observacoes)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Salvar(nome, endereco, bairro, cep, cidade, estado, telefone1, telefone2, email, dataCadastro, nascimento, observacoes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método SalvarPessoaFísica da classe ClientesAcessoDados.
        public void SalvarPessoaFísica(int idCliente, string cpf, string rg)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.SalvarPessoaFísica(idCliente, cpf, rg);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método SalvarPessoaJuridica da classe ClientesAcessoDados.
        public void SalvarPessoaJuridica(int idCliente, string cnpj, string ie)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.SalvarPessoaJuridica(idCliente, cnpj, ie);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método Listar da classe ClientesAcessoDados e retornar essas informações ao objeto dadosTabela.
        public DataTable Listar()
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método ListarPessoaFisica da classe ClientesAcessoDados e retornar essas informações ao objeto dadosTabela.
        public DataTable ListarPessoaFisica(int idCliente)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.ListarPessoaFisica(idCliente);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método ListarPessoaJuridica da classe ClientesAcessoDados e retornar essas informações ao objeto dadosTabela.
        public DataTable ListarPessoaJuridica(int idCliente)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.ListarPessoaJuridica(idCliente);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método Alterar da classe ClientesAcessoDados.
        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1,
                            string telefone2, string email, DateTime dataCadastro, DateTime nascimento, string observacoes)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Alterar(idCliente, nome, endereco, bairro, cep, cidade, estado, telefone1, telefone2, email, dataCadastro, nascimento, observacoes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método AlterarPessoaFisica da classe ClientesAcessoDados.
        public void AlterarPessoaFisica(int idCliente, string cpf, string rg)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.AlterarPessoaFisica(idCliente, cpf, rg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método AlterarPessoaJuridica da classe ClientesAcessoDados.
        public void AlterarPessoaJuridica(int idCliente, string cnpj, string ie)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.AlterarPessoaJuridica(idCliente, cnpj, ie);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método Excluir da classe ClientesAcessoDados, baseados pelo ID do cliente.
        public void Excluir(int idCliente)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Excluir(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método PesquisaNome da classe ClientesAcessoDados, baseados pelo nome do cliente e retornar essa informação ao objeto dadosTabela.
        public DataTable PesquisaNome(string nome)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisaNome(nome);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método PesquisaCpf da classe ClientesAcessoDados, baseados pelo CPF do cliente e retornar essa informação ao objeto dadosTabela.
        public DataTable PesquisaCpf(string cpf)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisaCpf(cpf);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método PesquisaCnpj da classe ClientesAcessoDados, baseados pelo CNPJ do cliente e retornar essa informação ao objeto dadosTabela.
        public DataTable PesquisaCnpj(string cnpj)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisaCnpj(cnpj);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
