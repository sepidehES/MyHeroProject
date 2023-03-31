using Hero_VS_Monstre.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Models
{
    public class Dragonnet : Monstre
    {
        public Dragonnet(string nom) : base(nom) 
        {
            Sac.SacMonstre("dragonnet");
            St = new Stats("dragonnet");
        }
    }
}
