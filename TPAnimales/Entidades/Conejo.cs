using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimales.Entidades
{
    public class Conejo : Animal
    {
        public string Comida { get; }
        public string Pelaje { get; }

        public override string ImprimirComida()
        {
            return "Come: " + Comida;
        }

        public Conejo(int edad, float altura, float peso, string comida, string pelaje) : base(edad, altura, peso)
        {
            Comida = comida;
            Pelaje = pelaje;
        }

        public override string Imprimir()
        {
            return "Edad: " + Edad + " Altura: " + Altura + " Peso: " + Peso + " Pelaje: " + Pelaje;
        }
    }
}
