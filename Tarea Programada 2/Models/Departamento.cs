namespace Tarea_Programada_2.Models
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public Departamento(int pIdDepartamento, string pNombre)
        {
            IdDepartamento = pIdDepartamento;
            Nombre = pNombre;
        }
    }
}
