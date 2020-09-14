using System;
using Xunit;
using System.IO;

namespace RPS_Game_NoDB.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetUsersIntentReturnsOneOrTwo()
        {
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("2"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    int intent = RPSHelperMethods.PlayOrQuit(1);
                    Assert.Equal(2, intent);
                }
            }
        }

    }
}
