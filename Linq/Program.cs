using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Linq{
    class Program{
        static void Main(string[] args){
            List<Carro> misCarros = new List<Carro>{
                new Carro() { vin = "A1", marca = "BMW", modelo = "55oi", stickerPrice = 55000, año = 2012 },
                new Carro() { vin = "B1", marca = "Toyota", modelo = "Camry", stickerPrice = 15000, año = 2021 },
                new Carro() { vin = "C1", marca = "Honda", modelo = "CRV", stickerPrice = 25000, año = 2017 },
                new Carro() { vin = "D1", marca = "Nissan", modelo = "Patron", stickerPrice = 54200, año = 2004 },
                new Carro() { vin = "E1", marca = "Auddi", modelo = "RS5", stickerPrice = 85700, año = 2010 },
                new Carro() { vin = "F1", marca = "Ford", modelo = "Escape", stickerPrice = 97210, año = 2001 },
            };

            // // LINQ Query
            // var bmws = from car in misCarros
            //     where car.stickerPrice > 40000
            //     select car;

            // var carrosOrdenados = from car in misCarros
            //                         orderby car.año descending
            //                         select car;

            // LINQ Method
            // var bmws = misCarros.Where(p => p.marca == "BMW" && p.año == 2012);

            // var carrosOrdenados = misCarros.OrderByDescending(p => p.año);

            // var primerBMW = misCarros.OrderByDescending(p => p.año).First(p => p.marca == "BMW");
            // Console.WriteLine(primerBMW.vin);

            // Console.WriteLine(misCarros.TrueForAll(p => p.año > 1012));
            
            // misCarros.ForEach(p => Console.WriteLine($"{p.vin} {p.stickerPrice}"));

            // misCarros.ForEach(p => p.stickerPrice -= 3000);
            // misCarros.ForEach(p => Console.WriteLine($"{p.vin} {p.stickerPrice}"));

            // Console.WriteLine(misCarros.Exists(p => p.modelo == "55oi"));

            // Console.WriteLine(misCarros.Sum(p => p.stickerPrice));

            Console.WriteLine(misCarros.GetType());
            var carrosOrdenados = misCarros.OrderByDescending(p => p.año);
            Console.WriteLine(carrosOrdenados.GetType());

            var bmws = misCarros.Where(p => p.marca == "BMW" && p.año == 2012);
            Console.WriteLine(bmws.GetType());

            var nuevosCarros = from car in misCarros
                                where car.marca == "BMW"
                                && car.año == 2010
                                select new { car.marca, car.modelo };

            Console.WriteLine(nuevosCarros.GetType());

            // foreach(var car in carrosOrdenados){
            //     Console.WriteLine($"{car.año} {car.modelo} {car.vin}");
            // }
        }
    }
    class Carro{
        public string marca { get; set; }
        public string modelo { get; set; }
        public int año { get; set; }
        public string color { get; set; }
        public string vin { get; set; }
        public int stickerPrice { get; set; }
    }
}