using System;
using Xunit;

namespace Program.Unit.Test2
{
    public class UnitTest2
    {
        //Test 1
        [Theory]
        [InlineData(3,7,4,2,126)]
        [InlineData(2,3,5,8,78)]
        [InlineData(3,4,7,3,120)]
        [InlineData(4,5,2,9,220)]
        [InlineData(5,5,7,8,375)]

        public void Test1(double numerodeLados, double basePrisma, double apotemaPrisma, double alturaPrisma, double d) 
        {
            //Datos
            Calculator  Cal01 =new Calculator();
            //Actuar
            double areaPrisma = (numerodeLados * basePrisma)*(apotemaPrisma+alturaPrisma);
            //Revisar
            Assert.Equal(d, areaPrisma);
        }
        //Test 2
        [Theory]
        [InlineData(3,7,4,2,84)]
        [InlineData(2,3,5,8,120)]
        [InlineData(3,4,7,3,126)]
        [InlineData(4,5,2,9,180)]
        [InlineData(5,5,7,8,700)]

        public void Test2(double numerodeLados, double basePrisma, double apotemaPrisma, double alturaPrisma, double d) 
        {
            //Datos
            Calculator  Cal01 =new Calculator();
            //Actuar
            double volumenPrisma = (numerodeLados * basePrisma * apotemaPrisma) * 0.5 * alturaPrisma;
            //Revisar
            Assert.Equal(d, volumenPrisma);
        }
    }
}
