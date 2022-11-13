using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_OTUS
{
    internal class ImageDownloader
    {
        public event Action<string> ImageStarted;
        public event Action<string> ImageCompleted;
        public void Download()
        {            
            string remoteUri = "https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg";
            string fileName = "bigimage4.jpg";

            // Качаем картинку в текущую директорию
            var myWebClient = new WebClient();
            ImageStarted?.Invoke("Скачивание файла началось");
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
            myWebClient.DownloadFile(remoteUri, fileName);
            ImageCompleted?.Invoke("Скачивание файла закончилось");
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }

        public async Task DownloadAsync()
        {
            string remoteUri = "https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg";
            string fileName = "bigimage5.jpg";
            var myWebClient = new WebClient();            
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
            await myWebClient.DownloadFileTaskAsync(remoteUri, fileName);            
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }       
            
    }
}
