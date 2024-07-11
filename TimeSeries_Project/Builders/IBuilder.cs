namespace TimeSeries_Project.Builders
{
    public interface IBuilder
    {
        IBuilder WithsamplingRate(Enumerations.SamplesFreq samplingRate);
        IBuilder WithTimeduration(DateTime startTime, DateTime endTime);
        IBuilder WithTimeSeries();
        IBuilder WithsamplesCount();
        IBuilder Build();
    }
}
