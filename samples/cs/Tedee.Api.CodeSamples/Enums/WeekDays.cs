using System;

namespace Tedee.Api.CodeSamples.Enums
{
    [Flags]
    public enum WeekDays
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
    }
}
