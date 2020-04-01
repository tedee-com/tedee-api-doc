using System;

namespace Tedee.Api.CodeSamples.Enums
{
    public class RepeatEvent
    {
        public int Id { get; set; }
        public WeekDays? WeekDays { get; set; }
        public DateTime? DayStartTime { get; set; }
        public DateTime? DayEndTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
