using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    public class Poulet : Volaille
    {

        public static float PrixDuJour = 1.5f;

        public static float PoidsAbattageMini = 2.5f;

        public Poulet(float poids) : base(poids)
        {

        }
        public Poulet(float poids, int age, float prixdujour, float poidsabbatage) : base(poids, age)
        {
            PrixDuJour= prixdujour;
            PoidsAbattageMini= poidsabbatage;
        }

        public override string Description()
        {
            return base.Description() + $"  :: {PrixDuJour} €/kg ";
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
