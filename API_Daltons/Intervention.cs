//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Daltons
{
    using System;
    using System.Collections.Generic;
    
    public partial class Intervention
    {
        public int id_intervention { get; set; }
        public int id_societe { get; set; }
        public System.DateTime date_intervention { get; set; }
        public int id_technicien { get; set; }
        public int id_motif { get; set; }
        public int id_etat { get; set; }
        public Nullable<int> id_compte_rendu { get; set; }
    
        public virtual Compte_rendu Compte_rendu { get; set; }
        public virtual Etat_intervention Etat_intervention { get; set; }
        public virtual Motif_intervention Motif_intervention { get; set; }
        public virtual Societe Societe { get; set; }
        public virtual Technicien Technicien { get; set; }
    }
}
