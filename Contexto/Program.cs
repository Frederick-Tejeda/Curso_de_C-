namespace Contexto{
    class Program{
        private static string k = "";
        static void Main(string[] args){
            string numero = "";
            for(int i = 0; i < 10; i++){
                numero = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if(i == 9){
                    string l = i.ToString();
                }
                // Console.WriteLine(l);
            }
            // Console.WriteLine(i);
            Console.WriteLine("Afuera del bucle for \"numero\": {0}", numero);
            Console.WriteLine("Afuera del bucle for \"k\": {0}", k);

            Metodo();

            Carro myCarro = new Carro();
            myCarro.HazAlgo();
        }
        static void Metodo(){
            Console.WriteLine("Valor de \"k\" desde el metodo: {0}", k);
        }
    }

    class Carro{
        public void HazAlgo(){
            Console.WriteLine(Metodo());
        }
        private string Metodo(){
            return "Hello World!";
        }
    }
}