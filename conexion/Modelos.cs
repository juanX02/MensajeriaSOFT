using System.ComponentModel.DataAnnotations;

namespace Conexion
{
    public class Estados
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }

        // [NotMapped] public virtual ICollection<Estados>? Estados { get; set; }
    }
}