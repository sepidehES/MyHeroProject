using Hero_VS_Monstre.Combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Models
{
    public abstract class Hero : Personnages
    {
        public Hero(string nom) : base(nom)
        {
            Mort.MortEvent += Loot; 
        }
        public void Loot(Personnages monstre)
        {
            this.Sac.SacAjouter(monstre.Sac.Cuir, monstre.Sac.Or);
            this.AfficheInventaire();


        }
    }
}
