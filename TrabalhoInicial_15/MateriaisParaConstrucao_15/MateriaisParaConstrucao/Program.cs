using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                RegraNegocio.CriaBancoRegraNegocio novoBanco = new RegraNegocio.CriaBancoRegraNegocio();
                DataTable dadosTabela = new DataTable();

                Thread novaThread = new Thread(new ThreadStart(novoFrmSplash));
                novaThread.Start();
                dadosTabela = novoBanco.VerificarBanco();

                Thread.Sleep(5700);
                novaThread.Abort();

                frmLogin formularioLogin = new frmLogin();
                formularioLogin.ShowDialog();

                if (formularioLogin.DialogResult == DialogResult.OK)
                {
                    Application.Run(new frmPrincipal(formularioLogin.idUsuario));
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        static void novoFrmSplash()
        {
            Application.Run(new frmSplash());
        }
    }
}
