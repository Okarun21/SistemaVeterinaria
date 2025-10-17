using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Modelo_Veterinaria.Services
{
    public class VeterinarioService
    {
        private readonly ILiteCollection<Veterinario> _collection;

        public VeterinarioService(LiteDatabase database)
        {
            _collection = database.GetCollection<Veterinario>("veterinarios");
        }

        public List<Veterinario> GetAll() => _collection.FindAll().ToList();

        public Veterinario GetById(int id) => _collection.FindById(id);

        public void Create(Veterinario veterinario)
        {
            _collection.Insert(veterinario);
        }

        public bool Update(int id, Veterinario veterinario)
        {
            if (!_collection.Exists(x => x.Id_Persona == id))
                return false;

            _collection.Update(veterinario);
            return true;
        }

        public bool Delete(int id)
        {
            return _collection.Delete(id);
        }
    }
}
