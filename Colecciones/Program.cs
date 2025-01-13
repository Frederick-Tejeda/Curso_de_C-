using System.Collections;
namespace Colecciones{
    class Program{
        static void Main(string[] args){
            // Carro carro1 = new Carro();
            // carro1.marca = "Honda";
            // carro1.modelo = "Civic";
            // carro1.vin = "A1";

            // Carro carro2 = new Carro();
            // carro2.marca = "Toyota";
            // carro2.modelo = "Corolla";
            // carro2.vin = "B2";

            // Libro libro1 = new Libro();
            // libro1.autor = "William Shakespear";
            // libro1.titulo = "Romeo y Julieta";
            // libro1.isbn = "0-00-0000-00000";

            // // Arreglo 
            // ArrayList miArreglo = new ArrayList();
            // miArreglo.Add(carro1);
            // miArreglo.Add(carro2);
            // miArreglo.Add(libro1);
            // miArreglo.Remove(libro1);

            // foreach(Carro carro in miArreglo){
            //     Console.WriteLine(carro.marca);
            // }

            // // List<T>
            // List<Carro> miLista = new List<Carro>();
            // miLista.Add(carro1);
            // miLista.Add(carro2);
            // // miLista.Add(libro1);
            // foreach(Carro carro in miLista){
            //     Console.WriteLine(carro.marca);
            // }

            // // Diccionario<TKey, TValue>

            // Dictionary<string, Carro> miDiccionario = new Dictionary<string, Carro>();
            // miDiccionario.Add(carro1.vin, carro1);
            // miDiccionario.Add(carro2.vin, carro2);

            // Console.WriteLine(miDiccionario["B2"].marca);

            // string[] names = {"Juan", "Ana", "Jose", "Maria", "Pedro", "Juana"};

            // Inicializador de objeto
            // Carro carro1 = new Carro(){ marca = "Honda", modelo = "Civic", vin = "0-00-000-0000" };
            // Carro carro2 = new Carro(){ marca = "Toyota", modelo = "Corolla", vin = "0-00-000-0000" };

            // Inicializador de coleccion
            List<Carro> miLista = new List<Carro>(){
                new Carro { marca = "Honda", modelo = "Civic", vin = "0-00-000-0000" },
                new Carro { marca = "Toyota", modelo = "Corolla", vin = "0-00-000-0000" }
            };

            Console.ReadLine();
        }
    }
    class Carro{
        public string vin { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
    }
    class Libro{
        public string titulo { get; set; }
        public string autor { get; set; }
        public string isbn { get; set; }
    }
}