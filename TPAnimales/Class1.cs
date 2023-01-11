using System.Security.Cryptography.X509Certificates;

namespace TPAnimales
{
    public abstract class Animal
    {

        public int Edad { get; }
        public float Altura { get; }
        public float Peso { get; }

        public Animal(int edad, float altura, float peso)
        {
            Edad = edad;
            Altura = altura;
            Peso = peso;

        }

        public virtual string Imprimir()
        {
            return "Edad: " + Edad + " Altura: " + Altura + " Peso: " + Peso;
        }

        public abstract string ImprimirComida();
    }
}