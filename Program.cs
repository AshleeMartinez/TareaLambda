using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaTarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            { 
                //Manera de agregar objetos explicada en clase  :)
                new Estudiante{Nombre= "Juan", Edad= 20, Nota= 80.9},
                new Estudiante{Nombre= "Mario", Edad= 18, Nota= 99.9},
                new Estudiante{Nombre= "Andrea", Edad= 17, Nota= 65.3},
                new Estudiante{Nombre= "Jacqueline", Edad= 16, Nota= 69.0},
                new Estudiante{Nombre= "Bianca", Edad= 21, Nota= 78.0},
            };

           Console.WriteLine("Expresiones LAMBDA");

            //LAMBDA vacio/sin uso
            Action<string> saludo = _ => Console.WriteLine("Holo");
            saludo("Ignorau");

            //Suma de numeros int 
           /* Func<int, int, int> suma= (a,b)=> a+b;
            Console.WriteLine(suma(3,4));


            //Un solo parametro
            Func<double, double> prod= x=> x*x;
            Console.WriteLine(prod(10));*/

           /* Action<int> MayorEdad = n =>
            {
                Boolean ME = (n > 18) ? true : false;
                Console.WriteLine($"Es mayor de Edad {ME}");
            };
            MayorEdad (15);*/

            
            var mayoresDe18 = estudiantes.Where(estudiante => estudiante.Edad > 18); //EDAD

            Console.WriteLine("Estudiantes mayores de 18 años:");

            foreach (var estudiante in mayoresDe18) Console.WriteLine(estudiante.Nombre);

          
            var mejorEstudiante = estudiantes.MaxBy(estudiante => estudiante.Nota); //Nota alta
            Console.WriteLine($"\nEstudiante con la nota más alta: {mejorEstudiante?.Nombre} - Nota: {mejorEstudiante?.Nota}");

           
            var estudiantesOrdenados = estudiantes.OrderBy(estudiante => estudiante.Nombre); //Ascendente
            Console.WriteLine("\nEstudiantes ordenados por nombre:");
            foreach (var estudiante in estudiantesOrdenados) Console.WriteLine(estudiante.Nombre);

          
            var promedioNotas = estudiantes.Average(estudiante => estudiante.Nota); //prom
            Console.WriteLine($"\nPromedio de notas: {promedioNotas}");



        }
    }
}
