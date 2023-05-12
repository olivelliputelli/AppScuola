using Microsoft.EntityFrameworkCore;

namespace AppScuola.Data
{
    [Keyless]
    public class ClasseStudenti
    {
        public string? SiglaClasse { get; set; }
        public string? NomeEsteso { get; set; }
        public int? NumeroStudenti { get; set; }
        public string? ListaStudenti { get; set; }
    }
}
