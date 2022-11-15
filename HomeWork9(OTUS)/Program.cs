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

            Console.WriteLine("Нажмите любую клавишу для выхода продолжения");
            Console.ReadKey();
            Console.WriteLine();

            Task task = downloader.DownloadAsync();            
            Console.WriteLine("Нажмите клавишу 'A' или 'a' для выхода или любую другую клавишу для проверки статуса скачивания");            
            var key = Console.ReadKey();
            Console.WriteLine();

            if (key.KeyChar.ToString().ToLower() != "a")
            {
                if (task.IsCompleted)
                    Console.WriteLine("Асихронное скачивание выполнено успешно!"); 
                else
                    Console.WriteLine("Асихронное скачивание не выполнено!");
            }
        }

        public static void ShowStatus(string text)
        {
            Console.WriteLine(text);
        }
    }
}