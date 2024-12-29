namespace Fechas_y_horas{
    class Program{
        static void Main(){
            DateTime date = DateTime.Now;

            Console.WriteLine(date.ToString());
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());

            Console.WriteLine(date.AddDays(10).ToLongDateString());
            Console.WriteLine(date.AddDays(-10).ToLongDateString());
            Console.WriteLine(date.AddHours(10).ToLongTimeString());
            Console.WriteLine(date.AddHours(-10).ToLongTimeString());

            Console.WriteLine(date.Day);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Year);

            // DateTime birthday = new DateTime(2005, 09, 18);
            DateTime birthday = DateTime.Parse("2005/09/18");
            Console.WriteLine(birthday.ToLongDateString());

            TimeSpan hoursFromBirthday = DateTime.Now.Subtract(birthday);
            Console.WriteLine(hoursFromBirthday.Days);
            
        }
    }
}