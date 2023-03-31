using Hero_VS_Monstre.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Combat
{
    public class Mort
    {
        public static event Action<Personnages> MortEvent;

        public static void releaseMort(Personnages cible)
        {
            MortEvent?.Invoke(cible);
        }
    }

}
