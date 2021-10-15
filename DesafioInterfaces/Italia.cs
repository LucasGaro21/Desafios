using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Italia : SeleccionesEuropa, IcampeonMundial
    {
        public void Campeon()
        {

            Console.WriteLine("\n Italia fue Campeon del Mundo en 1934, 1938, 1982 y 2006. ");
        }
    }
}
