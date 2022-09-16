using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Figure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RegexTransformation : ITransformation
    {
        private static string typeName = "Regex replacement";
        private static string helpText = "Replaces all occurrences of the regular expression pattern with the regulat expression replacement.";
        private static bool useReplacementProperty = true;

        public virtual bool UseReplacementProperty => useReplacementProperty;
        public virtual string TypeName => typeName;
        public virtual string HelpText => helpText;

        public bool Applied { get; set; }

        [JsonProperty]
        public string Pattern { get; set; }

        [JsonProperty]
        public string Replacement { get; set; }


        string ITransformation.Transform(string input)
        {
            var Rgx = new Regex(Pattern);
            return Rgx.Replace(input, Replacement);
        }

    }
}