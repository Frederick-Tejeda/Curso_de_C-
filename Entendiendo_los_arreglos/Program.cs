namespace Arreglos{
    class Program{
        static void Main(string[] args){
            // int numero1 = 1;
            // int numero2 = 2;
            // int numero3 = 3;
            // int numero4 = 4;
            // int numero5 = 5;

            int[] numero = new int[5];
            numero[0] = 1;
            numero[1] = 2;
            numero[2] = 3;
            numero[3] = 4;
            numero[4] = 5;

            Console.WriteLine("\n Los numeros: ");
            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach(int n in numeros){
                Console.WriteLine(n);
            }

            Console.WriteLine("\n Los nombres: ");
            string[] nombres = { "uno", "dos", "tres", "cuatro", "cinco" };
            foreach(string n in nombres){
                Console.WriteLine(n);
            }
            Console.WriteLine();

            string zig = "One Two Three " + "Four Five Six";
            char[] arregloChar = zig.ToCharArray();
            Array.Reverse(arregloChar);

            Console.WriteLine(arregloChar);

            Console.ReadLine();

        }
    }
}