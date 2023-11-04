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
    public partial class frmFuncionarios : Form
    {
        RegraNegocio.FuncionariosRegraNegocio novoFuncionario;

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Evento do botão Salvar o qual grava as informações através do método Salvar ou Alterar, criado na classe Funcionarios.
            try
            {
                novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();

                if (txtRegistro.Text == "0")
                {
                    novoFuncionario.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtEmail.Text,
                       dtpNascimento.Value.Date, txtTelefone1.Text, txtTelefone2.Text, txtRg.Text, txtCpf.Text,
                       txtObservacao.Text, dtpDataCadastro.Value.Date);
                     MessageBox.Show("Funcionário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoFuncionario.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text,
                                       txtEmail.Text, dtpNascimento.Value.Date, txtTelefone1.Text, txtTelefone2.Text, txtRg.Text, txtCpf.Text,
                                       txtObservacao.Text, dtpDataCadastro.Value.Date);
                    MessageBox.Show("Funcionário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                ListarFuncionarios();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //Método responsável por limpar os componentes do formulário.
        private void Limpar()
        {
            txtRegistro.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            dtpNascimento.Value = DateTime.Today;
            txtObservacao.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtTelefone1.Clear();
            txtTelefone2.Clear();
        }

        //Método que realiza o intervalo de cores dentro do DataGriView.
        private void Estilo()
        {
            for (int i = 0; i < dtgFuncionarios.Rows.Count; i += 2)
            {
                dtgFuncionarios.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        //Método que lista os dados da tabela Funcionarios no DataGridView.
        private void ListarFuncionarios()
        {
            novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
            dtgFuncionarios.DataSource = novoFuncionario.Listar();
            Estilo();
        }

        //Método que será executado quando o frmFuncionario for carregado.
        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            ListarFuncionarios();
        }

        //Evento que detecta a célula clicada dentro do dtgFuncionarios.
        private void dtgFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Primeiro verificará se há linhas, ou seja, registros no DataGridView.
            if (e.RowIndex >= 0)
            {
                //Se houver linhas, a próxima verificação é se a coluna btnEditar foi clicada.
                if (dtgFuncionarios.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Se isso for verdade, atribui a todos o campos do formulário os respectivos conteúdos do banco sobre o funcionário clicado. 
                    txtRegistro.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["ID_FUNCIONARIO"].Value.ToString();
                    txtNome.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["NOME_FUNCIONARIO"].Value.ToString();
                    txtEndereco.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["ENDERECO_FUNCIONARIO"].Value.ToString();
                    txtBairro.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["BAIRRO_FUNCIONARIO"].Value.ToString();
                    txtCep.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["CEP_FUNCIONARIO"].Value.ToString();
                    txtCidade.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["CIDADE_FUNCIONARIO"].Value.ToString();
                    txtEmail.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["EMAIL_FUNCIONARIO"].Value.ToString();
                    dtpNascimento.Value = Convert.ToDateTime(dtgFuncionarios.Rows[e.RowIndex].Cells["NASCIMENTO_FUNCIONARIO"].Value.ToString());
                    txtTelefone1.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["TELEFONE1_FUNCIONARIO"].Value.ToString();
                    txtTelefone2.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["TELEFONE2_FUNCIONARIO"].Value.ToString();
                    txtRg.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["RG_FUNCIONARIO"].Value.ToString();
                    txtCpf.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["CPF_FUNCIONARIO"].Value.ToString();
                    dtpDataCadastro.Value = Convert.ToDateTime(dtgFuncionarios.Rows[e.RowIndex].Cells["DATA_CADASTRO_FUNCIONARIO"].Value.ToString());
                    txtObservacao.Text = dtgFuncionarios.Rows[e.RowIndex].Cells["OBSERVACOES_FUNCIONARIO"].Value.ToString();
                }
                else
                {
                    //Se não, verifica se o nome da coluna que recebeu o clique é btnExcluir e se o botão que foi clicado na caixa de mensagem é o Yes.
                    if (dtgFuncionarios.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            //Se essas duas condições forem atendidas, acessa o método Excluir da classe Funcionarios, excluindo os registros, tendo como base a coluna ID_FUNCIONARIO.
                            novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                            novoFuncionario.Excluir(Convert.ToInt32(dtgFuncionarios.Rows[e.RowIndex].Cells["ID_FUNCIONARIO"].Value));
                            MessageBox.Show("Funcionario excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarFuncionarios();
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            /* Evento do txtPesquisa, o qual verifica se desejamos pesquisar por nome ou CPF
             * e exibe os resultados de acordo com o que for digitado nele. */
            novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();

            try
            {
                if (rbNome.Checked)
                {
                    dtgFuncionarios.DataSource = novoFuncionario.PesquisarNome(txtPesquisa.Text);
                }
                else
                {
                    dtgFuncionarios.DataSource = novoFuncionario.PesquisarCpf(txtPesquisa.Text);
                }
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
    }
}
