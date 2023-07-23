using StrategyFiles.Domain.Interfaces;
using System.Collections.Specialized;

namespace Application.Services
{
    public class SimpleFileReader : IFileReaderStrategy
    {
        public string ReadFile(string filePath)
        {
            // Implementação para ler o arquivo de forma simples
            return System.IO.File.ReadAllText(filePath);
        }
    }
}