using System;
using Xunit;
using NewTalents;
using NuGet.Frameworks;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.somar(1, 2);

            Assert.Equal(3, resultado);
        }
    }
}