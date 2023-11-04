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
