using System;

namespace Moda
{
    class Program
    {

        static void Main(string[] args)
        //Ruben Sepulveda Velarde
        //Algoritmos

        {
            int Entrada = 0;
            int valor = 0;
            Console.WriteLine("===============Moda=============================");
            Console.Write("Ingrese tamaño del vector");//Pedir el tama;o del vector
            Entrada = int.Parse(Console.ReadLine());//Guardamos los valores en la variable Entrada
            int[] vector = new int[Entrada];//Creamos el vector y guaramos los valores en la variable entrada 
            Console.WriteLine("");

            for (int i = 0; i < Entrada; i++)//creamos un ciclo for para ir guardando los valores que ingrese el usuario
            {
                Console.Write("Ingresar valores:" + (i + 1) + "");//le pedimos al usuario ingresar valores y vamos incrementando 1
                valor = Int32.Parse(Console.ReadLine());//el valor que ingreso es string lo debemos convertir a int
                vector[i] = valor;// al vector creado le vamos ingresando la cantidad de numeros que el usuario eliga
            }
            int ca = 0; //variable contador anterior
            int moda = 0;//variable donde guardaremos la moda 

            for (int j = 0; j < Entrada - 1; j++)
            {
                int c = 1;// la variable del contador vale 1

                for (int k = j + 1; k < Entrada; k++)
                {
                    if (vector[j] == vector[k])//si el vector j y el vector k es igual 
                    {
                        c += 1;// se le incrementa 1 a la variable contador
                    }
                }

                if (c > ca)// si el contador es mayor al contador anterios
                {
                    ca = c;//iguala
                    moda = vector[j];// la moda es igual al vector k
                }
            }
            Console.WriteLine("Moda:" + moda + " cantidad de veces que se repite el numero: " + ca);// imprimir la moda y la cantidad de veces qe se repite el numero
            Console.ReadKey();
        }
    }
}
