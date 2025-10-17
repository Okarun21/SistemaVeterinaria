using LiteDB;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Modelo_Veterinaria.Services
{
    public class HistorialClinicoService
    {
        private ILiteCollection<RegistroClinico> _collection;

        public HistorialClinicoService(LiteDatabase db)
        {
            _collection = db.GetCollection<RegistroClinico>("registrosClinicos");
        }

        public List<RegistroClinico> GetAllRecords() => _collection.FindAll().ToList();

    }
}
