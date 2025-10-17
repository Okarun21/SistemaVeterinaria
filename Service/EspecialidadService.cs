using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Modelo_Veterinaria.Services
{
    public class EspecialidadService
    {
        private ILiteCollection<Especialidad> _collection;

        public EspecialidadService(LiteDatabase db)
        {
            _collection = db.GetCollection<Especialidad>("especialidades");
            _collection.EnsureIndex(x => x.Nombre, true);
        }

        public List<Especialidad> GetAll() => _collection.FindAll().ToList();

        public Especialidad GetByName(string nombre) => _collection.FindOne(x => x.Nombre == nombre);

        public void Create(Especialidad esp) => _collection.Insert(esp);

        public bool Delete(string nombre) => _collection.DeleteMany(x => x.Nombre == nombre) > 0;
    }
}
