namespace Figure
{
    public class SimpleReplaceTransformation : ITransformation
    {
        private static string typeName => "Simple text replacement";
        private static bool useReplacementProperty => true;

        public virtual bool UseReplacementProperty => useReplacementProperty;
        public virtual string TypeName => typeName;

        public string Pattern { get; set; }
        public string Replacement { get; set; }
        string ITransformation.Transform(string input)
        {
            return input.Replace(Pattern, Replacement);
        }
    }
}
