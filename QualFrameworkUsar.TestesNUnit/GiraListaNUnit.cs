using NUnit.Framework;
using QualFrameworkUsar.App;
using System;
using System.Collections.Generic;

namespace QualFrameworkUsar.TestesNUnit
{
    [Category("NUnit")]
    public class GiraListaNUnit
    {
        [Test]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe4Itens()
        {
            var lista = new List<int> { 10, 15, 20, 30 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(4, nova.Count);
            Assert.AreEqual(15, nova[0]);
            Assert.AreEqual(10, nova[3]);
        }

        [Test]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe3Itens()
        {
            var lista = new List<int> { 12, 15, 25 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(3, nova.Count);
            Assert.AreEqual(15, nova[0]);
            Assert.AreEqual(12, nova[2]);
        }

        [Test]
        public void DeveriaGerarErroSeAListaEstiverVazia()
        {
            var lista = new List<int>();
            var gira = new GiraLista();

            var exc = Assert.Throws<ArgumentException>(() => gira.Girar(lista));

            Assert.AreEqual("A lista precisa ter ao menos 1 item.", exc.Message);
        }

        [OneTimeSetUp]
        public void InicializarClasse() { }

        [SetUp]
        public void InicializarTeste() { }

        [TearDown]
        public void FinalizarTeste() { }

        [OneTimeTearDown]
        public void FinalizarClasse() { }
    }
}