using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meters_converter_csharp2
{
    public enum Unit
    {
        Meters,
        Kilometers,
        Feet,
        Inches,
    }
    public class UnitMethods {

        public static Unit FromTag(string tag)
        {
            switch (tag) {
                case "m":  return Unit.Meters;
                case "km": return Unit.Kilometers;
                case "ft": return Unit.Feet;
                case "in": return Unit.Inches;
            }
            throw new ArgumentException("No such unit: " + tag);
        }

        public static double ToMeters(Unit unit) {
            switch (unit) {
                case Unit.Meters:     return 1.0;
                case Unit.Kilometers: return 1000.0;
                case Unit.Feet:       return 0.3048;
                case Unit.Inches:     return 0.0254;

                default:  throw new InvalidEnumArgumentException();
            }
        }

        public static string ShortName(Unit unit)
        {
            switch (unit)
            {
                case Unit.Meters:     return "м.";
                case Unit.Kilometers: return "км.";
                case Unit.Feet:       return "фут(ов)";
                case Unit.Inches:     return "дюйм(ов)";

                default: throw new InvalidEnumArgumentException();
            }
        }
    }
}
