﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StackExchange.Profiling.Wcf.Storage;

namespace StackExchange.Profiling.Wcf
{
    partial class WcfRequestProfilerProvider
    {
        public static class Settings
        {
            public static IWcfUserProvider UserProvider { get; set; }

            internal static void EnsureStorageStrategy()
            {
                if (MiniProfiler.Settings.Storage == null)
                {
                    MiniProfiler.Settings.Storage = new WcfRequestInstanceStorage();
                }
            }
        }
    }
}
