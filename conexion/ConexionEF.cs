using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Conexion
{

    public class ConexionEF
    {
        private string string_conexion = "server=localhost;database=db_facturas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;";
        // server=localhost;database=db_facturas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_facturas;Integrated Security=True;TrustServerCertificate=true;

        public ConexionEF()
        {
            Console.WriteLine("\n\n\n\n CONEXION EF A BASE DE DATOS");
        }

        public void ObtenerEstados()
        {
            var conexion = new Conexion();
            conexion.StringConnection = this.string_conexion;

            var lista_Estados = conexion.Estados.ToList();
            foreach (var estado in lista_Estados)
            {
                Console.WriteLine(estado.Id.ToString()+" | "+estado.Nombre);
            }
        }
    }
    public class Conexion : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Estados>? Estados { get; set; }
       
    }

}
