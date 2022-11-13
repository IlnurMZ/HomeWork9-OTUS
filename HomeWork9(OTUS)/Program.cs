using System.Net;

namespace HomeWork9_OTUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var downloader= new ImageDownloader();
            downloader.ImageStarted += ShowStatus;
            downloader.ImageCompleted += ShowStatus;

            downloader.Download();

        }

        public static void ShowStatus(string text)
        {
            Console.WriteLine(text);
        }
    }
}