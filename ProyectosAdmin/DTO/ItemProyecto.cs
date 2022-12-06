namespace ProyectosAdmin.DTO
{
    public class ItemProyecto
    {
        public Guid ProyectoID { get; set; }
        public Guid ItemID { get; set; }
        public string Nombre { get; set; }
        public string Etapa { get; set; }
        public DateTime FechaEtapa { get; set; }
        public string Estado { get; set; }


    }
}
