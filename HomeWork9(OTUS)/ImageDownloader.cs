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
        WebClient myWebClient = new WebClient();
        string remoteUri = "https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg";
        string fileName;
        
        public void Download()
        {
            fileName = "bigimage.jpg";            
            
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n", fileName, remoteUri);
            ImageStarted?.Invoke("Скачивание файла началось");
            myWebClient.DownloadFile(remoteUri, fileName);
            ImageCompleted?.Invoke("Скачивание файла закончилось \n");
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"\n", fileName, remoteUri);            
        }

        public async Task DownloadAsync()
        {            
            fileName = "bigimage2.jpg";            
            
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n", fileName, remoteUri);
            ImageStarted?.Invoke("Скачивание файла началось");
            await myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
            ImageCompleted?.Invoke("Скачивание файла закончилось \n");
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);           
        }       
            
    }
}
