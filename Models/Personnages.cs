using Hero_VS_Monstre.Combat;
using Hero_VS_Monstre.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Models
{
    public abstract class Personnages
    {
        public Stats St { get; set; }
        public Coordonees Coor { get; set; }
        public string Nom { get; set; }
        public Inventaire Sac { get; set; }


        public Personnages(string nom) 
        {
            Nom = nom;
            St = new Stats();
            Coor = new Coordonees();
            Sac = new Inventaire();
        }
        public void AfficheInventaire()
        {
            Console.WriteLine($"Inventaire de {Nom} :");
            Console.WriteLine($"Cuir : {Sac.Cuir}");
            Console.WriteLine($"Or : {Sac.Or}");
        }
    }

}
