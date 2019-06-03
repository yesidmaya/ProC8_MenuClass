using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class FIbonacci
    {
        int num1 = 0;
        int num2 = 0;

        public FIbonacci()
        {

        }

        public FIbonacci(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

         public string calcular(int numero)
         {
            string mostrar = String.Empty;
            int resultado = 0;
            while (resultado <= numero)
            {
                resultado = num1 + num2;
                num1 = num2;
                num2 = resultado;
                mostrar += " " + resultado;
            }
            return mostrar;
         }
    }
}
