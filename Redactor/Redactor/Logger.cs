using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    internal class Logger
    {
        public static void Log(string message)
        {
            // Получение пути к рабочему столу пользователя.
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
           // Создание пути к файлу журнала.
            string logFilePath = Path.Combine(desktopPath, "Message.log");
// Открытие файла журнала для добавления в него сообщения.
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                // Формирование записи в журнале с меткой времени.
                string logEntry = $"[{DateTime.Now}] {message}";
                // Запись сообщения в файл журнала.
                writer.WriteLine(logEntry);
            }
        }
    }
}
