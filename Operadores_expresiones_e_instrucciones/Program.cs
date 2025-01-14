namespace Operadores_expreiones_e_instrucciones{
    class Program{
        static void Main(string[] args){

            // Declaracion de variable
            int x, y, a, b;

            // Operador de asignacion
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // Operador de suma
            x = 3 + 4;

            // Operador de resta
            x = 4 - 3;

            // Operador de multiplicacion
            x = 10 * 5;

            // Operador de division
            x = 10 / 5;

            // Orden de las operaciones usando parentesis
            x = (x + y) * (a - b);

            // Operador de igualdad
            if(x == y){

            }

            // Mayor que
            if(x > y){
                
            }

            // Menor que
            if(x < y){
                
            }

            // Mayor o igual que
            if(x >= y){
                
            }

            // Menor o igual que
            if(x <= y){
                
            }

            // Operador de condicion &&
            if((x > y) && (a > b)){
                
            }

            // Operador de condicion ||
            if((x > y) || (a > b)){
                
            }

            // Operador de condicion en line
            string mensaje = (x == 1) ? "Carro" : "Bote";

            // Acceso de miembro y metodo de invocacion
            Console.WriteLine("Hi");
            
            Console.ReadLine();
        }
    }
}