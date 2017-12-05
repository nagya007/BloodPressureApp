using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BloodPressureLogApp.BAL
{
    class GraficLogicService
    {
        static GraficLogicService instance = null;
        public static GraficLogicService getInstance()
        {
            if (instance == null)
            {
                instance = new GraficLogicService();
            }
            return instance;
        }
        public Series Draw(IQueryable<Entry> entries, string type)
        {
            var series = new Series();
            series.XValueType = ChartValueType.DateTime;

            foreach (var entry in entries.OrderByDescending(entry => entry.Date))
            {
                DataPoint dataPoint = new DataPoint();
                switch(type.ToLower())
                {
                    case "sys":
                        dataPoint.SetValueXY(entry.Date, entry.Sys);
                        break;
                    case "dia":
                        dataPoint.SetValueXY(entry.Date, entry.Dia);
                        break;
                    case "pulse":
                        dataPoint.SetValueXY(entry.Date, entry.Pulse);
                        break;
                }
                series.Points.Add(dataPoint);
            }
            return series;
        }
        public Series DrawCorrelation(IQueryable<Entry> entries)
        {
            var series = new Series();
            foreach (var entry in entries.OrderByDescending(entry => entry.Date))
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(entry.Sys, entry.Dia);
                series.Points.Add(dataPoint);
            }
            return series;         

        }
        public Series DrawDistribution(Dictionary<int, int> entries)
        {
            var series = new Series();
            foreach (var entry in entries)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(entry.Key, entry.Value);
                series.Points.Add(dataPoint);
            }
            return series;
        }
 }
}
