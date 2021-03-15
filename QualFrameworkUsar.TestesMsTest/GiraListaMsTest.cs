using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QualFrameworkUsar.App;
using System;

namespace QualFrameworkUsar.TestesMsTest
{
    [TestClass]
    [TestCategory("MsTest")]
    public class GiraListaMsTest
    {
        [TestMethod]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe4Itens()
        {
            var lista = new List<int> { 10, 15, 20, 30 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(4, nova.Count);
            Assert.AreEqual(15, nova[0]);
            Assert.AreEqual(10, nova[3]);
        }

        [TestMethod]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe3Itens()
        {
            var lista = new List<int> { 12, 15, 25 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(3, nova.Count);
            Assert.AreEqual(15, nova[0]);
            Assert.AreEqual(12, nova[2]);
        }

        [TestMethod]
        public void DeveriaGerarErroSeAListaEstiverVazia()
        {
            var lista = new List<int>();
            var gira = new GiraLista();

            var exc = Assert.ThrowsException<ArgumentException>(() => gira.Girar(lista));

            Assert.AreEqual("A lista precisa ter ao menos 1 item.", exc.Message);
        }

        [ClassInitialize]
        public static void InicializarClasse(TestContext context) { }

        [TestInitialize]
        public void InicializarTeste() { }

        [TestCleanup]
        public void FinalizarTeste() { }

        [ClassCleanup]
        public static void FinalizarClasse() { }
    }
}
