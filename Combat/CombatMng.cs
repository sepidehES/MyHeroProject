using Hero_VS_Monstre.Enum;
using Hero_VS_Monstre.Models;
using Hero_VS_Monstre.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Combat
{
    public class CombatMng
    {
        public void Frapper(Personnages cible, Personnages attaquant) 
        {
            int degat = Degat(attaquant.St.Force);

            cible.St.PointDeVie -= degat;
            Console.WriteLine($"{attaquant.Nom} attaque {cible.Nom} pour { degat } dégats. il reste {cible.St.PointDeVie}");
            if (!cible.St.EstVivant)
            {

                Console.WriteLine($"{cible.Nom} est mort");
            }

        }
        public int Degat(int force)
        {

            return Dice.Lancer(1,(int) DiceType.D4) + Modificateur.Modif(force);
        }
        public void Combat(Personnages hero, Personnages monstre)
        {
            while (hero.St.EstVivant && monstre.St.EstVivant)
            {
                Frapper(monstre, hero);
                if (monstre.St.EstVivant)
                    Frapper(hero, monstre);
            }
            if (hero.St.EstVivant)
            {
                if (Mort.releaseMort != null)
                    Mort.releaseMort(monstre);
                hero.St.PointDeVie = hero.St.MaxPV;
            }
        } 
    }
}
