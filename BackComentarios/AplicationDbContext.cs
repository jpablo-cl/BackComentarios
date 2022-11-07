using BackComentarios.Models;
using Microsoft.EntityFrameworkCore;

namespace BackComentarios
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Comentario> comentario { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext>options):base(options) 
        {
            fgfd
        }
    }
}
