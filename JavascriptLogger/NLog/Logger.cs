﻿using NLog;

namespace JavascriptLogger.NLog
{
    internal static class Log
    {
        public static Logger Instance { get; private set; }
        static Log()
        {
            LogManager.ReconfigExistingLoggers();
            Instance = LogManager.GetCurrentClassLogger();
        }
    }
}