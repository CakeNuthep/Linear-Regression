using CsvHelper;
using LinearRegression.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression.Controller
{
    class LoadData
    {
        public LoadData()
        {

        }
        public List<Data> readCsv(string pathCSVFile)
        {

            List<Data> listData = new List<Data>();
            using (TextReader reader = File.OpenText(pathCSVFile))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    Data Record = csv.GetRecord<Data>();
                    listData.Add(Record);
                }
            }
            return listData;
        }

        public void load(
            string pathCSVFile,
            out double[] TV,
            out double[] radio,
            out double[] newspaper,
            out double[] sales)
        {
            List<Data> data = readCsv(pathCSVFile);
            TV = new double[data.Count];
            radio = new double[data.Count];
            newspaper = new double[data.Count];
            sales = new double[data.Count];
            for(int i=0;i<data.Count;i++)
            {
                TV[i] = data[i].TV;
                radio[i] = data[i].radio;
                newspaper[i] = data[i].newspaper;
                sales[i] = data[i].sales;
            }

        }
    }
}
