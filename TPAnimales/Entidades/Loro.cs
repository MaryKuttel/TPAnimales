using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimales.Entidades
{
    public class Loro : Animal
    {
        public string Comida {get; }
        public string Plumaje { get; }

        public override string ImprimirComida()
        {
            return "Come: " + Comida;
        }

        public Loro(int edad, float altura, float peso, string comida, string plumaje) : base(edad, altura, peso)
        {
            Comida = comida;
            Plumaje = plumaje;

        }

        public override string Imprimir()
        {
            return "Edad: " + Edad + " Altura: " + Altura + " Peso: " + Peso + " Plumaje: " + Plumaje;
        }
    }
}
