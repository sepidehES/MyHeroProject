using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Models
{
    public abstract class Monstre : Personnages
    {
        public Monstre(string nom) : base(nom) 
        {
        }
    }
}
