using System;

namespace Ejercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            */
            /*
            int num1,num2;
            Console.WriteLine("Ingrese 2 numeros ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
  
            if (num1 > num2)
            {
            Console.WriteLine(num1-num2);

            }
            if (num2 > num1)
            {
            Console.WriteLine(num2*num1);

            }
            if (num1==num2)
            {
            Console.WriteLine(num1+num2);
            }
            */
            /*
        2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            */

            /*int litros;
            Console.Write("Ingrese la cantidad de litros :)");
            litros = int.Parse(Console.ReadLine());
            if (litros <= 100)
            {
                Console.Write("No tiene descuento");
            }
            if (litros >= 101 && litros <= 300)
            {
                Console.Write("El descuento es del 10%.");
            }
            if (litros >= 301 && litros <= 500)
            {
                Console.Write("El descuento es del 15%.");
            }
            if (litros > 500)
            {
                Console.Write("El descuento es del 25%.");
            }
            */


            /*
            3.Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

                       i5(1)      i7(2)       i9(3)
            8 RAM(1)   USD 800    USD 900     USD 1200
            16 RAM(2)  USD 900    USD 1000    USD 1400
            32 RAM(3)  USD 1000   USD 1400    USD 2000

            Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo adicional de USD 300.
            Hacer un programa que solicite la opción de procesador, la opción de memoria RAM, y si extiende el disco o no(ingresa 1 para extender y 0 para no extender) y calcule y emita 
            por pantalla el monto de la máquina seleccionada.
            */
            /*
            int procesador, ram, valor = 0;
            short opcion;

            Console.WriteLine("     Elija el procesador    ");
            Console.WriteLine("i5(1)      i7(2)       i9(3)");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("     Elija la cantidad de ram    ");
            Console.WriteLine("8 RAM(1)      16 RAM(2)       32 RAM(3)");
            ram = int.Parse(Console.ReadLine());
            if (procesador == 1)
            {
                if (ram == 1) { valor = 800; }
                else if (ram == 2) { valor = 900; }
                else if (ram == 3) { valor = 1000; }
            }
            else if (procesador == 2)
            {
                if (ram == 1) { valor = 900; }
                else if (ram == 2) { valor = 1000; }
                else if (ram == 3) { valor = 1400; }
            }
            else if (procesador == 3)
            {
                if (ram == 1) { valor = 1200; }
                else if (ram == 2) { valor = 1400; }
                else if (ram == 3) { valor = 2000; }
            }
            Console.WriteLine(" desea agregar una memoria de 1T ?");
            opcion = short.Parse(Console.ReadLine());
            {
                if (opcion == 1)
                {
                    valor += 300;
                }
                Console.WriteLine("el costo total del producto es : " + valor);
            }
            */



           // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            /*
           int num1,num2,num3;
            Console.WriteLine("Ingrese 3 numeros ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if ((num1+num2)>num3*num2)
            {
            Console.WriteLine("la suma de los dos primeros es mayor al producto del segundo con el tercero");
            }else
            {
            Console.WriteLine("la suma de los dos primeros es menor al producto del segundo con el tercero");
            }
            */



            //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
            /*
            int num1,num2,num3,num4;
            Console.WriteLine("Ingrese 3 numeros ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            if (num1>num2&&num2>num3&&num3>num4)
            {
            Console.WriteLine("se encuentran ordenados de forma decreciente ");  
            }
            */
        }
    }
}
