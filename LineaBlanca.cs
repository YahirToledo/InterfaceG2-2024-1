using System;

namespace InterfaceG2_2024_1
{
    internal abstract class LineaBlanca
    {
        private string marca;

        public string Marca { get => marca;
            set => marca = value == "" ? "Generica" : value; }
    }
}
