﻿namespace FactoryMethod.Filters
{
    internal interface IBarclaysFilterCreator
    {
        IFilter? Create(Country country);
    }
}
