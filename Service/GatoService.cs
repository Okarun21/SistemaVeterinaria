using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Modelo_Veterinaria.Services
{
    public class GatoService
    {
        private readonly ILiteCollection<Gato> _collection;

        public GatoService(LiteDatabase database)
        {
            _collection = database.GetCollection<Gato>("gatos");
        }

        public List<Gato> GetAll() => _collection.FindAll().ToList();

        public Gato GetById(int id) => _collection.FindById(id);

        public void Create(Gato gato)
        {
            _collection.Insert(gato);
        }

        public bool Update(int id, Gato gato)
        {
            if (!_collection.Exists(x => x.IdMascota == id))
                return false;

            _collection.Update(gato);
            return true;
        }

        public bool Delete(int id)
        {
            return _collection.Delete(id);
        }
    }
}
