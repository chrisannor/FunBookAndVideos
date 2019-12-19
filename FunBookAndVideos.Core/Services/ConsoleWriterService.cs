using System;

namespace FunBookAndVideos.Core.Services
{
    public class ConsoleWriterService : IPrinterService
    {
        public void PrintText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
