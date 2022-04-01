namespace Tarea_Programada_2.Models
{
    public class Departamento
    {
        public string IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public Departamento(string pIdDepartamento, string pNombre)
        {
            IdDepartamento = pIdDepartamento;
            Nombre = pNombre;
        }
    }
}
