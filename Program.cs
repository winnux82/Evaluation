using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Poulet poulet_1 = new Poulet(0.9f);
            Poulet poulet_2 = new Poulet(1.15f);
            
            Canard canard_3 = new Canard(0.85f);
            Canard canard_4 = new Canard(1.05f);
            Canard canard_5 = new Canard(0.95f);

            List<Poulet> ListePoulets = new List<Poulet>();
            ListePoulets.Add(poulet_1);
            ListePoulets.Add(poulet_2);


            List<Volaille> ListeVolailles = new List<Volaille>();
            ListeVolailles.Add(poulet_1);
            ListeVolailles.Add(poulet_2);
            ListeVolailles.Add(canard_3);
            ListeVolailles.Add(canard_4);
            ListeVolailles.Add(canard_5);




            poulet_1.Poids = 2.6f;
            poulet_2.Poids = 2.45f;
            canard_3.Poids = 2.8f;
            canard_4.Poids = 3.1f;
            canard_5.Poids = 2.86f;




            foreach (Volaille v in ListeVolailles)

            {
                v.Age = 8;
                Console.WriteLine(v.Description());
            }



        }
    }
}
