using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9RecordPatternMatchingExamples
{
    public class Data
    {
        //Immutable by Default example
        public record Person(string FirstName, string LastName);

        //Type Patterns
        public static string GetDisplayText(object obj)
        {
            return obj switch
            {
                string text => $"String: {text}",
                int number => $"Number: {number}",
                DateTime dateTime => $"Date and Time: {dateTime}",
                double floatingPoint => $"Floating Point Number: {floatingPoint}",
                bool boolean => $"Boolean: {boolean}",
                IEnumerable enumerable => $"Enumerable: {string.Join(", ", enumerable.Cast<object>())}",
                _ => "Unknown"
            };
        }



    }
}
