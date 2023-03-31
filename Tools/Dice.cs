using Hero_VS_Monstre.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Tools
{
    public class Dice
    {
        public static int Lancer(int nbD = 4, int dice = (int) DiceType.D6)
        {
            List<int> diceList = new List<int> ();
            Random rnd = new Random();

            for (int i = 0; i < nbD; i++)
            {
                diceList.Add(rnd.Next(dice) + 1);

            }

            if(diceList.Count > 2)
            {
                diceList.Sort();
                diceList.RemoveAt(0);
            }
  

            return diceList.Sum();
        }


    }


   
}

