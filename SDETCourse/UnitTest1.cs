using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDETCourse.HUMANO;
using System;

namespace SDETCourse
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Acciones accion = new Acciones();
            Acciones2 accion2 = new Acciones2();
          

            Console.WriteLine(accion.Bombear(2));
            Console.WriteLine(accion2.Bombear(2));
            Console.WriteLine(accion.getProtein());
          
        }
    }
}
