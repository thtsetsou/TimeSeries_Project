using TimeSeries_Project.Builders;
using TimeSeries_Project.Samples;

namespace TimeSeries_Project.TimeSeriesF
{
    public class TimeSeries : ITimeSeries
    {
        public List<Sample> samples { get; set; }
        public Enumerations.SamplesFreq samplingRate { get; set; }
        public TimeSpan duration { get; set; }
        public int samplesCount { get; set; }
        public DateTime sampleStart { get; set; }
        public DateTime sampleEnd { get; set; }

        public TimeSeries()
        {
            samples = new List<Sample>();
        }

        public void PrintList(Enumerations.SamplesCh ch)
        {
            switch ((int)ch)
            {
                case 0:
                    foreach (var sample in samples)
                    {
                        Console.WriteLine(sample.timestamp + " and " + ((RealSample)sample).Value);
                    }

                    break;

                case 1:
                    foreach (var sample in samples)
                    {
                        Console.WriteLine(sample.timestamp + " and " + Convert.ToInt32(((DigitalSample)sample).Value));
                    }

                    break;

                case 2:
                    foreach (var sample in samples)
                    {
                        Console.WriteLine(sample.timestamp + " and " + ((CategoricalSample)sample).Value);
                    }

                    break;
            }


        }
    }
}
