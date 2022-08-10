using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SDETCourse.HUMANO
{
     class Acciones2 : Organos
    {
        public override string Bombear(int vecesxMinutos)
        {
            return $"Bombea {vecesxMinutos * 2}";
        }

        public override string Digerir(int segundos)
    
        {
                return $"Digerir {segundos * 2}";
            }
        }
    }
