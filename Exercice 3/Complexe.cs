using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    public class Complexe
    {

        public int partReel { get; set; }

        public int partImagin { get; set; }

        public Complexe(int partReel, int partImagin)
        {
            this.partReel = partReel;
            this.partImagin = partImagin;
        }


        public override string ToString()
        {
            return $"Nomre {partReel} , {partImagin} ";
        }


        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(partReel, 2) + Math.Pow(partImagin, 2));
        }


        public static string Sum(Complexe c1, Complexe c2)
        {
            return $"{ c1.partReel + c2.partReel} {c1.partImagin + c2.partImagin }";
        }
    }
}
