﻿namespace Oxide.Converters
{
    public interface IConverter<T, T0>
    {
        T0 Convert(T input);
    }
}
