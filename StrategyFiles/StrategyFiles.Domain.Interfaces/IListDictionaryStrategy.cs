using System.Collections.Specialized;
using System.Text;

namespace StrategyFiles.Domain.Interfaces
{
    public interface IListDictionaryStrategy
    {
        ListDictionary ReadFile(string content);
    }
}
