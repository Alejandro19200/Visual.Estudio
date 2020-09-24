using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre, ApellidoPaterno, ApellidoMaterno, Ocupacion, email;            
            int Edad; 
            
            Console.WriteLine("REGISTRO DE PLATAFORMA");
            Console.WriteLine("Ingresa Tu nombre");
            Nombre = Console.ReadLine();
            

            Console.WriteLine("Ingrese su apellido Paterno");
            ApellidoPaterno = Console.ReadLine();
            

            Console.WriteLine("Ingrese su apellido Materno");
            ApellidoMaterno = Console.ReadLine();
            

            Console.WriteLine("Ingresa tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            if (Edad < 18)
            {
                Console.WriteLine("El usuario es menor de edad, Registro Fallido");
            }
            else
            {
                Console.WriteLine("El registro a sido un éxito");
            }
            Console.WriteLine("Ingresa su ocupación ");
            Ocupacion = Console.ReadLine();
            

            Console.WriteLine("Ingresa su correo electronico ");
            email = Console.ReadLine();
            
            Console.WriteLine("Apellido Paterno:{0}", ApellidoPaterno);
            Console.WriteLine("Apellido Materno:{0}", ApellidoMaterno);
            Console.WriteLine("Nombre:{0}",Nombre);
            Console.WriteLine("Edad:{0} años", Edad);
Console.WriteLine("Soy {0}", Ocupacion);
Console.WriteLine("{0}", email);
        }
    }
}