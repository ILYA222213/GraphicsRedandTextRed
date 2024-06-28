using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    // Класс Logger, отвечающий за запись сообщений в лог-файл
    internal class Logger
    {
        // Метод Log, принимающий строку сообщения и записывающий ее в лог-файл
        public static void Log(string message)
        {
            // Получение пути к рабочему столу пользователя
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Формирование полного пути к лог-файлу на рабочем столе
            string logFilePath = Path.Combine(desktopPath, "Message.log");

            // Открытие файла для записи с помощью StreamWriter, используя блочный оператор using для автоматического закрытия файла
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                // Формирование строки записи в лог, включающей дату и время, а также сообщение
                string logEntry = $"[{DateTime.Now}] {message}";

                // Запись строки в лог-файл
                writer.WriteLine(logEntry);
            }
        }
    }
}