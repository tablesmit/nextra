using System.ComponentModel.DataAnnotations;

namespace NExtra.ValidationAttributes
{
    /// <summary>
    /// This attribute can be used to validate whether or
    /// not a string is long enough, given a minimum length. 
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.saidi.se/nextra
    /// </remarks>
    public class MinLengthAttribute : ValidationAttribute
    {
        private readonly int minLength;


        public MinLengthAttribute(int minLength)
        {
            this.minLength = minLength;
        }

        
        public override bool IsValid(object value)
        {
            var str = value as string;
            return str != null && str.Length >= minLength;
        }
    }
}
