using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace AppScuola.Data
{
    public class Materia
    {
        public int MateriaId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = String.Empty;
        [Range(0, 10_000)]
        public decimal PrezzoLibro { get; set; }
        public List<Verifica>? Verifiche { get; set; }
    }
}
