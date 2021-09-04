using System;

public class YearLessThen1582Exception : Exception
{
    public YearLessThen1582Exception()
    {
    }

    public YearLessThen1582Exception(string message)
        : base(message)
    {
    }
}