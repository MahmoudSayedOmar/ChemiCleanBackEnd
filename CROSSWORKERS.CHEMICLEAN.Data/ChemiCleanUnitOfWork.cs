using CROSSWORKERS.CHEMICLEAN.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CROSSWORKERS.CHEMICLEAN.Data
{
    public partial class ChemiCleanContext : IUnitOfWork
    {
        public void Commit()
        {
            SaveChanges();
        }

        public Task CommitAsync()
        {
            return SaveChangesAsync();
        }
    }

}
