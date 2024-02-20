using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    //Esta clase controla los métodos
    //de tiempo en segundos y minutos
    class HadaP1
    {
        //Este método cambia de segundos a minutos
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
            {
                return 0;
            }
            return s / 60;
        }

        //Este método cambia de minutos a segundos
        public static double Minutes2Seconds(double m)
        {
            if (m == 0)
            {
                return 0;
            }
            return m * 60;
        }

        //Este método cambia de horas a minutos
        public static double Hours2Minutes(double h)
        {
            if (h == 0)
            {
                return 0;
            }
            return h * 60;
        }

    }
}
