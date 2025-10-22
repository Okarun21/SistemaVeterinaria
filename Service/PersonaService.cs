using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Modelo_Veterinaria.Services
{
    public class PersonaService
    {
        private readonly ILiteCollection<Persona> _collection;

        public PersonaService(LiteDatabase database)
        {
            _collection = database.GetCollection<Persona>("personas");
        }

        public List<Persona> GetAll() => _collection.FindAll().ToList();

        public Persona GetById(int id) => _collection.FindById(id);

        public void Create(Persona persona) => _collection.Insert(persona);

        public bool Update(int id, Persona persona)
        {
            if (!_collection.Exists(x => x.Id_Persona == id))
                return false;

            persona.Id_Persona = id;  
            _collection.Update(persona);
            return true;
        }

        public bool Delete(int id) => _collection.Delete(id);
    }
}
