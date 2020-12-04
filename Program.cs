using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerodeLados = 0;
            double basePrisma = 0;
            double alturaPrisma = 0;
            double apotemaPrisma = 0;
            double areaPrisma = 0;
            double volumenPrisma = 0;
         
            Console.WriteLine("CALCULADORA DE ÁREA Y VOLUMEN DE UN PRISMA REGULAR");
            Console.WriteLine();

            Console.WriteLine("Capture los datos que se te solicitan en centímetros.");
            Console.Write("Ingrese el número de lados de su prisma:");
            string n = Console.ReadLine(); numerodeLados = Convert.ToDouble(n);

            Console.Write("Base:");
            string b = Console.ReadLine(); basePrisma = Convert.ToDouble(b);
           
            Console.Write("Altura:");
            string h = Console.ReadLine(); alturaPrisma = Convert.ToDouble(h);
            
            Console.Write("Apotema:");
            string a = Console.ReadLine(); apotemaPrisma = Convert.ToDouble(a);

            Console.WriteLine();

            Calculator  Cal01 =new Calculator();

             areaPrisma =Cal01.area(numerodeLados,basePrisma,alturaPrisma,apotemaPrisma);
             volumenPrisma =Cal01.volumen(numerodeLados,basePrisma,alturaPrisma,apotemaPrisma);

            Console.WriteLine();
            Console.WriteLine("ÁREA DEL PRISMA :" + areaPrisma + "cm2 y VOLUMEN DEL PRISMA :" + volumenPrisma + "cm3");
        }
    }
}
