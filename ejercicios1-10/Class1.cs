using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicios1_10
{
    class Validaciones
    {
        public bool Vacio(string texto)
        {
            if (texto.Equals(""))
            {
                Console.WriteLine(" La entrada no puede ser VACIO");
                return true;
            }
            else
                return false;
        }

        public bool TipoNumero(string texto)
        {
            Regex regla = new Regex("[0-9]{1,9}(//.[0-9]{0,2})?$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada no debe ser NUMERICA");
                return false;
            }
        }

    }
}
