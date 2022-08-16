using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1._1
{
    internal class veiculo
    {
        // Declaraçao de atributos 
        string marca;
        string modelo;
        string placa;
        int ano;
        // método para atribuir valores 

        public void atribuir
            (string ma,
            string mo, 
            string pl,
            int a)
        {
            this.ano = a;
            this.marca = ma;
            this.modelo = mo;
            this.placa = pl;
        }
        public string retorna()
        {
            return "Marca= " + this.marca +
                "\nModelo= " + this.modelo + 
                "\nAno de fabricaçao= " + this.ano +
                "\nPlaca= " + this.placa;
        }
    }
}
