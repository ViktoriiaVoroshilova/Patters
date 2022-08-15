﻿namespace AbstractFactory.Filters
{
    public interface IFilter
    {
        IEnumerable<Trade> Match(IEnumerable<Trade> trades);
    }
}
