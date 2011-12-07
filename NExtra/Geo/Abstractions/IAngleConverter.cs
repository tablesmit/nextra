﻿namespace NExtra.Geo.Abstractions
{
    /// <summary>
    /// This interface can be implemented by all classes
    /// that can convert angles in various ways.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.saidi.se/nextra
    /// </remarks>
    public interface IAngleConverter
    {
        /// <summary>
        /// Convert degrees to radians.
        /// </summary>
        double ConvertDegreesToRadians(double degrees);

        /// <summary>
        /// Convert radians to degrees.
        /// </summary>
        double ConvertRadiansToDegrees(double radians);
    }
}