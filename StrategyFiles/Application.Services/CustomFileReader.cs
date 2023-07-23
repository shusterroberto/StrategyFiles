using StrategyFiles.Domain.Interfaces;
using System.Collections.Specialized;

namespace Application.Services
{
    public class CustomFileReader : IListDictionaryStrategy
    {
        public ListDictionary ReadFile(string filePath)
        {
            ListDictionary content = new();
            using (var reader = new System.IO.StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        content.Add(line.Substring(14, 18).ToString(), line.ToString());
                        Console.WriteLine("Linhas adicionadas no dicionario: " + content.Count.ToString());
                    }
                    catch (Exception)
                    {
                        return content;
                    }
                    
                }
            }
            return content;
        }
    }
}