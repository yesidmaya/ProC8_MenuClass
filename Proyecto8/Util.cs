using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class Util
    {
        public int ValidarNumero(string valor)
        {
            int numero = 0;

            try
            {
                numero = Convert.ToInt32(valor);
            }
            catch(Exception)
            {
                Console.WriteLine("Debe introducir un numero.");
                Console.ReadLine();
            }
            return numero;
        }
    }
}
