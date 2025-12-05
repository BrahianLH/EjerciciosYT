using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Ejercicios
{
    class Ejercicios
    {
       
           
        static void Main(string[] args)
        {
            Ejercicios obj = new Ejercicios();
            obj.Ejercicio2();

        }


        // Pedir un nombre, guardar la variable nombre y devolver con un saludo
        public void Ejercicio1()
        {
            Console.WriteLine("Escribe tu nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Hola " + Nombre);
            Console.ReadKey();
        }


        // Pedir las medidas de base y altura de un triángulo para calcular el perímetro y área
        public void Ejercicio2()
        {
            Console.WriteLine("Ingrese la base (en cm): ");
            double Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la Altura (en cm): ");
            double Altura = Convert.ToInt32(Console.ReadLine());

            double perimetro = 2*(Base + Altura);
            double area = Base * Altura;

            Console.WriteLine("El tamaño del perímetro es (En cm): " + perimetro);
            Console.WriteLine("El tamaño del area es (En cm): " + area);
            Console.ReadKey();
        }





    }
}