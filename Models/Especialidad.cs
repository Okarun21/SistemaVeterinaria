namespace Modelo_Veterinaria.Models
{
    public class Especialidad
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Especialidad(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
