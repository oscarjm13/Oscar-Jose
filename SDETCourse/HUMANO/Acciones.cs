using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourse.HUMANO
{
    public class Acciones : Organos
    {
        internal void Respirar()
        {
            Pulmon();
            Console.WriteLine("Respirando Usando el Pulmon");
        }

        public override string Digerir(int vecesxSegundo)
        {
            return $"Bombear {vecesxSegundo}";

        }
         
        public override string Bombear(int vecesxMinutos)
        {
            return $"Bombea {vecesxMinutos * 2}";
        }

       
    }
}

 