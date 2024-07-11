using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project.Builders
{
    public abstract class TimeSeriesBuilder : IBuilder
    {
        protected TimeSeries Timeseries;

        protected TimeSeriesBuilder()
        {
            Timeseries = new TimeSeries();    
        }

        public IBuilder WithsamplingRate(Enumerations.SamplesFreq samplingRate)
        {
            Timeseries.samplingRate = samplingRate;

            return this;
        }

        public IBuilder WithTimeduration(DateTime startTime, DateTime endTime)
        {
            Timeseries.sampleStart = startTime;
            Timeseries.sampleEnd = endTime;

            Timeseries.duration = endTime - startTime;

            return this;
        }

        public IBuilder WithsamplesCount()
        {
            Timeseries.samplesCount = (int) Timeseries.duration.TotalSeconds / (int) Timeseries.samplingRate;

            return this;
        }

        public abstract IBuilder WithTimeSeries();
        public TimeSeries getTimeseries()
        {
            return Timeseries;
        }

        public abstract IBuilder Build();
    }
}
