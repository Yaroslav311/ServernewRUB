using Microsoft.EntityFrameworkCore;
using ServernewRUB.DataAccess.Core.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServernewRUB.DataAccess.Core.Interfaces.DbcContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
