namespace TimeSeries_Project
{
    public class Enumerations
    {
        public enum CategoricalValue
        {
            starting,
            running,
            slowing,
            closing
        }

        public enum SamplesFreq
        {
            every_second = 1,
            every_minute = 60,
            every_ten_minutes = 600
        }

        public enum SamplesCh
        {
            Real,
            Digital,
            Categorical
        }
    }
}
