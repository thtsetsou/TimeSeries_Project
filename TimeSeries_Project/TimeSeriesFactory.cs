using TimeSeries_Project.Builders;
using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project
{
    public class TimeSeriesFactory
    {
        public TimeSeries getTimeseriesBuilder(Enumerations.SamplesFreq freq, DateTime sampleStart, DateTime sampleEnd, Enumerations.SamplesCh ch)
        {
            TimeSeriesBuilder sampleBuilder = null;
            
            switch ((int) ch)
            {              
                case 0:
                    sampleBuilder = new RealTimeSeriesBuilder();

                    sampleBuilder.WithsamplingRate(freq)
                        .WithTimeduration(sampleStart, sampleEnd)
                        .WithsamplesCount()
                        .WithTimeSeries();
                    //.Build();

                    break;

                case 1:
                    sampleBuilder = new DigitalTimeSeriesBuilder();

                    sampleBuilder.WithsamplingRate(freq)
                        .WithTimeduration(sampleStart, sampleEnd)
                        .WithsamplesCount()
                        .WithTimeSeries();
                    //.Build();

                    break;

                case 2:
                    sampleBuilder = new CategoricalTimeSeriesBuilder();

                    sampleBuilder.WithsamplingRate(freq)
                        .WithTimeduration(sampleStart, sampleEnd)
                        .WithsamplesCount()
                        .WithTimeSeries();
                    //.Build();

                    break;

                default:
                    throw new NullReferenceException("There is no such type of sample");
            }


            return sampleBuilder.getTimeseries();
        }
    }
}
