using LinearRegression.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression.Controller
{
    class LinearRegression
    {
        public delegate void CallBack(int iter, double weight,double bias,double cost);
        CallBack call;
        public LinearRegression(CallBack callback)
        {
            call = callback;
        }
        public double predict_sales(double radio, double weight, double bias)
        {
            return weight * radio + bias;
        }

        public double cost_function(double[] radio, double[] sales, double weight, double bias)
        {
            int companies = radio.Length;
            double total_error = 0.0;
            for(int i=0;i<companies;i++)
            {
                total_error += Math.Pow((sales[i] - (weight * radio[i] + bias)), 2);
            }
            return total_error / companies;
        }

        public void update_weights(double[] radio, 
            double[] sales, 
            double weight, 
            double bias, 
            double learning_rate,
            out double weight_new,
            out double bias_new)
        {
            double weight_deriv = 0.0;
            double bias_deriv = 0.0;
            double companies = radio.Length;

            for (int i = 0; i < companies; i++)
            {
                // Calculate partial derivatives
                // -2x(y - (mx + b))
                weight_deriv += -(2) * radio[i] * (sales[i] - (weight * radio[i] + bias));

                // -2(y - (mx + b))
                bias_deriv += -(2) * (sales[i] - (weight * radio[i] + bias));
            }

            // We subtract because the derivatives point in direction of steepest ascent
            weight_new = weight - (weight_deriv / companies) * learning_rate;
            bias_new = bias - (bias_deriv / companies) * learning_rate;
        }

        public TrainResult train(double[] radio,
            double[] sales,
            double weight,
            double bias,
            double learning_rate,
            int iters) {
            List<double> cost_history = new List<double>();



            for (int i = 0; i < iters; i++)
            {
                double weightNew=0, biasNew=0;
                update_weights(radio, sales, weight, bias, learning_rate, out weightNew, out biasNew);

                // Calculate cost for auditing purposes
                weight = weightNew;
                bias = biasNew;
                double cost = cost_function(radio, sales, weight, bias);
                cost_history.Add(cost);

                // Log Progress
                if (i % 10 == 0)
                {
                    call(i, weight, bias, cost);
                }
            }
            return new TrainResult(weight, bias, cost_history);
        }
    }
}
