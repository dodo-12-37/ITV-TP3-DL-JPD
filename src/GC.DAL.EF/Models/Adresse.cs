using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.DAL.EF.Models
{
    internal class Adresse
    {
        public Adresse() { }

        public Adresse(GC.Entites.Adresse p_adresse, Guid p_clientId)
        {
            this.AdresseId = p_adresse.AdresseId;
            this.NumeroCivique = p_adresse.NumeroCivique;
            this.InformationComplementaire = p_adresse.InformationSupplementaire;
            this.Odonyme = p_adresse.Odonyme;
            this.TypeVoie = p_adresse.TypeVoie;
            this.CodePostal = p_adresse.CodePostal;
            this.NomMunicipalite = p_adresse.NomMunicipalite;
            this.Etat = p_adresse.Etat;
            this.Pays = p_adresse.Pays;
            this.ClientId = p_clientId;
        }

        public Guid AdresseId { get; set; } = Guid.Empty;
        public int NumeroCivique { get; set; } = 0;
        public string InformationComplementaire { get; set; } = string.Empty;
        public string Odonyme { get; set; } = string.Empty;
        public string TypeVoie { get; set; } = string.Empty;
        public string CodePostal { get; set; } = string.Empty;
        public string NomMunicipalite { get; set; } = string.Empty;
        public string Etat { get; set; } = string.Empty;
        public string Pays { get; set; } = string.Empty;
        public Guid ClientId { get; set; } = Guid.Empty;

        public GC.Entites.Adresse VersEntite()
        {
            return new GC.Entites.Adresse(this.AdresseId, this.NumeroCivique, this.InformationComplementaire, this.Odonyme, this.TypeVoie, this.CodePostal, this.NomMunicipalite, this.Etat, this.Pays);
        }
    }
}
