using System;
using System.Collections.Generic;
using Xunit;

namespace SpreadSheetNotationConversationTest
{

    public class SpreadSheetNotationConversation : IClassFixture<AllResultFixture>
    {
        Dictionary<long, string> dic;
        public SpreadSheetNotationConversation(AllResultFixture allResultFixture)
        {
            dic = allResultFixture.Dictionary;
        }

        [Fact]
        public void IsSameAsFirstCell()
        {
            //Given
            long n = 1;
            string expected = dic[n];
            //When
            var actual = SpreadSheetNotationConversationLib.SpreadSheetNotationConversation.GetSpreadSheetNotation(n);
            //Then
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(746)]
        [InlineData(741)]
        [InlineData(750)]
        public void IsSameAs(long number)
        {
            //Given
            long n = number;
            string expected = dic[n];
            //When
            var actual = SpreadSheetNotationConversationLib.SpreadSheetNotationConversation.GetSpreadSheetNotation(n);
            //Then
            Assert.Equal(expected, actual);
        }
    }
}