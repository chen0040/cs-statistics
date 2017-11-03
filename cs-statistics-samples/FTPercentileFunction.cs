using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Statistics.SpecialFunctions;
using Statistics;

namespace Statistics.FT
{
    public class FTPercentileFunction
    {
        public static void RunExample()
        {
            double q = 1800;
            double mu = 1500;
            double sigma = 300;
            double p = Gaussian.GetPercentile(q, mu, sigma);
            Console.WriteLine("p = {0}", p);

            Console.WriteLine("p = {0}", Gaussian.GetPercentile(50, 45, 3.2));
        }
    }
}
