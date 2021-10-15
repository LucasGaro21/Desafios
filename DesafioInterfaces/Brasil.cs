using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Brasil : SeleccionesAmerica,IcampeonMundial
    {
        public void Campeon()
        {

            Console.WriteLine("\n Brasil fue Campeon del Mundo en 1958, 1962, 1970, 1994 y 2002.");
        }
    }
}
