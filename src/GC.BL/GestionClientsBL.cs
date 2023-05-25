using GC.Entites;
using GC.GenererDonnees;

namespace GC.BL
{
    public class GestionClientsBL
    {
        private IDepotClients m_depotClients;
        public GestionClientsBL(IDepotClients p_depotClients)
        {
            if (p_depotClients is null)
            {
                throw new ArgumentNullException(nameof(p_depotClients));
            }

            this.m_depotClients = p_depotClients;
        }

        public List<Client> ObtenirClients()
        {
            return this.m_depotClients.ListerClients();
        }

        public void GenererEtAjouterClientsPourDemos(int p_nombreClients = 5)
        {
            if (p_nombreClients <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_nombreClients));
            }

            List<Client> clients = GenerateurDonnees.GenererClients(p_nombreClients);
            clients.ForEach(c => this.m_depotClients.AjouterClient(c));
        }
    }
}