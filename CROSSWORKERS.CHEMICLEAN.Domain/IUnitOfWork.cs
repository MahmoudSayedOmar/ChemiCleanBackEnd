using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CROSSWORKERS.CHEMICLEAN.Domain
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
    }
}

