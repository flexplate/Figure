using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Figure
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SimpleReplaceTransformation : ITransformation
    {
        private static string typeName = "Simple text replacement";
        private static string helpText = "Replaces all occurrences of the text pattern with the text replacement.";
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
            return input.Replace(Pattern, Replacement);
        }


    }
}