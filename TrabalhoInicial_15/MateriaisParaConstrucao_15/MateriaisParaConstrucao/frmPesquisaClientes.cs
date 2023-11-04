using MateriaisParaConstrucao;
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
    public partial class frmPesquisaClientes : Form
    {
        RegraNegocio.ClientesRegraNegocio novoCliente;
        frmVendas formularioVendas;


        public frmPesquisaClientes(frmVendas formularioVendas)
        {
            InitializeComponent();
            this.formularioVendas = formularioVendas;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                novoCliente = new RegraNegocio.ClientesRegraNegocio();

                if (rbCnpj.Checked)
                {
                    dtgClientes.DataSource = novoCliente.PesquisaCnpj(txtPesquisa.Text);
                }
                else
                {
                    dtgClientes.DataSource = novoCliente.PesquisaCpf(txtPesquisa.Text);
                }

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Estilo()
        {
            for (int i = 0; i < dtgClientes.Rows.Count; i += 2)
            {
                dtgClientes.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
        }


        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            formularioVendas.idCliente = Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value);
            formularioVendas.lblNomeCliente.Text = dtgClientes.Rows[e.RowIndex].Cells["NOME_CLIENTE"].Value.ToString();

            if (dtgClientes.Rows[e.RowIndex].Cells["CPF"].Value == null)
            {
                formularioVendas.cpfCliente = "";
            }
            else
            {
                formularioVendas.cpfCliente = dtgClientes.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                formularioVendas.documentoCliente = Convert.ToString(formularioVendas.cpfCliente);
            }

            if (dtgClientes.Rows[e.RowIndex].Cells["CNPJ"].Value == null)
            {
                formularioVendas.cnpjCliente = "";
            }
            else
            {
                formularioVendas.cnpjCliente = dtgClientes.Rows[e.RowIndex].Cells["CNPJ"].Value.ToString();
                formularioVendas.documentoCliente = Convert.ToString(formularioVendas.cnpjCliente);
            }
            
            this.Close();
        }
    }
}
