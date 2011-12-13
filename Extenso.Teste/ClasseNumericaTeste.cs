using System.Collections.Generic;
using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class ClasseNumericaTeste
    {
        [TestCase("1", 3, "milh�o")]
        [TestCase("2", 3, "milh�es")]
        [TestCase("1", 4, "bilh�o")]
        [TestCase("999", 4, "bilh�es")]
        [TestCase("1", 5, "trilh�o")]
        [TestCase("1", 15, "tredecilh�o")]
        public void sufixo_de_teste(string textoCentena, int ordem, string expected)
        {
            var bloco = new Bloco(new Centena(textoCentena), ordem);
            Assert.AreEqual(expected, ClasseNumerica.SufixoDe(bloco));
        }

        [TestCase("321321321321321321321321321321", 10)]
        [TestCase("3325644748", 4)]
        [TestCase("332564378", 3)]
        [TestCase("33256478", 3)]
        [TestCase("4256478", 3)]
        [TestCase("566478", 2)]
        [TestCase("64778", 2)]
        [TestCase("64", 1)]
        [TestCase("", 0)]
        public void deve_retorna_quantidade_de_blocos(string numero, int quantidadeEsperada)
        {
            List<Bloco> blocos = FabricaBlocos.GerarBlocos(numero);
            Assert.AreEqual(quantidadeEsperada, blocos.Count);
        }
    }
}