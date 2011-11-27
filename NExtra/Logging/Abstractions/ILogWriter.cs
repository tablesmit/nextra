﻿namespace NExtra.Logging.Abstractions
{
    /// <summary>
    /// This interface can be implemented by any class that
    /// can log messages in various ways. It can be used as
    /// a facade for e.g. log4net.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.saidi.se/nextra
    /// </remarks>
    public interface ILogWriter
    {
        /// <summary>
        /// Log a message.
        /// </summary>
        /// <param name="logLevel">Message log level.</param>
        /// <param name="message">The message to log.</param>
        void Log(LogLevel logLevel, string message);
    }
}
