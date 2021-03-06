using System;
using Xunit;

namespace Program.Unit.Test2
{
    public class UnitTest2
    {
         
        //Test 1
        [Theory]
        [InlineData(3,7,4,2,108)]
        [InlineData(2,3,5,8,110)]
        [InlineData(3,4,7,3,147)]
        [InlineData(4,5,2,9,112)]
        [InlineData(5,5,7,8,455)]

        public void Test1(double numerodeLados, double basePrisma, double apotemaPrisma, double alturaPrisma, double d) 
        {
            //Datos
            Calculator  Cal01 =new Calculator();
            //Actuar
            double areaPrisma = Cal01.area(numerodeLados, basePrisma, apotemaPrisma, alturaPrisma);
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
            Calculator  Cal02 =new Calculator();
            //Actuar
            double volumenPrisma = Cal02.volumen(numerodeLados, basePrisma, apotemaPrisma, alturaPrisma);
            //Revisar
            Assert.Equal(d, volumenPrisma);
        }
        //Test 3
        [Theory]
        [InlineData(3,7,4,2,127)]
        [InlineData(2,3,5,8,79)]
        [InlineData(3,4,7,3,121)]
        [InlineData(4,5,2,9,221)]
        [InlineData(5,5,7,8,376)]

        public void Test3(double numerodeLados, double basePrisma, double apotemaPrisma, double alturaPrisma, double d) 
        {
            //Datos
            Calculator  Cal03 =new Calculator();
            //Actuar
            double areaPrisma = Cal03.area(numerodeLados, basePrisma, apotemaPrisma, alturaPrisma);
            //Revisar
            Assert.NotEqual(d, areaPrisma);
        }
        //Test 4
        [Theory]
        [InlineData(3,7,4,2,85)]
        [InlineData(2,3,5,8,121)]
        [InlineData(3,4,7,3,127)]
        [InlineData(4,5,2,9,181)]
        [InlineData(5,5,7,8,701)]

        public void Test4(double numerodeLados, double basePrisma, double apotemaPrisma, double alturaPrisma, double d) 
        {
            //Datos
            Calculator  Cal04 =new Calculator();
            //Actuar
            double volumenPrisma = Cal04.volumen(numerodeLados, basePrisma, apotemaPrisma, alturaPrisma);
            //Revisar
            Assert.NotEqual(d, volumenPrisma);
        }
    }
}
