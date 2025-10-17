namespace Modelo_Veterinaria.Models
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public String TipoSangre { get; set; }

        public Mascota(int idmascota, String nombre, int edad, double peso, String tiposangre)
        {
            IdMascota = idmascota;
            Nombre = nombre;
            Edad = edad;
            Peso = peso;
            TipoSangre = tiposangre;
        }
    }
}