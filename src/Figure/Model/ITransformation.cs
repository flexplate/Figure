using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public interface ITransformation
    {
        private static string typeName;
        private static bool useReplacementProperty { get; }

        public bool UseReplacementProperty { get; }
        public string TypeName { get; }


        public string Pattern { get; set; }
        public string Replacement { get; set; }

        public string Transform(string input); 

    }
}
