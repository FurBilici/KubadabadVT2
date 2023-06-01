﻿using KubadabadVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubadabadVT.DataAccess.Repository.IRepository
{
    public interface IAçmaListesiRepository : IRepository<AçmaListesi>
    {
        void Update(AçmaListesi obj);
    }
}
