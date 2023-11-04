using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            pbBarra.Increment(1);

            if (pbBarra.Value == 100)
            {
                relogio.Stop();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            for (double i = 0; i <= 1; i += 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                Thread.Sleep(15);
            }
        }
    }
}
