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
            // Test class constructor (instance) will execute for all test cases.
            // means if this class has 11 test cases then 11 times this constructor will execute before test cases execute.
            // but Fixture check & if instance available it will not create new instance
            // like
            // List<int> lst =new List<int>{1,2,3,4,5}; // this local variable lst allways has 5 itemss before each test case execute 
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