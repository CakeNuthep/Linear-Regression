using LinearRegression.Controller;
using LinearRegression.Model;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearRegression
{
    public partial class Form1 : Form
    {
        public SeriesCollection seriesCollection;
        double[] TV, radio, newspaper, sales;
        LinearRegression.Controller.LinearRegression linearRegression;

        private void button_run_Click(object sender, EventArgs e)
        {
            
            double weight;
            double bias;
            double learning_rate;
            int iters;
            string pathFile = textBox_pathFile.Text;
            if (double.TryParse(textBox_weight.Text, out weight)
                && double.TryParse(textBox_bias.Text, out bias)
                && int.TryParse(textBox_iter.Text, out iters)
                && double.TryParse(textBox_learningRate.Text, out learning_rate)
                && File.Exists(pathFile))
            {
                double x0;
                double y0;
                double x1;
                double y1;
                LoadData loadData = new LoadData();
                loadData.load(pathFile,
                    out TV,
                    out radio,
                    out newspaper,
                    out sales);

                linearRegression = new LinearRegression.Controller.LinearRegression(call);
                x0 = 0;
                x1 = radio.Max();
                y0 = linearRegression.predict_sales(x0, weight, bias);
                y1 = linearRegression.predict_sales(x1, weight, bias);
                if (seriesCollection == null)
                {
                    initialGraph(x0, y0, x1, y1, radio, sales);
                }
                TrainResult result = linearRegression.train(radio, sales, weight, bias, learning_rate, iters);
                updateUI(result.Weight, result.Bias);
            }
        }

        private void button_browseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse csv Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_pathFile.Text = openFileDialog1.FileName;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void initialGraph(double x0,double y0,double x1,double y1,double[] radio,double[] sales)
        {
            seriesCollection = new SeriesCollection
            {

                new ScatterSeries
                {
                    Title = "Data",
                    Values = new ChartValues<ObservablePoint>(),
                    StrokeThickness = 2
                },
                new LineSeries
                {
                    Title = "Predict",
                    Values = new ChartValues<ObservablePoint>()
                }
            };

            for (int indexData = 0; indexData < radio.Length; indexData++)
            {
                    seriesCollection[0].Values.Add(
                        new ObservablePoint(radio[indexData], sales[indexData]));
            }
            seriesCollection[1].Values.Add(new ObservablePoint(x0, y0));
            seriesCollection[1].Values.Add(new ObservablePoint(x1, y1));
            cartesianChart1.Series = seriesCollection;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        public void updateUI(double weight,double bias)
        {
            double x0 = 0;
            double y0 = linearRegression.predict_sales(x0, weight, bias);
            double x1 = radio.Max();
            double y1 = linearRegression.predict_sales(x1, weight, bias);
            seriesCollection[1].Values[0] = new ObservablePoint(x0, y0);
            seriesCollection[1].Values[1] = new ObservablePoint(x1, y1);
            textBox_bias.Text = bias.ToString();
            textBox_weight.Text = weight.ToString();
        }

        public void call(int iter, double weight, double bias, double cost)
        {
            
            Console.WriteLine("iter={0}    weight={1:F2}    bias={2:F4}    cost={3:F2}", iter, weight, bias, cost);
        }
    }
}
