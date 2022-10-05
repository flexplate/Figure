using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Figure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class LeadingCapitalTransformation : ITransformation
    {
        private static string typeName = "Initial leading capital case transformation";
        private static string helpText = "All strings matching the regular expression pattern will be transformed to title case.";
        private static bool useReplacementProperty = false;


        public virtual bool UseReplacementProperty => useReplacementProperty;
        public virtual string TypeName => typeName;
        public virtual string HelpText => helpText;

        public bool Applied { get; set; }

        [JsonProperty]
        public string Pattern { get; set; }

        /// <summary>
        /// This will be ignored; this type has useReplacementProperty set to false.
        /// </summary>
        public string Replacement { get; set; }

        public string Transform(string input)
        {
            var TI = new CultureInfo(CultureInfo.InvariantCulture.LCID, false).TextInfo;
            return Regex.Replace(input, Pattern, match => TI.ToTitleCase(match.ToString()));
        }
    }
}