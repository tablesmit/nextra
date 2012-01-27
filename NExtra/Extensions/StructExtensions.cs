namespace NExtra.Extensions
{
    /// <summary>
    /// Extension methods for struct.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.dotnextra.com
    /// </remarks>
    public static class StructExtensions
    {
        ///<summary>
        ///Check whether or not a struct has its default value.
        ///</summary>
        public static bool IsDefault<T>(this T value) where T : struct
        {
            return value.Equals(default(T));
        }
    }
}