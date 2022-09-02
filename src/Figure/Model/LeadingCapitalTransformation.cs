using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Figure
{
    public class LeadingCapitalTransformation : ITransformation
    {
        private static string typeName => "Initial leading capital case transformation";
        private static bool useReplacementProperty => false;

        public virtual bool UseReplacementProperty => useReplacementProperty;
        public virtual string TypeName => typeName;
        public string Pattern { get; set; }

        /// <summary>
        /// This will be ignored; this type has useReplacementProperty set to false.
        /// </summary>
        public string Replacement { get; set; }

        public string Transform(string input)
        {
            throw new NotImplementedException();
        }
    }
}
