using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            const int resultadoEsperado = 5;
            const int n1 = 2;
            const int n2 = 3;
            var resultado = ConsoleAppTeste.Program.Soma(n1,n2);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}