namespace Clases_y_metodos{
    class Program{
        static void Main(string[] args){
            Carro miCarro = new Carro();

            Carro.MiMetodo();

            // /*
            // miCarro.año = 2025;
            // miCarro.color = "negro";
            // miCarro.marca = "Auddi";
            // miCarro.modelo = "RS5 SportBack";
            // */

            // Carro miTercerCarro = new Carro("Toyota", "Tacoma", 2018, "rojo");

            // Carro miOtroCarro;
            // miOtroCarro = miCarro;

            // Console.WriteLine($"Mi carro es un {miCarro.marca} {miCarro.modelo} {miCarro.año} color {miCarro.color}");

            // miOtroCarro.modelo = "s3";

            // Console.WriteLine($"Mi otro carro es un {miOtroCarro.marca} {miOtroCarro.modelo} {miOtroCarro.año} color {miOtroCarro.color}");

            // miOtroCarro = null;

            // Console.WriteLine($"Mi otro carro es un {miOtroCarro.marca} {miOtroCarro.modelo} {miOtroCarro.año} color {miOtroCarro.color}");

            // miCarro = null;

        }
    }
    class Carro{
        public string marca { get; set; }
        public string modelo { get; set; }
        public int año { get; set; }
        public string color { get; set; }

        public Carro(){
            this.marca = "Nissan";
        }
        public Carro(string Marca, string Modelo, int Año, string Color){
            año = Año;
            marca = Marca;
            modelo = Modelo;
            color = Color;
        }
        public static void MiMetodo(){
            Console.WriteLine("Lllamaste a mi \"MiMetodo\"");
            // Console.WriteLine(marca);
        }
    }
}