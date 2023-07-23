using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrategyFiles.Domain.Models
{
    public class ParsedBin
    {
        [Required]
        public string? Id { get; set; }
        [Required]
        public string? IdMember { get; set; }        
        [Required]
        public long? FinalBin { get; set; }
        [Required]
        public string? IssuerName { get; set; }
        [Required]
        public string? IdCountry { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? RangeBin { get; set; }
        public string? Coutry { get; set; }
    }
}