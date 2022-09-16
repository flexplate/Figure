using System.Runtime.Serialization;

namespace Figure
{
    public interface ITransformation : ISerializable
    {
        #region Fields

        private static string helpText;
        private static string typeName;
        private static bool useReplacementProperty;

        #endregion Fields

        #region Properties

        public string HelpText { get; }
        public string TypeName { get; }
        public bool UseReplacementProperty { get; }

        public string Pattern { get; set; }
        public string Replacement { get; set; }
        public bool Applied { get; set; }

        #endregion Properties

        #region Methods

        public string Transform(string input);

        /// <summary>
        /// Default serialization implementation
        /// </summary>
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Pattern", Pattern);
            info.AddValue("Replacement", Replacement);

        }

        #endregion Methods
    }
}
