using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    /* This is the interface for the TrakiDbContext. It is used to define the properties and table that will be
    used in the TrakiDbContext. */
    public interface ITrakiDbContext
    {
         DbSet<Team> Teams {get; set;}
         DbSet<TeamMembers> TeamMembers {get; set;}
         DbSet<Bug> Bugs {get; set;}

         Task<int> SaveChangesAsync(CancellationToken cancellationToken);
         
    }
}