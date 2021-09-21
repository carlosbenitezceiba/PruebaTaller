using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectoPruebasDummie
{
    [TestClass]
    public class ClasePruebasDummie
    {
        [TestMethod]
        public void Metodo1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Metodo2()
        {
            Assert.IsFalse(false);
        }

    }
}
