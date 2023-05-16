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
        public string NomeEsteso { get; set; }
        public string? Ubicazione { get; set; }
        public bool IsMultimediale { get; set; } = false;
        public List<Studente>? Studenti { get; set; }
    }
}
