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
            // Esta linha de código carrega dados dentro da tabela "ConstrucaoDataSet.Produtos". Você pode mover, ou removê-la, se necessário.
            this.ProdutosTableAdapter.Fill(this.ConstrucaoDataSet.Produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
