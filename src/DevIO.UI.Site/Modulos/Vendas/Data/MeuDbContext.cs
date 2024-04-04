
using Microsoft.EntityFrameworkCore;

namespace DevIO.UI.Site.Modulos.Vendas.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {

        }
    }

}