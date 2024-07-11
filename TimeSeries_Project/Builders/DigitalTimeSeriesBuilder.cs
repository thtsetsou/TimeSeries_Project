using TimeSeries_Project.Services;
using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project.Builders
{
    public class DigitalTimeSeriesBuilder : TimeSeriesBuilder
    {
        //private TimeSeries timeseries;
        private DigitalTimeSeriesCalculationService digital_service;

        public DigitalTimeSeriesBuilder()
        {
            digital_service = new DigitalTimeSeriesCalculationService();
        }

        public override DigitalTimeSeriesBuilder Build()
        {
            return this;
        }

        public override DigitalTimeSeriesBuilder WithTimeSeries()
        {
            Timeseries = digital_service.Calculate(this);

            return this;
        }

/*        public TimeSeries getTimeseries()
        {
            return Timeseries;
        }*/
    }
}
