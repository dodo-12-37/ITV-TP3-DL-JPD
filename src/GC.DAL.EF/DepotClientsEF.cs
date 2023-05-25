using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GC.DAL.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace GC.DAL.EF
{
    public class DepotClientsEF : GC.Entites.IDepotClients
    {
        private readonly ApplicationDbContext _context;

        public DepotClientsEF(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public void AjouterClient(GC.Entites.Client p_client)
        {
            this._context.Add<Client>(new Client(p_client));
            this._context.SaveChanges();
        }

        public List<GC.Entites.Client> ListerClients()
        {
            return this._context.Clients.Include(c => c.Adresses).Select(c => c.VersEntite()).ToList();
        }

        public void ModifierClient(GC.Entites.Client p_client)
        {
            throw new NotImplementedException();
        }

        public GC.Entites.Client RechercherClient(Guid p_guid)
        {
            throw new NotImplementedException();
        }
    }
}
