using System;
using System.Collections.Generic;

namespace SpreadSheetNotationConversationTest
{
    public class AllResultFixture : IDisposable
    {
        public Dictionary<long, string> Dictionary { get; private set; }
        public AllResultFixture()
        {
            Dictionary = SpreadSheetNotationConversationLib.SpreadSheetNotationConversation.FinalResult();
        }
        public void Dispose()
        {
            Dictionary = null;
            //throw new NotImplementedException();
        }
    }
}