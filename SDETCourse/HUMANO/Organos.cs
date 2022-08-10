using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourse.HUMANO
{
    public abstract class Organos : GlobulosBlancos
    {
        internal void Pulmon()
        {

            Console.WriteLine("Usar Pulmon");
        }
        internal void Corazon()
        {
            Console.WriteLine("Usar Corazon");
        }
        
        internal void Estomago()
        {
            Console.WriteLine("Digerir");
        }

        internal void piernas()
        {
            Console.WriteLine("Mover pierna");
        }

        internal void brazos()
        {
            Console.WriteLine("Mover brazos");
        }
        public abstract string Digerir(int segundos);
        public abstract string Bombear(int segundos);
    
        }
    }
