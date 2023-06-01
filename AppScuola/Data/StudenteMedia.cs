using Microsoft.EntityFrameworkCore;

namespace AppScuola.Data
{
    [Keyless]
    public class StudenteMedia
    {
        public Guid Matricola { get; set; }
        public string? Nominativo { get; set; }
        public int Numero { get; set; }
        public decimal Media { get; set; }
    }
}
