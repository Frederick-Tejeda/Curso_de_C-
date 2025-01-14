using System.Net;

namespace clase;

public class Scrape
{
    public string ScrapeWebPage(string url){
        return GetWebPage(url);
    }
    public string ScrapeWebPage(string url, string filepath){
        string reply =  GetWebPage(url);
        File.WriteAllText(filepath, reply);
        return reply;
    }
    public string GetWebPage(string url){
        WebClient client = new WebClient();
        return client.DownloadString(url);
    }
}
