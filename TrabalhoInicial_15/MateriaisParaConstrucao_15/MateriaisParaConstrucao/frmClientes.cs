using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmClientes : Form
    {
        RegraNegocio.ClientesRegraNegocio novoCliente;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            //Se verificado que o RadionButton rbPessoaFisica está selecionado,
            if (rbPessoaFisica.Checked == true)
            {
                //o GroupBox dos documentos da pessoa física fica visível e da jurídica invisível.
                gbDocumentosPessoaFisica.Visible = true;
                gbDocumentosPessoaJuridica.Visible = false;
            }
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            //Se verificado que o RadionButton rbPessoaJuridica está selecionado,
            if (rbPessoaJuridica.Checked == true)
            {
                //o GroupBox dos documentos da pessoa jurídica fica visível e da física invisível.
                gbDocumentosPessoaJuridica.Visible = true;
                gbDocumentosPessoaFisica.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoCliente = new RegraNegocio.ClientesRegraNegocio();
                
                //Se a caixa de texto que recebe o código do cliente estiver com o valor 0,
                if (txtRegistro.Text == "0")
                {
                    //verifica se o RadioButton referente à pessoa física está selecionado.
                    if (rbPessoaFisica.Checked == true)
                    {
                        //Se sim, realiza a ação de salvar os dados na tabela Cliente.
                        novoCliente.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text,
                                           txtEstado.Text, txtTelefone1.Text, txtTelefone2.Text, txtEmail.Text,
                                           dtpDataCadastro.Value.Date, dtpNascimento.Value.Date, txtObservacao.Text);

                        //Depois, lista todos os clientes da tabela, tendo como base o id deles,
                        DataTable dadosTabela = new DataTable();
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        dadosTabela = novoCliente.Listar();

                        //em seguida, salva os dados referentes ao RG e CPF na tabela Pessoa_fisica.
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.SalvarPessoaFísica(Convert.ToInt32(dadosTabela.Rows[0]["ID_CLIENTE"]), txtCpf.Text, txtRg.Text);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        /*Se não, é o RadioButton referente à pessoa jurídica que está selecionado e realiza a ação salvar os dados
                         * na tabela Cliente.*/
                        novoCliente.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text,
                                           txtEstado.Text, txtTelefone1.Text, txtTelefone2.Text, txtEmail.Text,
                                           dtpDataCadastro.Value.Date, dtpNascimento.Value.Date, txtObservacao.Text);

                        //Depois, lista todos os clientes da tabela, tendo como base o id deles,
                        DataTable dadosTabela = new DataTable();
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        dadosTabela = novoCliente.Listar();
                        
                        //em seguida, salva os dados referentes ao IE e CNPJ na tabela Pessoa_juridica.
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.SalvarPessoaJuridica(Convert.ToInt32(dadosTabela.Rows[0]["ID_CLIENTE"]), txtCnpj.Text, txtIe.Text);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Se não, se o código for diferente de 0 e o RadioButton referente à pessoa física estiver selecionado,
                    if (rbPessoaFisica.Checked == true)
                    {
                        //realizará o método Alterar e AlterarPessoaFisica, para as tabelas Cliente e Pessoa_fisica receberem as mudanças.
                        novoCliente.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, 
                                            txtCidade.Text, txtEstado.Text, txtTelefone1.Text, txtTelefone2.Text, txtEmail.Text, 
                                            dtpDataCadastro.Value.Date, dtpNascimento.Value.Date, txtObservacao.Text);
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.AlterarPessoaFisica(Convert.ToInt32(txtRegistro.Text), txtCpf.Text, txtRg.Text);
                        MessageBox.Show("Cliente alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //senão significa que o rbPessoaJuridica está selecionado e realiza os métodos Alterar e AlterarPessoaJuridica.
                        novoCliente.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text,
                                            txtCidade.Text, txtEstado.Text, txtTelefone1.Text, txtTelefone2.Text, txtEmail.Text, 
                                            dtpDataCadastro.Value.Date, dtpNascimento.Value.Date, txtObservacao.Text);
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.AlterarPessoaJuridica(Convert.ToInt32(txtRegistro.Text), txtCnpj.Text, txtIe.Text);
                        MessageBox.Show("Cliente alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ListarClientes();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtRegistro.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            dtpNascimento.Value = DateTime.Today;
            txtObservacao.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtCnpj.Clear();
            txtIe.Clear();
            txtTelefone1.Clear();
            txtTelefone2.Clear();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgClientes.Rows.Count; i += 2)
            {
                dtgClientes.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Primeiro verifica se possui informações mostradas no DataGridView.
            if (e.RowIndex >= 0)
            {
                //Se sim, verifica se a coluna clicada foi referente ao btnEditar.
                if (dtgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Se a condição for verdadeira, cada componente do formulário receberá as informações do DataGrid correspondentes a eles.
                    txtRegistro.Text = dtgClientes.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value.ToString();
                    txtNome.Text = dtgClientes.Rows[e.RowIndex].Cells["NOME_CLIENTE"].Value.ToString();
                    txtEndereco.Text = dtgClientes.Rows[e.RowIndex].Cells["ENDERECO_CLIENTE"].Value.ToString();
                    txtBairro.Text = dtgClientes.Rows[e.RowIndex].Cells["BAIRRO_CLIENTE"].Value.ToString();
                    txtCep.Text = dtgClientes.Rows[e.RowIndex].Cells["CEP_CLIENTE"].Value.ToString();
                    txtCidade.Text = dtgClientes.Rows[e.RowIndex].Cells["CIDADE_CLIENTE"].Value.ToString();
                    txtEstado.Text = dtgClientes.Rows[e.RowIndex].Cells["ESTADO_CLIENTE"].Value.ToString();
                    txtTelefone1.Text = dtgClientes.Rows[e.RowIndex].Cells["TELEFONE1_CLIENTE"].Value.ToString();
                    txtTelefone2.Text = dtgClientes.Rows[e.RowIndex].Cells["TELEFONE2_CLIENTE"].Value.ToString();
                    txtEmail.Text = dtgClientes.Rows[e.RowIndex].Cells["EMAIL_CLIENTE"].Value.ToString();
                    dtpDataCadastro.Value = Convert.ToDateTime(dtgClientes.Rows[e.RowIndex].Cells["DATA_CADASTRO_CLIENTE"].Value.ToString());
                    dtpNascimento.Value = Convert.ToDateTime(dtgClientes.Rows[e.RowIndex].Cells["NASCIMENTO_CLIENTE"].Value.ToString());
                    txtObservacao.Text = dtgClientes.Rows[e.RowIndex].Cells["OBSERVACOES_CLIENTE"].Value.ToString();

                    //Depois, realiza a listagem dos clientes de pessoa física, baseado no ID deles.
                    DataTable dadosTabela = new DataTable();
                    novoCliente = new RegraNegocio.ClientesRegraNegocio();
                    dadosTabela = novoCliente.ListarPessoaFisica(Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value));

                    // E, se a contagem das linhas for maior que 0, significando que o cliente é uma pessoa física,
                    if (dadosTabela.Rows.Count > 0)
                    {
                        //os componentes referentes ao CPF e RG recebem estes valores do DataGrid,
                        txtCpf.Text = dadosTabela.Rows[0]["CPF_CLIENTE"].ToString();
                        txtRg.Text = dadosTabela.Rows[0]["RG_CLIENTE"].ToString();

                        //e deixa o GroupBox referente à pessoa física visível e o jurídico invisível.
                        gbDocumentosPessoaFisica.Visible = true;
                        gbDocumentosPessoaJuridica.Visible = false;
                    }
                    else
                    {
                        /*Se não, é pessoa jurídica e realiza o processo de listar os clientes desse tipo baseado por seu ID,
                         * no qual os componentes referentes ao CNPJ e IE recebem os valores do DataGrid e deixa visível o 
                           GroupBox referente à pessoa jurídica e a física invisível.*/
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        dadosTabela = novoCliente.ListarPessoaJuridica(Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value));

                        txtCnpj.Text = dadosTabela.Rows[0]["CNPJ_CLIENTE"].ToString();
                        txtIe.Text = dadosTabela.Rows[0]["IE_CLIENTE"].ToString();

                        gbDocumentosPessoaJuridica.Visible = true;
                        gbDocumentosPessoaFisica.Visible = false;
                    }
                }
                else
                {
                    //Caso o clique não foi no btnEditar, verifica se foi no btExcluir e se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
                    if (dtgClientes.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                        MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            //Se sim, realiza o método Excluir, mostra mensagem do sucesso dessa ação, lista os clientes no DataGrid e limpa todos os campos.
                            novoCliente = new RegraNegocio.ClientesRegraNegocio();
                            novoCliente.Excluir(Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value));
                            MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarClientes();
                            Limpar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }        

        private void ListarClientes()
        {
            try
            {
                novoCliente = new RegraNegocio.ClientesRegraNegocio();
                dtgClientes.DataSource = novoCliente.Listar();

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            /*Realiza a pesquisa das informações do DataGrid de acordo com o RadioButton selecionado,
              chamando os seus respectivos métodos.*/
            novoCliente = new RegraNegocio.ClientesRegraNegocio();

            try
            {
                if (rbNome.Checked)
                {
                    dtgClientes.DataSource = novoCliente.PesquisaNome(txtPesquisa.Text);
                }
                else if (rbCpf.Checked)
                {
                    dtgClientes.DataSource = novoCliente.PesquisaCpf(txtPesquisa.Text);
                }
                else if (rbCnpj.Checked)
                {
                    dtgClientes.DataSource = novoCliente.PesquisaCnpj(txtPesquisa.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}