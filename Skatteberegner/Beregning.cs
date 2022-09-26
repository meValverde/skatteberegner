using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            var skat = 0.0;
            switch ((julegave,andenGave))
            {
                case(<=900, <=300):
                    break;
                case(>900, >=300):
                    skat = julegave + andenGave;
                    break;
                case(<=900, >300):
                    skat = andenGave;
                    break;
                default:
                    break;
            }

            return skat;
        }
    }
}
