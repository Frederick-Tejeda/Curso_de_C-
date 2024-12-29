namespace Iteracion_while{
    class Program{
        static void Main(){
            Random myRandom = new Random();
            // Obtenemos un numero aleatorio del 1 al 10
            int randomNumber = myRandom.Next(1,11);
            int intentos = 1;

            Console.WriteLine("¡Adivina el numero!");
            while(true){
                Console.Write("Adivina un numero del 1 a 10: ");
                // Obtenemos el numero y lo convertimos a int
                int userGuess = int.Parse(Console.ReadLine());
                if(userGuess == randomNumber)
                    // En caso del usuario acertar, salimos del bucle
                    break;
                intentos++;
            }
            // Mensaje informativo para el usuario
            Console.WriteLine($"Luego de {intentos} intentos, lograste adivinar el numero {randomNumber}");
            Console.ReadLine();
        }
    }
}