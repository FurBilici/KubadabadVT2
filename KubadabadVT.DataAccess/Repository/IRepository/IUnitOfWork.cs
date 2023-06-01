using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubadabadVT.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IAçmaListesiRepository AçmaListesi { get; }
        IRaporRepository AçmaRapor { get; }
        IBuluntularRepository Buluntular { get; }

        void Save();
    }
}
