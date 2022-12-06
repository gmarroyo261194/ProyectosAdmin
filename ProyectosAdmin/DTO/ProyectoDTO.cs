using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectosAdmin.DTO
{
    public class ProyectoDTO
    {
        public Guid ProyectoID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string AreaDestino { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaEstado { get; set; }
    }
}
