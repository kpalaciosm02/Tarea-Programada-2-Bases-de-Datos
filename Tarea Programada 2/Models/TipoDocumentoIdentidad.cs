namespace Tarea_Programada_2.Models
{
    public class TipoDocumentoIdentidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        TipoDocumentoIdentidad(int pId, string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }
    }
}
