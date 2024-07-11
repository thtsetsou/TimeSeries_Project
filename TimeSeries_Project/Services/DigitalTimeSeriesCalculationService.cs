using TimeSeries_Project.Builders;
using TimeSeries_Project.Samples;
using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project.Services
{
    public class DigitalTimeSeriesCalculationService : ITimeSeriesCalculationService
    {
        public TimeSeries Calculate(object obj)
        {
            var random = new Random();

            var ts = new TimeSeries();

            var digital_builder = (DigitalTimeSeriesBuilder)obj;

            var sr = digital_builder.getTimeseries().samplingRate;
            var time = digital_builder.getTimeseries().sampleStart;

            for (int i = 0; i < digital_builder.getTimeseries().samplesCount; i++)
            {            
                //var dt = DateTime.Now;
                var v = random.Next(2);

                var s = new DigitalSample();
                s.timestamp = time;
                s.Value = Convert.ToBoolean(v);

                ts.samples.Add(s);

                time = time.AddSeconds(Convert.ToDouble(sr));
            }

            return ts;
        }
    }

}
