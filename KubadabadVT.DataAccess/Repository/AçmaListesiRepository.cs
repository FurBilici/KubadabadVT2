using KubadabadVT.DataAccess.Data;
using KubadabadVT.DataAccess.Repository.IRepository;
using KubadabadVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubadabadVT.DataAccess.Repository
{
    public class AçmaListesiRepository : Repository<AçmaListesi>, IAçmaListesiRepository
    {
        private ApplicationDbContext _db;
        public AçmaListesiRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(AçmaListesi obj)
        {
            _db.AçmaListesis.Update(obj);
        }
    }
}
