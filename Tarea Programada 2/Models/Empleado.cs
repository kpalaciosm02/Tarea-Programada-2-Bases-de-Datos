namespace Tarea_Programada_2.Models
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public int ValorDocumentoIdentificacion { get; set; }
        public int IdDepartamento { get; set; }
        public string Puesto { get; set; }
        public string FechaNacimiento { get; set; }
        public Empleado(string pNombre, int pIdTipoId, int pValorDocId, int pIdDepartamento, string pPuesto, string pFechaNacimiento)
        {
            Nombre = pNombre;
            IdTipoIdentificacion = pIdTipoId;
            ValorDocumentoIdentificacion = pValorDocId;
            IdDepartamento = pIdDepartamento;
            Puesto = pPuesto;
            FechaNacimiento = pFechaNacimiento;
        }
    }
}
