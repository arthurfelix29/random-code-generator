using StnXCodeGenerator.Domain.Models;
using Xunit;

namespace StnXCodeGenerator.Tests.UnitTest.Models
{
    public class KeyTest
    {
        [Fact]
        public void GenerateDistinctKey_ReturnsCorrectLength()
        {
            Key key = new() { Size = 7 };

            var distinctKey = key.GenerateDistinctKey();

            Assert.Equal(key.Size, distinctKey.Length);
        }
    }
}