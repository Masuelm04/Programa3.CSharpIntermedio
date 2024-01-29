using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermedio.Programa3
{
    public class Dado
    {
        private int valor;
        private Random random;
        public int Valor
        {
            get { return valor; }
        }

        public Dado()
        {
            this.random = new Random();
            LanzarDado();
        }
        public void LanzarDado()
        {
            valor = random.Next(1, 7);
        }
    }
}
