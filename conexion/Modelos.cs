using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conexion
{
    public class Estados
    {
        [Key] private int Id { get; set; }
        private string Nombre { get; set; }

        // [NotMapped] public virtual ICollection<Estados>? Estados { get; set; }
    }
}