using TimeSeries_Project.Builders;
using TimeSeries_Project.Samples;
using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project.Services
{
    public class RealTimeSeriesCalculationService : ITimeSeriesCalculationService
    {
        public const double Min = 1;
        public const double Max = 100;

        public TimeSeries Calculate(object obj)
        {
            var random = new Random();

            var ts = new TimeSeries();

            var real_builder = (RealTimeSeriesBuilder)obj;

            var sr = real_builder.getTimeseries().samplingRate;
            var time = real_builder.getTimeseries().sampleStart;

            for (int i = 0; i < real_builder.getTimeseries().samplesCount; i++)
            {
                //var dt = DateTime.Now;
                var v = random.NextDouble() * (Max - Min) + Min;

                var s = new RealSample();
                s.timestamp = time;
                s.Value = v;

                ts.samples.Add(s);

                time = time.AddSeconds(Convert.ToDouble(sr));
            }

            return ts;
        }
    }
}
