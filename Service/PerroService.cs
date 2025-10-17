using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Modelo_Veterinaria.Services
{
    public class PerroService
    {
        private readonly ILiteCollection<Perro> _collection;

        public PerroService(LiteDatabase database)
        {
            _collection = database.GetCollection<Perro>("perros");
        }

        public List<Perro> GetAll() => _collection.FindAll().ToList();

        public Perro GetById(int id) => _collection.FindById(id);

        public void Create(Perro perro)
        {
            _collection.Insert(perro);
        }

        public bool Update(int id, Perro perro)
        {
            if (!_collection.Exists(x => x.IdMascota == id))
                return false;

            _collection.Update(perro);
            return true;
        }

        public bool Delete(int id)
        {
            return _collection.Delete(id);
        }
    }
}
