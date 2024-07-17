using Microsoft.EntityFrameworkCore;
using TutApp.Api.Entities;

namespace TutApp.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
    : DbContext
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();
}
 