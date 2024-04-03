namespace Clase_3.Models.CNE
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public Boolean Salio_Mesa { get; set; }
        public Lugar_Votacion Lugar_votacion {  get; set; }
    }
}
