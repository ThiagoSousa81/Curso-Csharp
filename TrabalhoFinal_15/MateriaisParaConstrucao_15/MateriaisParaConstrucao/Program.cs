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

                /*A Thread carregará o frmSplash e junto nesse processo será realizado a verificação 
                 * se o banco do projeto existe na máquina em que está sendo executado. */
                Thread novaThread = new Thread(new ThreadStart(novoFrmSplash));
                novaThread.Start();
                dadosTabela = novoBanco.VerificarBanco();

                Thread.Sleep(5700);

                //E, se o retorno da verificação for que a máquina não possui a base de dados será criado o banco, os níveis e o usuário padrão.
                if (dadosTabela.Rows.Count <= 0)
                {
                    novoBanco.CriarBanco();
                    novoBanco.CriarNiveis();
                    novoBanco.CriarUsuario();
                }
                novaThread.Abort(); //Cancela a Thread após o tempo estipulado.

                frmLogin formularioLogin = new frmLogin();
                formularioLogin.ShowDialog(); //Carrega o formulário frmLogin.

               //Se o resultado do dados do login estiverem certos, o formulário frmPrincipal será carregado.
                if (formularioLogin.DialogResult == DialogResult.OK)
                {
                    Application.Run(new frmPrincipal(formularioLogin.idUsuario));
                }
                else //Caso contrário, a aplicação será finalizada.
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para acesso ao frmSplash.
        static void novoFrmSplash()
        {
            Application.Run(new frmSplash());
        }
    }
}
