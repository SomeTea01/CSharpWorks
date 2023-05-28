using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForWatchPaymentCsv.Define
{
    static internal class SystemMessages
    {
        public struct ErrorMessages
        {
            public static string NotFound = "対象のオブジェクトが見つかりません";
            public static string IsRequired = "必須項目のため、空欄にすることは出来ません。";
            public static string Duplicated = "この項目は重複してはいけません。";

        }

    }
}
