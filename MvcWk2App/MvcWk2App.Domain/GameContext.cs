using MvcWk2App.Domain.Entities;
using System.Data.Entity;

namespace MvcWk2App.Domain
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
