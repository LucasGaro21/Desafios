using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Alemania : SeleccionesEuropa, IcampeonMundial
    {
        public void Campeon(){

            Console.WriteLine(" Alemania fue Campeon del Mundo en 1954, 1974, 1990 y 2014. ");
        }
    }
}
