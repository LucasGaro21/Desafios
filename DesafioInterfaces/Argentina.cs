using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Argentina : SeleccionesAmerica,IcampeonMundial
    {
        public void Campeon()
        {

            Console.WriteLine("\n Argentina fue Campeon del Mundo en 1978 y 1986.");
        }
    }
}
