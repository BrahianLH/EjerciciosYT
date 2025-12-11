using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Ejercicios
{
    class Ejercicios
    {
       
           
        static void Main(string[] args)
        {
            Ejercicios obj = new Ejercicios();
            obj.Ejercicio10();

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

        // Pedir el sueldo de un empleado y el total de sus ventas en el mes para calcular su sueldo total con una comisión del 10%
        public void Ejercicio8()
        {
            Console.WriteLine("Ingrese el total de su sueldo: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el total de sus ventas: ");
            double ventas = Convert.ToDouble(Console.ReadLine());

            double comision = ventas * 0.10;
            double sueldototal = sueldo + comision;

            Console.WriteLine("Su sueldo total es: " + sueldototal);
            Console.ReadKey();
        }


        // Pedir el precio de una compra y aplicar un descuento del 15% para calcular el total a pagar
        public void Ejercicio9()
        {

            Console.WriteLine("Ingrese el precio de la compra: ");
            double total = Convert.ToDouble(Console.ReadLine());

            double descuento = total * 0.15;
            double totalapagar = total - descuento;

            Console.WriteLine("El total de su compra con el descuento es de: " + totalapagar);
            Console.ReadKey();
        }


        // Pedir las notas de tres parciales, el examen final y un trabajo final para calcular la nota final de un
        // estudiante con los siguientes porcentajes: 55% parciales, 30% examen final y 15% trabajo final
        public void Ejercicio10()
        {
            Console.WriteLine("Ingrese la primer nota del parcial: ");
            double p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota del parcial: ");
            double p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota del parcial: ");
            double p3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (p1 + p2 + p3) / 3;

            Console.WriteLine("Ingrese la nota del examen final: ");
            double efinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del trabajo final: ");
            double trabajo = Convert.ToDouble(Console.ReadLine());

            double notafinal = ((promedio * 0.55) + (efinal * 0.30) + (trabajo * 0.15));
            Console.WriteLine("La nota final del estudiante es: " + notafinal);
            Console.ReadKey();
        }
    }
}