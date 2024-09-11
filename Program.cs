using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexion;

//Console.WriteLine("Hello, World!");

var conexionEF = new ConexionEF();
//conexionEF.NonQueryPeliculas();
conexionEF.ObtenerEstados();

namespace ConsoleApp.Clases.MensajeriaInstantanea
{
    public class Personas
    {
        private int id = 0;
        private string cedula = "";
        private string nombre = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }

    public class Estados
    {
        private int id = 0;
        private string nombre = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }

    public class Grupos
    {
        private int id = 0;
        private string nombre = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
    }

    public class Pers_Grps
    {
        private int id = 0;
        private int grupo = 0;
        private int persona = 0;

        public int Id { get => this.id; set => this.id = value; }
        public int Grupo { get => this.grupo; set => this.grupo = value; }
        public int Persona { get => this.persona; set => this.persona = value; }
    }

    public class Detalles
    {
        private int id = 0;
        private int mensaje = 0;
        private int para = 0;
        private int estado = 0;

        public int Id { get => this.id; set => this.id = value; }
        public int Mensaje { get => this.mensaje; set => this.mensaje = value; }
        public int Para { get => this.para; set => this.para = value; }
        public int Estado { get => this.estado; set => this.estado = value; }
    }

    public class Mensajes
    {
        private int id = 0;
        private string contenido = "";
        private DateTime? fecha = null;
        private int estado = 0;
        private Boolean borrado = true;
        private int de = 0;
        private int? para = null;
        private int? grupo = null;


        public int Id { get => this.id; set => this.id = value; }
        public string Contenido { get => this.contenido; set => this.contenido = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public int Estado { get => this.estado; set => this.estado = value; }
        public Boolean Borrado { get => this.borrado; set => this.borrado = value; }
        public int De { get => this.de; set => this.de = value; }
        public int? Para { get => this.para; set => this.para = value; }
        public int? Grupo { get => this.grupo; set => this.grupo = value; }

    }
}