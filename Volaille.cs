using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    public class Volaille
    {
        #region attributs
        private static int inc = 1;

		private int _identifiant;
        private float _poids;
        private int _age;
        private DateTime _dateenregistrement;
        #endregion

        #region accesseurs
        public int Identifiant
		{
			get { return _identifiant; }
			set { _identifiant = value; }
		}
		public float Poids
		{
			get { return _poids; }
			set { _poids = value; }
		}
		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
		public DateTime DateEnregistrement
		{
			get { return _dateenregistrement; }
			set { _dateenregistrement = value; }
		}
        #endregion
        #region constructeurs
        public Volaille(float poids)
        {

            Identifiant = inc;
            inc++;
            Poids = poids;
            Age = 0;
            DateEnregistrement =DateTime.Now;
        }

        public Volaille(float poids, int age):this(poids)
        {
            Age = 3;

        }
        #endregion

        #region Methods
        public virtual string Description()
        {
            return $"{Identifiant} :: {Age} semaines :: {Poids} Kg :: {DateEnregistrement.ToShortDateString()}";
        }
        #endregion

    }
}
