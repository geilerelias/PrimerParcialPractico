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
            
            var fecharegistro = DateTime.Parse("08/05/2018 8:34:01");
            var valor = 0;
            Declaracion declaracion = new Declaracion(valor,fecharegistro);
            Assert.Equals("el valor de extemporaneidad es de $1.000.000", declaracion.LiquidarSancion());
        }

        [Test]
        public void ValorMayorACeroConEmplazamiento()
        {
            var fecharegistro = DateTime.Parse("08/05/2018 8:34:01");
            var valor = 0;
            Declaracion declaracion = new Declaracion(valor, fecharegistro);
            Assert.Equals("", declaracion.LiquidarSancion());
        }

        [Test]
        public void ValorADeclararCeroSinEmplazamiento()
        {
            var fecharegistro = DateTime.Parse("08/05/2018 8:34:01");
            var valor = 0;
            Declaracion declaracion = new Declaracion(valor, fecharegistro);
            Assert.Equals("", declaracion.LiquidarSancion());
        }

        [Test]
        public void ValorADeclararCeroConEmplazamiento()
        {
            var fecharegistro = DateTime.Parse("08/05/2018 8:34:01");
            var valor = 0;
            Declaracion declaracion = new Declaracion(valor, fecharegistro);
            Assert.Equals("", declaracion.LiquidarSancion());
        }

    }
}
