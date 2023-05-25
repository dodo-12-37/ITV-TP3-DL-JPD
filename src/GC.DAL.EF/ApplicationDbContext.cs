using Duende.IdentityServer.EntityFramework.Options;
using GC.DAL.EF.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GC.DAL.EF
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
            ;
        }

        internal DbSet<Client> Clients => Set<Client>();
        //internal DbSet<Adresse> Adresses { get; set; }
    }
}