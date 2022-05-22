using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ingatlan.Models
{
    [Table("kategoriak")]
    public class KategoriaModel
    {
        public int Id { get; set; }
        [Required]
        public string Nev { get; set; }
    }
}
