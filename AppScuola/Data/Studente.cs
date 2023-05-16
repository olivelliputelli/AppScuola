using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace AppScuola.Data
{
    public class Studente
    {
        [Key]
        public Guid Matricola { get; set; }
        [Required]
        public string Nominativo { get; set; } = string.Empty;
        public byte[]? Foto { get; set;}
        public DateTime? DataDiNascita { get; set; } = new DateTime(DateTime.Now.Year-15, 1,1);
        public string? Genere { get; set; }

        [ForeignKey("Classe")]
        public string? SiglaClasse { get; set; }
        public Classe? Classe { get; set; }
        public List<Verifica>? Verifiche { get; set; }
    }
}
