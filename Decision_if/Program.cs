namespace Decision{
    class Program{
        static void Main(string[] args){
            // Console.WriteLine("Bob's Big Giveaway");
            // Console.Write("Elige una puerta: 1, 2 o 3: ");
            // string userValue = Console.ReadLine();

            // string message = "";

            // if (userValue == "1")
            //     message = "¡Ganaste una  pasola!";
            // else if(userValue == "2")
            //     message = "¡Ganaste un auto!";
            // else if(userValue == "3")
            //     message = "¡Ganaste un bote!";
            // else{
            //     message = "Equivocado. ";
            //     message += "Lo siento, pero perdiste. ";
            // }

            // Console.WriteLine(message);
            // Console.ReadKey();

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Elige una puerta: 1, 2 o 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "un pasola" : (userValue == "2") ? "un auto" : (userValue == "3") ? "un bote" : "nada";
            Console.WriteLine("Ingresaste un {0}, asi que ganaste {1}", userValue, message);
            Console.ReadKey();
        }
    }
}
