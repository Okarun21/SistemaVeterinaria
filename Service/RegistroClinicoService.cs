using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Modelo_Veterinaria.Services
{
    public class RegistroClinicoService
    {
        private ILiteCollection<RegistroClinico> _collection;

        public RegistroClinicoService(LiteDatabase db)
        {
            _collection = db.GetCollection<RegistroClinico>("registrosClinicos");
        }

        public List<RegistroClinico> GetAll() => _collection.FindAll().ToList();

        public RegistroClinico GetById(int id) => _collection.FindById(id);

        public void Create(RegistroClinico registro) => _collection.Insert(registro);

        public bool Update(int id, RegistroClinico registro)
        {
            if (!_collection.Exists(x => x.IdRegistroClinico == id)) return false;
            _collection.Update(registro);
            return true;
        }

        public bool Delete(int id) => _collection.Delete(id);
    }
}
