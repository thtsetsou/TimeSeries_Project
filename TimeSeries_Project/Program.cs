using TimeSeries_Project;
using TimeSeries_Project.TimeSeriesF;

internal class Program
{
    private static void Main(string[] args)
    {
        TimeSeries timeseries = new TimeSeries();

        var factory = new TimeSeriesFactory();

        timeseries = factory.getTimeseriesBuilder(Enumerations.SamplesFreq.every_ten_minutes, new DateTime(2024, 7, 10, 12, 28, 0), 
                                new DateTime(2024, 7, 10, 13, 28, 0), Enumerations.SamplesCh.Real);

        timeseries.PrintList(Enumerations.SamplesCh.Real);

        timeseries = factory.getTimeseriesBuilder(Enumerations.SamplesFreq.every_ten_minutes, new DateTime(2024, 7, 10, 12, 28, 0),
                                new DateTime(2024, 7, 10, 13, 28, 0), Enumerations.SamplesCh.Digital);

        timeseries.PrintList(Enumerations.SamplesCh.Digital);

        timeseries = factory.getTimeseriesBuilder(Enumerations.SamplesFreq.every_ten_minutes, new DateTime(2024, 7, 10, 12, 28, 0),
                                new DateTime(2024, 7, 10, 13, 28, 0), Enumerations.SamplesCh.Categorical);

        timeseries.PrintList(Enumerations.SamplesCh.Categorical);



        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}