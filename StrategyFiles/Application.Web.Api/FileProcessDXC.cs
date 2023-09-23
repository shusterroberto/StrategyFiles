using StrategyFiles.Domain.Models;
using StrategyFiles.Infrastructure.Repositories;

namespace Application.Web.Api
{
    public class FileProcessDXC
    {
        public static void ProcessBins()
        {
            
        }
        public FileProcessDXC(string filepath) {
            var reader = new System.IO.StreamReader(filepath);
            bool starter = false;
            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    if (starter)
                    {
                        var dbContext = new BinDbContext();
                        dbContext.Database.EnsureCreated();

                        var newBin = new ParsedBin();

                        newBin.Id = line.Substring(0, 2);
                        newBin.IdMember = line.Substring(2, 11);
                        //newBin.RangeBin = long.Parse(line.Substring(13, 18));
                        newBin.FinalBin = long.Parse(line.Substring(22, 9));
                        newBin.IssuerName = line.Substring(31, 30);
                        newBin.IdCountry = line.Substring(61, 3);
                        if (newBin.IdCountry.Equals("076"))
                            newBin.Coutry = "Brasil";
                        else
                            newBin.Coutry = "Internacional";

                        dbContext.Bins.Add(newBin);
                        dbContext.SaveChanges();

                        Console.WriteLine(line);
                    }
                    starter = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}