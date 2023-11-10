
##testandos
*comando git push
## Salvadno alteracoes no git
##testando denovod
#comando git pull
#comando git fetch
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileStream_CriarArquivo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            FileStream fs = new FileStream ("C:\\Users\\Sala\\Documents\\C#", FileMode.Create , FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Ola, eu sei escrever um arquivo..");
fs.Write(bdata, 0, bdata.Length);
            fs.Close();
            Console.Write("O arquivo foi criado com sucesso:");
            Console.ReadKey();
        }
    }
}
