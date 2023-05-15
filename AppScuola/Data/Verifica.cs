using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace AppScuola.Data
{
    [PrimaryKey(nameof(Matricola), nameof(MateriaId), nameof(Data))]
    public class Verifica
    {   
        public DateTime? Data { get; set; } = DateTime.Now;
        [Required]
        [Range(1,10)]
        public decimal Voto { get; set; }
        [Required]
        public string Tipo { get; set; } = "S";

        [Required]
        public int MateriaId { get; set; }

        public Materia Materia { get; set; }

        [Required]
        [ForeignKey("Studente")]
        public Guid Matricola { get; set; }
        public Studente Studente { get; set; }
    }
}
