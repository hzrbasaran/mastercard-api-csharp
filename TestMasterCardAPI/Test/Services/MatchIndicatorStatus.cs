using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Services
{
    public class MatchIndicatorStatus
    {
        public static readonly int SINGLE_TRANSACTION_MATCH = 1;
        public static readonly int MULTIPLE_TRANS_IDENTICAL_CARD_MATCH = 2;
        public static readonly int MULTIPLE_TRANS_DIFFERING_CARDS_MATCH = 3;
        public static readonly int NO_MATCH_FOUND = 4;
    }
}
