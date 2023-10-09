using System;

namespace InterfaceG2_2024_1
{
    internal class Refrigerador : LineaBlanca, IEncender
    {
        internal Refrigerador()
        {
            Marca = "";
            Console.WriteLine("Verificando si hay alimentacion");
        }
        void IEncender.Encender() // Implementacion explicita
        {
            Console.WriteLine("{0} te da la bienvenida", Marca);
        }
    }
}
