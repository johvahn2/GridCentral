﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCentral.Interfaces
{
    public interface IMetricsManagerService
    {

        void TrackEvent(string eventName);
    }
}
