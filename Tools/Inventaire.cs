using Hero_VS_Monstre.Enum;
using Hero_VS_Monstre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Tools
{
    public class Inventaire
    {
        public int Or {  get; set; }
        public int Cuir { get; set; }
        public Inventaire() 
        { 
            Or = 0;
            Cuir = 0;
        }

        public void SacMonstre(string monstre) 
        {
            switch (monstre)
            {
                case "loup":
                    Cuir = Dice.Lancer(1,(int) DiceType.D4);
                break;
                case "orque":
                    Or = Dice.Lancer(1, (int)DiceType.D6);
                break;
                case "dragonnet":
                    Cuir = Dice.Lancer(1, (int)DiceType.D4);
                    Or = Dice.Lancer(1, (int)DiceType.D6);
                break;
            }

        }
        public void SacAjouter(int cuir = 0, int or = 0)
        {
            Cuir += cuir;
            Or += or;
        }
    }
}
