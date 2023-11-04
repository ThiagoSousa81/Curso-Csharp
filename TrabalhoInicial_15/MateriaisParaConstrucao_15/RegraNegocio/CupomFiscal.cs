using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class CupomFiscal
    {
        // Função para analisar o retorno da impressora.
        public static void Analisa_RetornoImpressora()
        {
            int ACK, ST1, ST2;
            string Erros = "";
            ACK = ST1 = ST2 = 0;

            Bematech_FI_RetornoImpressora(ref ACK, ref ST1, ref ST2);

            //Tratando o ST1
            if (ST1 >= 128)
            {
                ST1 = ST1 - 128;
                Erros += "BIT 7 - Fim de Papel" + '\x0D';
            }
            if (ST1 >= 64)
            {
                ST1 = ST1 - 64;
                Erros += "BIT 6 - Pouco Papel" + '\x0D';
            }
            if (ST1 >= 32)
            {
                ST1 = ST1 - 32;
                Erros += "BIT 5 - Erro no Relógio" + '\x0D';
            }
            if (ST1 >= 16)
            {
                ST1 = ST1 - 16;
                Erros += "BIT 4 - Impressora em ERRO" + '\x0D';
            }
            if (ST1 >= 8)
            {
                ST1 = ST1 - 8;
                Erros += "BIT 3 - CMD não iniciado com ESC" + '\x0D';
            }
            if (ST1 >= 4)
            {
                ST1 = ST1 - 4;
                Erros += "BIT 2 - Comando Inexistente" + '\x0D';
            }
            if (ST1 >= 2)
            {
                ST1 = ST1 - 2;
                Erros += "BIT 1 - Cupom Aberto" + '\x0D';
            }
            if (ST1 >= 1)
            {
                ST1 = ST1 - 1;
                Erros += "BIT 0 - Nº de Parâmetros Inválidos" + '\x0D';
            }

            //Tratando o ST2
            if (ST2 >= 128)
            {
                ST2 = ST2 - 128;
                Erros += "BIT 7 - Tipo de Parâmetro Inválido" + '\x0D';
            }
            if (ST2 >= 64)
            {
                ST2 = ST2 - 64;
                Erros += "BIT 6 - Memória Fiscal Lotada" + '\x0D';
            }
            if (ST2 >= 32)
            {
                ST2 = ST2 - 32;
                Erros += "BIT 5 - CMOS não Volátil" + '\x0D';
            }
            if (ST2 >= 16)
            {
                ST2 = ST2 - 16;
                Erros += "BIT 4 - Alíquota Não Programada" + '\x0D';
            }
            if (ST2 >= 8)
            {
                ST2 = ST2 - 8;
                Erros += "BIT 3 - Alíquotas lotadas" + '\x0D';
            }
            if (ST2 >= 4)
            {
                ST2 = ST2 - 4;
                Erros += "BIT 2 - Cancelamento ñ Permitido" + '\x0D';
            }
            if (ST2 >= 2)
            {
                ST2 = ST2 - 2;
                Erros += "BIT 1 - CGC/IE não Programados" + '\x0D';
            }
            if (ST2 >= 1)
            {
                ST2 = ST2 - 1;
                Erros += "BIT 0 - Comando não Executado" + '\x0D';
            }

            if (Erros.Length != 0)
                throw new Exception(Erros);
        }

        public static void Analisa_iRetorno(int IRetorno)
        {
            string mensagem = "";

            switch (IRetorno)
            {
                case 0:
                    mensagem = "Erro de Comunicação !";
                    break;

                case -1:
                    mensagem = "Erro de Execução na Função. Verifique!";
                    break;

                case -2:
                    mensagem = "Parâmetro Inválido !";
                    break;

                case -3:
                    mensagem = "Alíquota não programada !";
                    break;

                case -4:
                    mensagem = "Arquivo BemaFI32.INI não encontrado. Verifique!";
                    break;

                case -5:
                    mensagem = "Erro ao Abrir a Porta de Comunicação";
                    break;

                case -6:
                    mensagem = "Impressora Desligada ou Desconectada.";
                    break;

                case -7:
                    mensagem = "Banco Não Cadastrado no Arquivo BemaFI32.ini";
                    break;

                case -8:
                    mensagem = "Erro ao Criar ou Gravar no Arquivo Retorno.txt ou Status.txt.";
                    break;

                case -18:
                    mensagem = "Não foi possível abrir arquivo INTPOS.001!";
                    break;

                case -19:
                    mensagem = "Parâmetros diferentes!";
                    break;

                case -20:
                    mensagem = "Transação cancelada pelo Operador!";
                    break;

                case -21:
                    mensagem = "A Transação não foi aprovada!";
                    break;

                case -22:
                    mensagem = "Não foi possível terminar a Impressão!";
                    break;

                case -23: mensagem = "Não foi possível terminar a Operação!";
                    break;

                case -24: mensagem = "Não foi possível terminar a Operação!";
                    break;

                case -25: mensagem = "Totalizador não fiscal não programado.";
                    break;

                case -26: mensagem = "Transação já Efetuada!";
                    break;

                case -27: Analisa_RetornoImpressora();
                    break;

                case -28: mensagem = "Não há Informações para serem Impressas!";
                    break;
            }

            if (mensagem.Length != 0)
                throw new Exception(mensagem);

        }

        //Cupom Fiscal
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_AbreCupom(string CGC_CPF);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_VendeItem(string Codigo, string Descricao, string Aliquota, string TipoQuantidade, string Quantidade, int CasasDecimais, string ValorUnitario, string TipoDesconto, string Desconto);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_IniciaFechamentoCupom(string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_EfetuaFormaPagamento(string FormaPagamento, string ValorFormaPagamento);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_TerminaFechamentoCupom(string mensagem);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_FechaCupom(string FormaPagamento, string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto, string ValorPago, string Mensagem);

        //Impressora
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_RetornoImpressora(ref int ACK, ref int ST1, ref int ST2);

        //Relatórios Fiscais
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_LeituraX();
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_ReducaoZ(string Data, string Hora);
    }
}
