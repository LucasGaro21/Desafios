using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class HistorialMundialFutbol
    {
        List<IcampeonMundial> campeones = new List<IcampeonMundial>();

        public HistorialMundialFutbol()
        {
            Alemania alemania = new Alemania();
            campeones.Add(alemania);

            Argentina argentina = new Argentina();
            campeones.Add(argentina);

            Brasil brasil = new Brasil();
            campeones.Add(brasil);

            Italia italia = new Italia();
            campeones.Add(italia);

        }
        public void IniciarHistorial() 
        {
            foreach(IcampeonMundial c in campeones)
            {
                c.Campeon();
            }
        }
    }
}
