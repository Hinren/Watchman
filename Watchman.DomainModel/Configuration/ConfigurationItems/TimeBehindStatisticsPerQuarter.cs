﻿using System;

namespace Watchman.DomainModel.Configuration.ConfigurationItems
{
    public class TimeBehindStatisticsPerQuarter : MappedConfiguration<TimeSpan>
    {
        public override TimeSpan Value { get; set; } = TimeSpan.FromDays(1825);

        public TimeBehindStatisticsPerQuarter(ulong serverId) : base(serverId)
        {
        }
    }
}
