using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class CriaBancoRegraNegocio
    {
        AcessoDados.CriaBancoAcessoDados novoBanco;

        //Método cuja função é chamar o método VerificarBanco da classe CriaBancoAcessoDados.
        public DataTable VerificarBanco()
        {
            try
            {
                novoBanco = new AcessoDados.CriaBancoAcessoDados();
                return novoBanco.VerificarBanco();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*Método que realiza a busca dos caminhos dos scripts que possuem as instruções para a elaboração do banco e suas tabelas, 
         * faz a retirada do comando GO dentro deles e, por fim, chama o método CriarBanco da classe CriaBancoAcessoDados.*/
        public void CriarBanco()
        {
            try
            {
                string caminhoScriptBanco = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resources\ScriptBancoConstrucao.sql";

                FileInfo arquivoBanco = new FileInfo(caminhoScriptBanco);
                string scriptBancoAjustado = arquivoBanco.OpenText().ReadToEnd().Replace("GO", "");

                string caminhoScriptTabelas = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resources\ScriptTabelasConstrucao.sql";

                FileInfo arquivoTabelas = new FileInfo(caminhoScriptTabelas);
                string scriptTabelasAjustado = arquivoTabelas.OpenText().ReadToEnd().Replace("GO", "").Replace("CAR", "CARGO").Replace("Car", "Cargo").Replace("CATERIA", "CATEGORIA").Replace("Cateria", "Categoria").Replace("CODI", "CODIGO");

                novoBanco = new AcessoDados.CriaBancoAcessoDados();
                novoBanco.CriarBanco(scriptBancoAjustado, scriptTabelasAjustado);
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }

        //Método cuja função é chamar o método CriarUsuario da classe CriaBancoAcessoDados.
        public void CriarUsuario()
        {
            try
            {
                novoBanco = new AcessoDados.CriaBancoAcessoDados();
                novoBanco.CriarUsuario();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método cuja função é chamar o método CriarNiveis da classe CriaBancoAcessoDados.
        public void CriarNiveis()
        {
            try
            {
                novoBanco = new AcessoDados.CriaBancoAcessoDados();
                novoBanco.CriarNiveis();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
