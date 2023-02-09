using System;

namespace Ejercicios8
{
    class Program
    {
        static void Main(string[] args)
        {
            int punto;
            Console.WriteLine("Ingrese el punto");
            punto = int.Parse(Console.ReadLine());
            switch (punto)
            {
                case 1:
                    Punto1();
                    break;
                case 2:
                    Punto2();
                    break;
                case 3:
                    Punto3();
                    break;
                default:
                    punto4();
                    break;
            }
        }
        static void punto4()
        {
            /*4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia.
            Que analice el número y escriba variable recibida por referencia con:

            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.*/
            int num1;
            Console.WriteLine("Ingrese 1 numeros");
            num1 = int.Parse(Console.ReadLine());
            positivoNegativocero(ref 
            num1);
            
            if (num1 == 1) { Console.WriteLine("Es positivo"); }
            
            else if (num1 == 0) { Console.WriteLine("Cero"); }

            else { Console.WriteLine("Es negativo"); }
        }
        static void positivoNegativocero(ref int num1)
        {
            if (num1 > 0) { num1 = 1; }
            
            else if (num1 == 0) { num1 = 0; }

            else { num1 = -1; }
        }





        static void Punto3()
        {
            int num1;
            //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            Console.WriteLine("Ingrese 1 numeros");
            num1 = int.Parse(Console.ReadLine());
            if (primo(num1) == 1) { Console.WriteLine("es primo"); }
            else { Console.WriteLine("No es primo"); }
        }
        static int primo(int num)
        {
            int cont = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) { cont++; }
            }
            if (cont == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



        static void Punto2()
        {
            int num1;
            //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            Console.WriteLine("Ingrese 1 numeros");
            num1 = int.Parse(Console.ReadLine());
            if (par(num1) == 1) { Console.WriteLine("es par"); }
            else { Console.WriteLine("es impar"); }
        }
        static int par(int num)
        {
            if (num % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



        static void Punto1()
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función. 
            int num1, num2;
            Console.WriteLine("Ingrese 2 numeros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El producto de los dos numeros es : " + producto(num1, num2));

        }
        static int producto(int num1, int num2)
        {
            int pro;
            pro = num1 * num2;
            return pro;
        }
    }
}
