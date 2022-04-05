namespace Tarea_Programada_2.Models
{
    public class Puesto
    {
        public string Nombre { get; set; }
        public float SalarioXHora { get; set; }
        public Puesto(string pNombre, float pSalarioXHora)
        {
            Nombre = pNombre;
            SalarioXHora = pSalarioXHora;
        }
    }
}
