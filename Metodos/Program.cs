namespace Metodos{
    class Program{
        static void Main(){
            print("hello world!");
            Saludar("Frederick");
            Console.WriteLine(Sumar(2,6));
            Console.WriteLine(Restar(3,6));
            Console.WriteLine(Multiplicar(4,7));
            Console.WriteLine(Dividir(20,3));
        }
        private static void print(string msg){
            Console.WriteLine(msg);
        }
        private static void Saludar(string person){
            Console.WriteLine($"¡Hola, {person}!");
        }
        private static string Sumar(double a, double b){
            return $"{a} + {b} = {a + b}";
        }
        private static string Restar(double a, double b){
            return $"{a} - {b} = {a - b}";
        }
        private static double Multiplicar(double a, double b){
            return a * b;
        }
        private static double Dividir(double a, double b){
            return a / b;
        }
    }
}