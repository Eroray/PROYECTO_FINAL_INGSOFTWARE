using System;

public class Calculator
{
    public double area(double numerodeLados, double alturaPrisma, double basePrisma, double apotemaPrisma)
    {
        double areaPrisma = (numerodeLados * basePrisma)*(apotemaPrisma+alturaPrisma);
        return areaPrisma;
    }

    public double volumen(double numerodeLados, double alturaPrisma, double basePrisma, double apotemaPrisma)
    {
        double volumenPrisma = (numerodeLados * basePrisma * apotemaPrisma) * 0.5 * alturaPrisma;
        return volumenPrisma;
    }
}