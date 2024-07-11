A project using Builder and Factory pattern.
A project implementing Timeseries.

Timeseries consists of RealSample, DigitalSample or CategoricalSample, which all inherit from Sample class.
Sample have a timestamp and each subclass has its own type of value (enum, bool, double respectively).
