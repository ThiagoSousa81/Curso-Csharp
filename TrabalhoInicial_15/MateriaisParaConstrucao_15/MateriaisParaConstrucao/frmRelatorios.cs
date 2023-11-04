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
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ConstrucaoDataSet.Produtos' table. You can move, or remove it, as needed.
            this.ProdutosTableAdapter.Fill(this.ConstrucaoDataSet.Produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
