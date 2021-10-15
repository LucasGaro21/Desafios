using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            HistorialMundialFutbol historia = new HistorialMundialFutbol();
            historia.IniciarHistorial();
            Console.ReadKey();
        }
    }
}
