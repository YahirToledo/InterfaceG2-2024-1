using System;

namespace InterfaceG2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////// Forma Explicita ///////////////////
            Refrigerador miRefrigerador = new Refrigerador();
            IEncender encender = miRefrigerador; // Explicita
            encender.Encender();
            ///////////////////////////////////////////////////

            /////////////// Forma Implicita ///////////////////
            Estufa miEstufa = new Estufa();
            miEstufa.Encender();
            ///////////////////////////////////////////////////

            Console.ReadLine();
        }
    }
}
