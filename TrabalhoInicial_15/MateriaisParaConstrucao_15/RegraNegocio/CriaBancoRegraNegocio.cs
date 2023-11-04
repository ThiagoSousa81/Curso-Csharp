using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class CriaBancoRegraNegocio
    {
        AcessoDados.CriaBancoAcessoDados novoBanco;

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
    }
}
