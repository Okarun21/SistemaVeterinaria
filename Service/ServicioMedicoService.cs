using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;

public class ServicioMedicoService
{
    private ILiteCollection<ServicioMedico> _collection;

    public ServicioMedicoService(LiteDatabase db)
    {
        _collection = db.GetCollection<ServicioMedico>("serviciosMedicos");
    }

    public List<ServicioMedico> GetAll() => _collection.FindAll().ToList();

    public ServicioMedico GetById(long id) => _collection.FindById(id);

    public void Create(ServicioMedico servicio) => _collection.Insert(servicio);

    public bool Update(long id, ServicioMedico servicio)
    {
        var exists = _collection.Exists(x => x.Fecha.Ticks == id);
        if (!exists) return false;
        _collection.Update(servicio);
        return true;
    }

    public bool Delete(long id) => _collection.Delete(id);
}
