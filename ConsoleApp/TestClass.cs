using System;
using Xunit;

namespace ConsoleApp
{
    public class TestClass
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5,Program.AddInts(2,2));
        }
    }
}
