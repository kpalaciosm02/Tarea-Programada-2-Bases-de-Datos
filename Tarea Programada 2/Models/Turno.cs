namespace Tarea_Programada_2.Models
{
    public class Turno
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        Turno (string pId, string pNombre, string pHoraInicio, string pHoraFin)
        {
            Id = pId;
            Nombre = pNombre;
            HoraInicio = pHoraInicio;
            HoraFin = pHoraFin;
        }
    }
}
