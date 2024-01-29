using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermedio.Programa3
{
    public class DadoGame
    {
        private Dado dado1;
        private Dado dado2;
        private Dado dado3;

        public DadoGame()
        {
            this.dado1 = new Dado();
            this.dado2 = new Dado();
            this.dado3 = new Dado();
        }

        public void Play()
        {
            Console.WriteLine("El juego de dados ha empezado!\n");

            Console.WriteLine($"Dado 1: {dado1.Valor}");
            Console.WriteLine($"Dado 2: {dado2.Valor}");
            Console.WriteLine($"Dado 3: {dado3.Valor}\n");

            if(dado1.Valor == dado2.Valor && dado2.Valor == dado3.Valor)
            {
                Console.WriteLine("Felicidades, has ganado!. Todos los dados tienen el mismo valor.");
            }
            else
            {
                Console.WriteLine("Ha perdido, los dados no tienen el mismo valor. Inténtelo nuevamente");
            }
        }
    }
}
