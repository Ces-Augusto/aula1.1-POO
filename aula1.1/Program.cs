using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciaçao do objeto
            veiculo golf = new veiculo();
            
            Console.WriteLine("Digite a marca");
            string marca = Console.ReadLine();
           
            Console.WriteLine("Digite o modelo");
            string modelo = Console.ReadLine();
           
            Console.WriteLine("Digite a placa");
            string placa = Console.ReadLine();
           
            Console.WriteLine("Digite o ano de fabricaçao");
            int ano = Convert.ToInt32(Console.ReadLine());
            
            //objeto chamanod método atribuir
            golf.atribuir(marca, modelo, placa, ano);
            
        }
    }
}
