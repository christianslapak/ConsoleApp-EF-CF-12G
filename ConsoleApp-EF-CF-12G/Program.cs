using System;
using System.Linq;

namespace ConsoleApp_EF_CF_12G
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EscuelaContext();

            var misEstudiantes = context.Estudiante.ToList();

            foreach (var item in misEstudiantes)
            {
                Console.WriteLine("Nombre estudiante:" + item.Nombre + " Edad:" + item.Edad);
            }



            Console.WriteLine("Expresion de Consulta LinQ - Nombres con M ordenados por edad descendiente");
            var consultaEC = from estu in context.Estudiante
                             where estu.Nombre.StartsWith("M") 
                             orderby estu.Edad descending select estu;

            foreach (var item in consultaEC)
            {
                Console.WriteLine("Nombre estudiante:" + item.Nombre + " Edad:" + item.Edad);
            }


            Console.WriteLine("Expresion Lambda");
            var consu = context.Estudiante.Where(e => e.Edad < 30 && e.Edad > 20);
            foreach (var item in consu)
            {
                Console.WriteLine("Nombre estudiante:" + item.Nombre + " Edad:" + item.Edad);
            }


            context.Estudiante.Add(new Estudiante() { Nombre = "Alfredo", Edad = 35 });
            context.SaveChanges();

            Console.WriteLine("Nuevo Estudiante agregado");

            Console.ReadKey();
        }
    }
}
