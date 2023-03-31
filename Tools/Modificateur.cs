using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Tools
{
    public class Modificateur
    {
        public static int Modif(int carac)
        {
            int bonus = 0;
            if (carac < 5)
                bonus = -1;

            else if (carac < 10)
                bonus = 0;

            else if (carac < 15)
                bonus = 1;
            else
                bonus = 2;

            return bonus; 

        }

    }
}
