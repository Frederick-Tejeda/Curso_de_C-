using clase;

namespace cliente{
    class Program{
        static void Main(string[] args){
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebPage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
