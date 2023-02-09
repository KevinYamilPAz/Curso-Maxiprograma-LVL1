using System;

namespace Ejercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            /*
            int[] num = new int[10];
             int max = 0, pos = 0;
             for (int i = 0; i < 10; i++)
             {
                 Console.Write("Ingrese un numero : ");
                 num[i] = int.Parse(Console.ReadLine());
                 if (num[i] > max || i == 0) { max = num[i]; pos = i; }
             }
             Console.WriteLine("El mayor de los 10 fue : " + num[pos] + " y su posicion es la " + (pos + 1));
            */



            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            /*int[] num = new int[10];
            float promedio = 0;
            int acu=0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero : ");
                num[i] = int.Parse(Console.ReadLine());
                acu+=num[i];
            }
            promedio=acu/10;
            Console.WriteLine("Los numeros mayores al promedio son : ");
            for (int i = 0; i < 10; i++)
            {
                if (num[i]>promedio)
                {
                    Console.WriteLine(num[i]);
                }
                
            }
            */



            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"  
            /*
            char[] a = new char[30];
            char letra, cambio;
            Console.Write("Ingrese letra x letra una palabra : ");
            for (int i = 0; i < 20; i++)
            {
                a[i] = char.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese la letra que desea cambiar ");
            letra = char.Parse(Console.ReadLine());
            Console.Write("Ingrese la letra x la que lo desea cambiar ");
            cambio = char.Parse(Console.ReadLine());

            for (int i = 0; i < 20; i++)
            {
                if (a[i]==letra)
                {
                 Console.Write(cambio);   
                }else
                {
                    Console.Write(a[i]);
                }
            }
            */



            /*
            4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            - Número de Artículo (1 a 15)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            Se pide determinar e informar:
                ////a) El número de artículo que más se vendió en total.
                //b) Los números de artículos que no registraron ventas.
                //c) Cuantas unidades se vendieron del número de artículo 10.
            */
            int numart, max = 0;
            int[] cant = new int[15];
            Console.WriteLine("Ingrese el numero de articulo");
            numart = int.Parse(Console.ReadLine());
            while (numart != 0)
            {
                Console.WriteLine("Ingrese la cantidad que desea comprar del articulo");
                cant[numart - 1] += int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de articulo");
                numart = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 15; i++)
            {
                if (cant[i] > cant[max] || i == 0) { max = i; }
            }
            Console.WriteLine("El articulo " + (max+1) + " fue el articulo que mas vendio.");
            for (int i = 0; i < 15; i++)
            {
                if (cant[i] == 0) { Console.WriteLine("El articulo " + (i + 1) + " no registro ventas"); }
            }
            Console.WriteLine("El articulo 10 registro " + (cant[9]) + " ventas");

        }
    }
}
