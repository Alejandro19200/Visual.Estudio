using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            String ApellidoPaterno;
            String ApellidoMaterno;
            int Edad;
            String Ocupacion;
            String Correo;
            String Mes;

            Console.WriteLine("REGISTRO DE PLATAFORMA");
            Console.WriteLine("Ingresa Tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine(Nombre);

            Console.WriteLine("Ingrese su apellido Paterno");
            ApellidoPaterno = Console.ReadLine();
            Console.WriteLine(ApellidoPaterno);

            Console.WriteLine("Ingrese su apellido Materno");
            ApellidoMaterno = Console.ReadLine();
            Console.WriteLine(ApellidoMaterno);

            Console.WriteLine("Ingresa tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            if (Edad <= 18)
            {
                Console.WriteLine("El usuario es menor de edad, Registro Fallido");
            }

            Console.WriteLine("Ingresa su ocupación ");
            Ocupacion = Console.ReadLine();
            Console.WriteLine(Ocupacion);

            Console.WriteLine("Ingresa su correo electronico ");
            Correo = Console.ReadLine();
            Console.WriteLine(Correo);

        }
    }
}
