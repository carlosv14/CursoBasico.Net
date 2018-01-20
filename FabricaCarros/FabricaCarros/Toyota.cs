using System;

namespace FabricaCarros
{
    internal class Toyota : Carro
    {
        public Toyota(string color)
        {
            this.Color = color;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Marca: Toyota, Color: {this.Color}");
        }
    }
}