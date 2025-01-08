namespace Clases{
    class Program{
        static void Main(string[] args){
            Car miCarro = new Car();
            miCarro.Año = 2025;
            miCarro.Color = "negro";
            miCarro.Marca = "Auddi";
            miCarro.Modelo = "RS5 SportBack";

            Console.WriteLine($"Mi carro es un {miCarro.Marca} {miCarro.Modelo} {miCarro.Año} color {miCarro.Color}");
            Console.WriteLine("Mi carro cuesta alrededor de {0:C} de dolares", Precio(miCarro));
        }
        public static decimal Precio(Car miCarro){
            decimal valorDelAuto;
            if(miCarro.Año >= 2025){
                valorDelAuto = 2000000.0M;
            }else{
                valorDelAuto = 20000.0M;
            }
            return valorDelAuto;
        }
    }
    public class Car{
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }

        private int miVar;

        public string nombreDeLaClase{
            get{ return nombreDeLaClase; }
            set{ nombreDeLaClase = value; }
        }
    }
}