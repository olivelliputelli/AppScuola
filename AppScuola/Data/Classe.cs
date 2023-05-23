using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace AppScuola.Data
{
    public class Classe
    {
        [Key]
        [Required]
        [StringLength(5)]
        public string Sigla { get; set; }

        [Required]
        public string NomeEsteso { get; set; } = string.Empty;
        public string? Ubicazione { get; set; }
        public bool IsMultimediale { get; set; } = false;
        public double? Longitudine { get; set; } = 12.4963655;
        public double? Latitudine { get; set; } = 41.9027835;
        public List<Studente>? Studenti { get; set; }
    }
}
