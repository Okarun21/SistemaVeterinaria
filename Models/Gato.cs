public class Gato : Mascota
{
    public Gato(int idmascota, string nombre, int edad, double peso, string tiposangre)
        : base(idmascota, nombre, edad, peso, tiposangre)
    {
    }
    
    public void Maullar()
    {
        Console.WriteLine("El gato está maullando");
    }
}
