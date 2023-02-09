using System;

namespace Ejercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.
            /*
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            */


            //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla
            /*
            int edad, max = 0;
            Console.WriteLine("ingrese 10 numeros");
            for (int i = 1; i < 11; i++)
            {
                num=int.Parse(Console.ReadLine());
                if ((i == 1) || (num > max))
                {
                    max = num;
                }
            }
            Console.WriteLine("El numero maximo es :" + max);
            */


            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años
            /*
            int edad,edades=0,cont = 0;
            Console.WriteLine("ingrese 20 edades");
            for (int i = 1; i < 21; i++)
            {
                edad=int.Parse(Console.ReadLine());
                if (edad > 18)
                {
                    edades+=edad;
                    cont++;
                }
            }
            edad=edades/cont;
            Console.WriteLine("El promedio de edad es : " + edad);
            */



            //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es 
            //primo cuando es divisible únicamente por 1 y por sí mismo 
            
            /*
            int num, primo = 0;
            Console.WriteLine("ingrese 1 numero");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                if (num % i == 0)
                {
                    primo++;
                }
               
            }
            if (primo == 2)
            {
                Console.WriteLine("Es primo");
            }else{Console.WriteLine("No es primo");}
            */



            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares
            /*int num, pares=0,impares=0;
            
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("ingrese 20 numero");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    if (num>pares)
                    {
                        pares=num;
                    }
                }
                if (num % 2 != 0)
                {
                    if (num>impares)
                    {
                        impares=num;
                    }
                }
               
            }
            
                Console.WriteLine("el mayor par : "+pares);
                Console.WriteLine("No mayor impar : "+impares);
            */
        }
    }
}
