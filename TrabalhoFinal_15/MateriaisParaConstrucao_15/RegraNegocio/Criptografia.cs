using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class Criptografia
    {
        //Método que cria a criptografia do conteúdo da senha contida no parâmetro.
        public string Criptografar(string senha)
        {
            MD5 hashMd5 = MD5.Create(); //Primeiramente, instancia-se a classe MD5. 

            byte[] valorCriptografado = hashMd5.ComputeHash(Encoding.Default.GetBytes(senha)); //Depois, cria-se uma variável do tipo byte para codificar a senha informada pelo usuário em números binários e os converte para MD5.

            StringBuilder strBuilder = new StringBuilder(); //Em seguida, instancia-se a classe StringBuilder para utilizar o seu objeto para armazenar o valor criptografado.

            //Através do laço de repetição o conteúdo do objeto strBuilder será percorrido, para deixar a sua extensão no formato hexagonal x2 e ficar com o tamanho total de 32 caracteres.
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("x2"));
            }

            return strBuilder.ToString();//Por fim, o objeto retornará o resultado armazenado, transformando-o em string.
        }
    }
}
