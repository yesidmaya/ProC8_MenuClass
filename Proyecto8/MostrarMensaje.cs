using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class MostrarMensaje
    {
        string mensaje = String.Empty;

        public MostrarMensaje(string mensaje)
        {
            this.mensaje = mensaje;
        }
        
        public string dameMensaje()
        {
            return "ESTO FUE LO QUE ESCRIBI: " + mensaje;
        }
    }
}
