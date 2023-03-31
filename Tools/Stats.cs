using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_VS_Monstre.Tools
{
    public class Stats
    {
        private int _pointDeVie;
        public int EnduranceBase { get; private set; }
        public int Endurance { get; private set; }
        public int ForceBase { get; private set; }
        public int Force { get; private set; }
        public int MaxPV { get; private set; }
        public int PointDeVie 
        {
            get { return _pointDeVie; }
            set
            {
                _pointDeVie = value;
                if (_pointDeVie <= 0)
                {
                    _pointDeVie = 0;
                }
            }
        }
        public string Type { get; set; }
        public bool EstVivant => PointDeVie > 0;




        public Stats(string type = "") 
        {
            MaxPV = PointDeVie;
            Type = type;
            EnduranceBase = Dice.Lancer();
            Endurance = EnduranceBase;
            ForceBase = Dice.Lancer();
            Force = ForceBase;
            PointDeVie = EnduranceBase + Modificateur.Modif(EnduranceBase) ;
            if (type != null)
                CalculeBonus();
        }

        public void CalculeBonus()
        {
            switch (Type)
            {
                case "orque":
                    Force = ForceBase + 1;
                    break;
                case "dragonnet":
                    Endurance = EnduranceBase + 1;
                    break;
                case "humain":
                    Force = ForceBase + 1;
                    Endurance = EnduranceBase + 1;
                    break;
                case "nain":
                    Endurance = EnduranceBase + 2;
                    break;


            }
        }
    }
    
}
