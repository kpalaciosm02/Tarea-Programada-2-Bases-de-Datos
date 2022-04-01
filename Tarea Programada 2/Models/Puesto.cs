namespace Tarea_Programada_2.Models
{
    public class Puesto
    {
        public string Nombre { get; set; }
        public string SalarioXHora { get; set; }
        public Puesto(string pNombre, string pSalarioXHora)
        {
            Nombre = pNombre;
            SalarioXHora = pSalarioXHora;
        }
    }
}
