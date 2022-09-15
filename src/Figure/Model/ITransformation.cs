namespace Figure
{
    public interface ITransformation
    {
        #region Fields

        private static string helpText;
        private static string typeName;
        private static bool useReplacementProperty;

        #endregion Fields

        #region Properties

        public string HelpText { get; }
        public string Pattern { get; set; }
        public string Replacement { get; set; }
        public string TypeName { get; }
        public bool UseReplacementProperty { get; }
        public bool Applied { get; set; }

        #endregion Properties

        #region Methods

        public string Transform(string input);

        #endregion Methods
    }
}
