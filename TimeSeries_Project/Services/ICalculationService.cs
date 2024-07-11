namespace TimeSeries_Project.Services
{
    public interface ICalculationService<TCalc> where TCalc : class
    {
        TCalc Calculate(object obj);
    }
}
