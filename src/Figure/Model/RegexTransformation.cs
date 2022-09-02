using System.Text.RegularExpressions;

namespace Figure
{
    public class RegexTransformation : ITransformation
    {
        public static string typeName => "Regex replacement";
        private static bool useReplacementProperty => true;

        public virtual bool UseReplacementProperty => useReplacementProperty;
        public virtual string TypeName => typeName;

        public string Pattern { get; set; }
        public string Replacement { get; set; }


        string ITransformation.Transform(string input)
        {
            var Rgx = new Regex(Pattern);
            return Rgx.Replace(input, Replacement);
        }
    }
}
