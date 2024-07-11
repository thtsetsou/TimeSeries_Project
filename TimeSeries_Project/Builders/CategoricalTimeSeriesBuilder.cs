using TimeSeries_Project.Services;
using TimeSeries_Project.TimeSeriesF;

namespace TimeSeries_Project.Builders
{
    public class CategoricalTimeSeriesBuilder : TimeSeriesBuilder
    {
        //private TimeSeries timeseries;
        private CategoricalTimeSeriesCalculationService categorical_service;

        public CategoricalTimeSeriesBuilder()
        {
            categorical_service = new CategoricalTimeSeriesCalculationService();
        }

        public override CategoricalTimeSeriesBuilder Build()
        {
            return this;
        }

        public override CategoricalTimeSeriesBuilder WithTimeSeries()
        {
            Timeseries = categorical_service.Calculate(this);

            return this;
        }

/*        public TimeSeries getTimeseries()
        {
            return Timeseries;
        }*/
    }
}
