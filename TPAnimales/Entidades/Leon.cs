using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimales.Entidades
{
    public class Leon : Animal
    {
        public string Comida { get; }
        public string Melena { get; }

        public override string ImprimirComida()
        {
            return "Come: " + Comida;
        }

        public Leon(int edad, float altura, float peso, string comida, string melena) : base(edad, altura, peso)
        {
            Comida = comida;
            Melena = melena;
        }

        public override string Imprimir()
        {
            return "Edad: " + Edad + " Altura: " + Altura + " Peso: " + Peso + " Melena: " + Melena;
        }
    }
}
