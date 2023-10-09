using System;

namespace InterfaceG2_2024_1
{
    internal class Estufa : LineaBlanca, IEncender
    {
        internal Estufa()
        {
            Marca = "LG";
        }

        //Ctrl + Enter
        public void Encender()
        {
            Console.WriteLine("{0} Hola :)", Marca);
        }
    }
}
