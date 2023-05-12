using System.ComponentModel.DataAnnotations;

namespace AppScuola.Data
{
    public class Classe
    {
        [Key]
        [StringLength(5)]  
        public string Sigla { get; set; }
        [Required]
        public string NomeEsteso { get; set; }
        public string? Ubicazione { get; set; }
        public bool IsMultimediale { get; set; } = false;
    }
}
