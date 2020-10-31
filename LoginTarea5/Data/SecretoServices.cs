
using LoginTarea5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class SecretoServices
    {
        private readonly ApplicationDbContext _db;
        public SecretoServices(ApplicationDbContext db)
        {
            _db = db;

        }
        public List<SecretosModel> GetIlegalinfos()
        {
            var ilegal = _db.Secretos.ToList();
            return ilegal;
        }
        public string Create(SecretosModel objinfo)
        {
            _db.Secretos.Add(objinfo);
            _db.SaveChanges();
            return "Guardado";
        }

        public SecretosModel GetIlegalinfoById(int id)
        {
            SecretosModel ilegal = _db.Secretos.FirstOrDefault(s => s.id == id);
            return ilegal;
        }
        public string Deleteinfo(SecretosModel objinfo)
        {
            _db.Remove(objinfo);
            _db.SaveChanges();
            return "Borrado";
        }
    }
}
