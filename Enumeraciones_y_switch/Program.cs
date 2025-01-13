using System;
namespace Enumeraciones_y_switch{
    class Program{
        static void Main(string[] args){

            List<Todo> todos = new List<Todo>(){
                new Todo { Descripcion = "Tarea 1", HorasEstimadas = "6", Estado = Estado.Completado },
                new Todo { Descripcion = "Tarea 2", HorasEstimadas = "2", Estado = Estado.EnProceso },
                new Todo { Descripcion = "Tarea 3", HorasEstimadas = "8", Estado = Estado.NoEmpezado },
                new Todo { Descripcion = "Tarea 4", HorasEstimadas = "12", Estado = Estado.Borrado },
                new Todo { Descripcion = "Tarea 5", HorasEstimadas = "6", Estado = Estado.EnProceso },
                new Todo { Descripcion = "Tarea 6", HorasEstimadas = "2", Estado = Estado.Completado },
                new Todo { Descripcion = "Tarea 7", HorasEstimadas = "14", Estado = Estado.EnProceso },
                new Todo { Descripcion = "Tarea 8", HorasEstimadas = "8", Estado = Estado.Borrado },
                new Todo { Descripcion = "Tarea 9", HorasEstimadas = "8", Estado = Estado.Completado },
                new Todo { Descripcion = "Tarea 10", HorasEstimadas = "8", Estado = Estado.EnProceso },
                new Todo { Descripcion = "Tarea 11", HorasEstimadas = "4", Estado = Estado.NoEmpezado },
                new Todo { Descripcion = "Tarea 12", HorasEstimadas = "10", Estado = Estado.Borrado },
                new Todo { Descripcion = "Tarea 13", HorasEstimadas = "12", Estado = Estado.Completado },
                new Todo { Descripcion = "Tarea 14", HorasEstimadas = "6", Estado = Estado.NoEmpezado }
            };

            Console.ForegroundColor = ConsoleColor.DarkRed;

            PrintAssessment(todos);

            Console.ReadLine();
        }
        private static void PrintAssessment(List<Todo> todos){
            foreach(var todo in todos){
                switch(todo.Estado){
                    case Estado.NoEmpezado:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Estado.EnProceso:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Estado.Completado:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Estado.Borrado:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Descripcion);
            }
        }
    }
    class Todo{
        public string Descripcion { get; set; }
        public string HorasEstimadas { get; set; }
        public Estado Estado { get; set; }
    }
    enum Estado{
        NoEmpezado,
        EnProceso,
        Completado,
        Borrado
    }
}
