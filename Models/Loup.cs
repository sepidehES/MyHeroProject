using Hero_VS_Monstre.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Models
{
    public class Loup : Monstre
    {
        public Loup(string nom) : base(nom)
        {
            Sac.SacMonstre("loup");


        }
    }
}
