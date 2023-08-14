using ddd.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd.domain.Interfaces
{
    public interface IUnitOfWork
    {
    {
        Task<int> SaveChangesAsync();
        IAsyncRepository<T> Repository<T>() where T : BaseEntity;
    }
}
}
