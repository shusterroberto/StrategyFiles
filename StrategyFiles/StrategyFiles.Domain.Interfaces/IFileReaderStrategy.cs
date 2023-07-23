using System.Collections.Specialized;
using System.Text;

namespace StrategyFiles.Domain.Interfaces
{
    public interface IFileReaderStrategy
    {
        string ReadFile(string filePath);
    }
}
