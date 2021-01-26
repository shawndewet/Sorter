using System;
using Xunit;

namespace SorterTests
{
    public class SorterTests
    {
        [Theory()]
        [InlineData("Shawn", "ahnsw")]
        [InlineData("Contrary to popular belief, the pink unicorn flies east.", "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy")]
        public void TestBuiltInSort(string input, string expected)
        {
            var testTarget = new SorterLibrary.Sorter();
            var actual = testTarget.SortBuiltIn(input);
            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData("Shawn", "ahnsw")]
        [InlineData("Contrary to popular belief, the pink unicorn flies east.", "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy")]
        public void TestHandCodedSort(string input, string expected)
        {
            var testTarget = new SorterLibrary.Sorter();
            var actual = testTarget.SortHandCoded(input);
            Assert.Equal(expected, actual);
        }

    }
}
