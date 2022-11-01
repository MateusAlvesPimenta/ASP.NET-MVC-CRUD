using EstudosMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudosMvc.Context
{
    public class AgendaMvcContext : DbContext
    {
        public AgendaMvcContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}