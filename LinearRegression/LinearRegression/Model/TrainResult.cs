using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression.Model
{
    class TrainResult
    {
        public double Weight { get; set; }
        public double Bias { get; set; }
        public List<double> CostHistory { get; set; }

        public  TrainResult(double weight, double bias, List<double> const_history)
        {
            Weight = weight;
            Bias = bias;
            CostHistory = const_history;
        }
    }
}
