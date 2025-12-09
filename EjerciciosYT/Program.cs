using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Ejercicios
{
    class Ejercicios
    {
       
           
        static void Main(string[] args)
        {
            Ejercicios obj = new Ejercicios();
            obj.Ejercicio7();

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


        // Pedir los valores de los catetos de un triángulo rectángulo y calcular la hipotenusa
        public void Ejercicio3()
        {

            Console.WriteLine("Ingrese el valor del cateto 1 (en metros): ");
            double cateto1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto 2 (en metros): ");
            double cateto2 = Convert.ToInt32(Console.ReadLine());
            cateto1 = Math.Pow(cateto1, 2);
            cateto2 = Math.Pow(cateto2, 2);
            double hiponetusa = Math.Sqrt(cateto1 + cateto2);
            Console.WriteLine("La hipotenusa es: " + hiponetusa);
            Console.ReadKey();
        }


        // Pedir dos números y realizar las cuatro operaciones básicas (suma, resta, multiplicación y división)
        public void Ejercicio4()
        {
            Console.WriteLine("Ingrese el valor del número 1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicación es: " + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            Console.ReadKey();
        }


        // Pedir una cantidad en grados Fahrenheit y convertirla a grados Celsius
        public void Ejercicio5()
        {
            Console.WriteLine("Ingrese los grados Fahrenheit que quiere convertir a Celsius: ");
            double Fahrenheit = Convert.ToInt32(Console.ReadLine());

            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Los grados Celsius son: " + Celsius);
            Console.ReadKey();

        }


        // Pedir tres números y calcular la media aritmética
        public void Ejercicio6()
        {
            Console.WriteLine("Ingrese él primer número: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese él segundo número: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese él tercer número: ");
            double num3 = Convert.ToInt32(Console.ReadLine());


            double media = (num1 + num2 + num3) / 3;
            Console.WriteLine("La media de los tres números es: " + media);
            Console.ReadKey();
        }


        // Pedir una cantidad en minutos y convertirla a horas y minutos
        public void Ejercicio7()
        {

            Console.WriteLine("Ingrese la cantidad de minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            int horas = minutos / 60;
            int Horasrestantes = minutos % 60;
            Console.WriteLine("La cantidad de horas es: " + horas + " y los minutos restantes son: " + Horasrestantes);
            Console.ReadKey();

        }

        public void Ejercicio8()
        {


        }

        public void Ejercicio9()
        {


        }

        public void Ejercicio10()
        {


        }
    }
}