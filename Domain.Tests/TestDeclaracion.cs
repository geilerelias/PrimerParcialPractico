using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain.Tests
{
    [TestFixture]
    public class TestDeclaracion
    {

        [Test]
        public void TestDeclararMayorACeroSinEmplazamiento()
        {
            // TODO: Add your test code here

            var fechaDeclaracion = DateTime.Parse("01/05/2018 8:34:01");
            var fechaDeclarar = DateTime.Parse("13/05/2018 8:34:01");
            var valor = 1000000;
            Declaracion declaracion = new Declaracion(valor, fechaDeclarar, fechaDeclaracion, false);
            Assert.AreEqual("Sanción por extemporaneidad: 600000,00", declaracion.LiquidarSancion());
        }

        [Test]
        public void ValorMayorACeroConEmplazamiento()
        {

            var fechaDeclaracion = DateTime.Parse("01/05/2018 8:34:01");
            var fechaDeclarar = DateTime.Parse("13/05/2018 8:34:01");
            var valor = 1000000;
            Declaracion declaracion = new Declaracion(valor, fechaDeclarar, fechaDeclaracion, true);
            Assert.AreEqual("Sanción por extemporaneidad: 1200000,0", declaracion.LiquidarSancion());
        }

        [Test]
        public void ValorADeclararCeroSinEmplazamiento()
        {
            var fechaDeclaracion = DateTime.Parse("01/05/2018 8:34:01");
            var fechaDeclarar = DateTime.Parse("13/05/2018 8:34:01");
            var valor = 0;
            Declaracion declaracion = new Declaracion(valor, fechaDeclarar, fechaDeclaracion, false);
            Assert.AreEqual("Sanción por extemporaneidad: 312492", declaracion.LiquidarSancion());
        }

        [Test]
        public void ValorADeclararCeroConEmplazamiento()
        {
            var fechaDeclaracion = DateTime.Parse("01/05/2018 8:34:01");
            var fechaDeclarar = DateTime.Parse("13/05/2018 8:34:01");
            var valor = 0;
            Declaracion declaracion = new Declaracion(valor, fechaDeclarar, fechaDeclaracion, true);
            Assert.AreEqual("Sanción por extemporaneidad: 624984", declaracion.LiquidarSancion());
        }

    }
}
