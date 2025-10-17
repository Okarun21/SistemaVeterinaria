namespace Modelo_Veterinaria.Models
{
    public class Perro : Mascota
    {
        public Perro(int idmascota, string nombre, int edad, double peso, string tiposangre)
            : base(idmascota, nombre, edad, peso, tiposangre)
        {
        }
        public void Ladrar()
        {
            Console.WriteLine("El perro esta ladrando");
        }
    }
}