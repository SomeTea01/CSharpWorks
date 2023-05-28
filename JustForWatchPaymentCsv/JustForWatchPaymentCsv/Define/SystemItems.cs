using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForWatchPaymentCsv.Define
{
    static public class SystemItems
    {
        public struct SystemItemObject
        {
            public string Name;
            public bool Require;
        }
        static public SystemItemObject[] Items =
        {
            new SystemItemObject(){Name = "purchased date",Require = true},
            new SystemItemObject(){Name = "billing destination",Require = true},
            new SystemItemObject(){Name = "payment amount",Require = true},
            new SystemItemObject(){Name = "repeat",Require = false},
        };
    }
}
