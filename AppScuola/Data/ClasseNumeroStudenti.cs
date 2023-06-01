using Microsoft.EntityFrameworkCore;

namespace AppScuola.Data
{
    [Keyless]
    public class ClasseNumeroStudenti
    {
        public string? SiglaClasse { get; set; }
        public string? NomeClasse { get; set; }
        public int? NumeroStudenti { get; set; }
    }
}
