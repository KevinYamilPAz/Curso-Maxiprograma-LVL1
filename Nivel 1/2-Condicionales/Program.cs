using System;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            /*
            int num;
            Console.Write("Ingrese un numero ");
            num = int.Parse(Console.ReadLine());
            if (num > 10)
            {
                Console.Write("Es mayor a 10");
            }
            else
            {
                Console.Write("Es menor a 10");
            }*/



            //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor
            //a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
            /*
            int num;
            Console.Write("Ingrese un numero ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.Write("positivo");
            }
            else if (num < 0)
            {
                Console.Write("negativo");
            }
            else { Console.Write("cero"); }*/


            //3.Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10 %.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18 %.
            /*
            float importe;

            Console.Write("Ingrese un numero ");
            importe = int.Parse(Console.ReadLine());
            if (importe <= 1000)
            {
                Console.Write("No tiene descuento");
            }
            else if (importe < 5000 && importe > 1000)
            {
                Console.WriteLine("descuento del 10%");
                importe=importe*0.90f;
            }
            else
            {
                Console.WriteLine("descuento del 15%");
                importe=importe*0.85f;
            }

            Console.WriteLine("Total a pagar : " + importe);
            */



            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos
            
            /*int num,num2,num3,num4,Max;
            Console.Write("Ingrese un numero ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero ");
            num4 = int.Parse(Console.ReadLine());
            if (num > num2)
            {
                Max=num;

            }else
            {
                Max=num2;
            }
            if (Max < num3)
            {
                Max=num3;
            }
            if (Max < num4)
            {
                Max=num4;
            }
            Console.Write("El maximo es: "+Max );
            */


            //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
           /* int num,num2,num3,num4;
            Console.Write("Ingrese un numero ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero ");
            num4 = int.Parse(Console.ReadLine());
            Console.Write("Los numeros mayores a 100 son: ");
            if (num > 100)
            {
            Console.WriteLine(num);

            }
            if (num2 > 100)
            {
            Console.WriteLine(num2);

            }
            if (100 < num3)
            {
            Console.WriteLine(num3);
            }
            if (100 < num4)
            {
            Console.Write(num4);
            }
            */
        }
    }
}
