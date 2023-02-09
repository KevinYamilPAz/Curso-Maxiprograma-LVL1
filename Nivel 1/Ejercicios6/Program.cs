using System;

namespace Ejercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos
            /*
            int num, primo = 0;
            

            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine("ingrese un numero");
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
                }
                else { Console.WriteLine("No es primo"); }
                primo=0;
            }
            */


            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            /*int num, total = 0, impares = 0, grupoimp = 0, ant = 0, ordenado = 0, grupoordenado = 0;
            float numgrup = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("ingrese el primer numero del grupo " + i);
                num = int.Parse(Console.ReadLine());

                do
                {


                    if (num % 2 != 0) { impares++; }
                    total++;
                    if (ant > num || ant == 0) { ordenado++; }
                    Console.WriteLine("ingrese un numero");
                    num = int.Parse(Console.ReadLine());


                } while (num != 0);
                if (((total * impares) / 100) > numgrup)
                {
                    grupoimp = i;
                    numgrup = ((total * 100) / impares);
                }
                if (ordenado == total) { grupoordenado++; }
                impares = 0;
                total = 0;
                ant=0;
            }
            Console.WriteLine("grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo es el : " + grupoimp);
            Console.WriteLine("cantidad de grupos están formados por todos números ordenados de mayor a menor " + grupoordenado);
            */



            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            /*
            int num, cont = 0, lista = 1;
            Console.WriteLine("ingrese el primer numero del grupo " + lista);
            num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                do
                {
                    Console.WriteLine("ingrese un numero" );
                    num = int.Parse(Console.ReadLine());
                    cont++;

                } while (num != 0);
                
                Console.WriteLine("La lista "+lista+" tiene "+cont+" numeros.");
                lista++;
                cont=0;
                Console.WriteLine("ingrese el primer numero del grupo " + lista);
                num = int.Parse(Console.ReadLine());
            }
            */


           
        }

    }
}
