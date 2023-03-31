using Hero_VS_Monstre.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Models
{
    public class Orque : Monstre
    {
        public Orque(string nom) : base(nom)
        {
            St = new Stats("orque");
            Sac.SacMonstre("orque");
        }
    }
}
