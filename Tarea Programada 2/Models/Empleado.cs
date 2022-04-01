namespace Tarea_Programada_2.Models
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string IdTipoIdentificacion { get; set; }
        public string ValorDocumentoIdentificacion { get; set; }
        public string IdDepartamento { get; set; }
        public string Puesto { get; set; }
        public string FechaNacimiento { get; set; }
        public Empleado(string pNombre, string pIdTipoId, string pValorDocId, string pIdDepartamento, string pPuesto, string pFechaNacimiento)
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
