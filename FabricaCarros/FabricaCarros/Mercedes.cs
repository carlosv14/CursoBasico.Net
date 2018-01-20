using System;

namespace FabricaCarros
{
    internal class Mercedes : Carro
    {

        public Mercedes(string color)
        {
            this.Color = color;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Marca: Mercedes, Color: {this.Color}");
        }
    }
}