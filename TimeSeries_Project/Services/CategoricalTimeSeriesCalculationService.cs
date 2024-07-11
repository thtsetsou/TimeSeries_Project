using TimeSeries_Project.Builders;
using TimeSeries_Project.Samples;
using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project.Services
{
    public class CategoricalTimeSeriesCalculationService : ITimeSeriesCalculationService
    {

        public TimeSeries Calculate(object obj)
        {
            var random = new Random();

            var ts = new TimeSeries();

            var categorical_builder = (CategoricalTimeSeriesBuilder)obj;

            var sr = categorical_builder.getTimeseries().samplingRate;
            var time = categorical_builder.getTimeseries().sampleStart;

            for (int i = 0; i < categorical_builder.getTimeseries().samplesCount; i++)
            {               
                //var dt = DateTime.Now;

                var randomv = Enum.GetValues(typeof(Enumerations.CategoricalValue));
                var v = (Enumerations.CategoricalValue)randomv.GetValue(random.Next(randomv.Length));

                var s = new CategoricalSample();
                s.timestamp = time;
                s.Value = v;

                ts.samples.Add(s);

                time = time.AddSeconds(Convert.ToDouble(sr));
            }


            return ts;
        }
    }
}
