namespace Manejo_de_errores{
    class Program{
        static void Main(string[] args){
            try{
                string content = File.ReadAllText("./Ejemplo.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex){
                Console.WriteLine("Hubo un problema");
                Console.WriteLine("Asegurate de que el archivo este nombreado correctamente \"Ejemplo.txt\"");
            }
            catch(DirectoryNotFoundException ex){
                Console.WriteLine("Hubo un problema");
                Console.WriteLine("Asegurate de que el archivo este ubicado en la ruta raiz \"Ejemplo.txt\"");
            }
            catch(Exception ex){
                Console.WriteLine("Algo salio mal...");
                Console.WriteLine(ex.Message);
            }
            finally{
                Console.WriteLine("Cerrando la aplicacion...");
            }
        }
    }
}