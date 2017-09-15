using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HomeSeerZensehome
{
    public static class classes
    {
        [Serializable]
        public class hsCollection : Dictionary<string, object>
        {
            Dictionary<string, string> _keyIndex = new Dictionary<string, string>();

            public hsCollection() : base()
            { }

            protected hsCollection(SerializationInfo info, StreamingContext context)
                : base(info, context)
            { }

        }

        [Serializable]
        public class action : hsCollection
        {

        }

        [Serializable]
        public class trigger : hsCollection
        {

        }

        [Serializable]
        public class SampleClass
        {

        }
    }
}
