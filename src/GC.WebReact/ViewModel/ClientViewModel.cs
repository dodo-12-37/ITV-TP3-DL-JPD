using GC.Entites;

namespace GC.WebReact.ViewModel
{
    public class ClientViewModel
    {
        public ClientViewModel() { }

        public ClientViewModel(Client p_client)
        {
            this.ClientId = p_client.ClientId;
            this.Nom = p_client.Nom;
            this.Prenom = p_client.Prenom;
        }

        public Guid ClientId { get; set; } = Guid.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
    }
}
