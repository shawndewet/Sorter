using System;
using Xunit;

namespace SorterTests
{
    public class SorterTests
    {
        [Theory()]
        [InlineData("Shawn", "ahnsw")]
        public void TestBuiltInSort(string input, string expected)
        {
            var testTarget = new SorterLibrary.Class1();
            var actual = testTarget.SortBuiltIn(input);
            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData("Shawn", "ahnsw")]
        public void TestHandCodedSort(string input, string expected)
        {
            var testTarget = new SorterLibrary.Class1();
            var actual = testTarget.SortHandCoded(input);
            Assert.Equal(expected, actual);
        }

    }
}
