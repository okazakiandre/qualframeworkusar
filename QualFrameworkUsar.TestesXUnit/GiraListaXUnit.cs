using QualFrameworkUsar.App;
using System;
using System.Collections.Generic;
using Xunit;

namespace QualFrameworkUsar.TestesXUnit
{
    public class GiraListaXUnit : IClassFixture<ListaFixture>, IDisposable
    {
        [Fact]
        [Trait("XUnit", "")]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe4Itens()
        {
            var lista = new List<int> { 10, 15, 20, 30 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.Equal(4, nova.Count);
            Assert.Equal(15, nova[0]);
            Assert.Equal(10, nova[3]);
        }

        [Fact]
        [Trait("XUnit", "")]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe3Itens()
        {
            var lista = new List<int> { 12, 15, 25 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.Equal(3, nova.Count);
            Assert.Equal(15, nova[0]);
            Assert.Equal(12, nova[2]);
        }

        [Fact]
        [Trait("XUnit", "")]
        public void DeveriaGerarErroSeAListaEstiverVazia()
        {
            var lista = new List<int>();
            var gira = new GiraLista();

            var exc = Assert.Throws<ArgumentException>(() => gira.Girar(lista));

            Assert.Equal("A lista precisa ter ao menos 1 item.", exc.Message);
        }

        private ListaFixture fixture { get; }
        public GiraListaXUnit(ListaFixture fixt)
        {
            fixture = fixt;
            //InicializarTeste
        }

        public void Dispose()
        {
            //FinalizarTeste
        }
    }
}
