using StrategyFiles.Domain.Interfaces;
using System.Text;

namespace Application.Api
{
    internal class FileReader
    {
        private IFileReaderStrategy strategy;

        public FileReader(IFileReaderStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string ReadFile(string filePath)
        {
            return strategy.ReadFile(filePath);
        }
    }
}