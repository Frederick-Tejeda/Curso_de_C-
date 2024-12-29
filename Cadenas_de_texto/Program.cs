using System.Text;

namespace Cadenas_de_texto{
    class Program{
        static void Main(string[] args){
            //string myString = "Juan le dijo a Carlos \"haz tu parte de la tarea\" por decima vez";
            // string myString = "Salto \nde linea";
            // string myString = "Los datos booleanos tienen dos posibles valores: true\\false ";
            // string myString = @"Los datos booleanos tienen dos posibles valores: true\false ";

            // string myString = string.Format("{0} + {0} = {1}", "1", "2");
            // string myString = string.Format("{0:C}", 27);
            // string myString = string.Format("{0:P}", 27);
            // string myString = string.Format("{0:C}", 27);
            // string myString = string.Format("{0:(###)###-####}", 8091234567);
            // string myString = string.Format("{0:(###)###-####}", 809123456789);

            string myString = " Erase una vez, una serie poco conocida ";
            // myString = myString.Substring(10, 20);
            // myString = myString.ToUpper();
            // myString = myString.ToLower();

            // myString = myString.Replace(" ", "_");
            // myString = myString.Remove(2,20);
            // myString = myString.Trim();
            // myString = string.Format("Longitud: antes {0}, despues {1}", myString.Length, myString.Trim().Length);
            // Console.WriteLine(myString);

            // string newString = "";
            // foreach(char s in myString){
            //     newString += "_-_" + s;
            // }
            // Console.WriteLine(newString);

            StringBuilder newString = new StringBuilder();
            foreach(char s in myString){
                newString.Append("_-_");
                newString.Append(s);
            }
            Console.WriteLine(newString);

            Console.ReadLine();
        }
    }
}