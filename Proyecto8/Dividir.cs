using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class Dividir
    {
        int a, b;

        public Dividir( int a, int b) // cosntructor
        {
            this.a = a;
            this.b = b;
        }

        public double ResultadoDividir()
        {
            return (double)a / b;
        }
    }
}
