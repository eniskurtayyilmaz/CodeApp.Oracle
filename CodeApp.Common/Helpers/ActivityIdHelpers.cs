﻿using System;
using System.Diagnostics;

namespace CodeApp.Common.Helpers
{
    public class ActivityIdHelpers
    {
        public override string ToString()
        {
            if (Trace.CorrelationManager.ActivityId == Guid.Empty)
            {
                Trace.CorrelationManager.ActivityId = Guid.NewGuid();
            }

            return Trace.CorrelationManager.ActivityId.ToString();
        }
    }
}