using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    public class Canard : Volaille
    {

        public static float PrixDuJour = 1.85f;

        public static float PoidsAbattageMini = 2.85f;

        public Canard(float poids) : base(poids)
        {

        }

        public Canard(float poids, int age, float prixdujour, float poidsabbatage) : base(poids, age)
        {
            PrixDuJour= prixdujour;
            PoidsAbattageMini= poidsabbatage;
        }

        public override string Description()
        {
            return base.Description() + $" :: {PrixDuJour} €/kg ";
        }

        public bool PeutEtreVendu()
        {
            if(Poids == PoidsAbattageMini)
            {
                return true;
            }
            else
                return false;
                
        }

        public float AffichePrixDeVente()
        {
            if (PeutEtreVendu())
                return PrixDuJour;
            else
                return 0f;
        }

    }
}
