using TimeSeries_Project.Services;
using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project.Builders
{
    public class RealTimeSeriesBuilder : TimeSeriesBuilder
    {
        //private TimeSeries timeseries;
        private RealTimeSeriesCalculationService real_service;

        public RealTimeSeriesBuilder()
        {
            real_service = new RealTimeSeriesCalculationService();
        }

        public override RealTimeSeriesBuilder WithTimeSeries()
        {
            Timeseries = real_service.Calculate(this);

            return this;
        }

        public override RealTimeSeriesBuilder Build()
        {
            return this;
        }

/*        public TimeSeries getTimeseries()
        {
            return Timeseries;
        }*/
    }
}
