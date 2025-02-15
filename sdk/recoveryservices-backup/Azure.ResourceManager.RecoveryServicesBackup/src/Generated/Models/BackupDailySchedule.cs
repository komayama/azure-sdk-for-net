// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The BackupDailySchedule. </summary>
    internal partial class BackupDailySchedule
    {
        /// <summary> Initializes a new instance of BackupDailySchedule. </summary>
        public BackupDailySchedule()
        {
            ScheduleRunTimes = new ChangeTrackingList<DateTimeOffset>();
        }

        /// <summary> Initializes a new instance of BackupDailySchedule. </summary>
        /// <param name="scheduleRunTimes"> List of times of day this schedule has to be run. </param>
        internal BackupDailySchedule(IList<DateTimeOffset> scheduleRunTimes)
        {
            ScheduleRunTimes = scheduleRunTimes;
        }

        /// <summary> List of times of day this schedule has to be run. </summary>
        public IList<DateTimeOffset> ScheduleRunTimes { get; }
    }
}
