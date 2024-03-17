using CSharp9RecordPatternMatchingExamples.PatternMatching.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9RecordPatternMatchingExamples.PatternMatching
{
    public static class ShapeInfo
    {
        public static string GetShapeDescription(object shape)
        {
            return shape switch
            {
                Shape { Width: 0, Height: 0 } => "Point",
                Shape { Width: var w, Height: var h } when w == h => $"Square with side {w}",
                Shape { Width: var w, Height: var h } => $"Rectangle with width {w} and height {h}",
                _ => "Unknown Shape"
            };

        }
    }
}
