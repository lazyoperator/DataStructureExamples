using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureExamples.Arrays.Tests
{
    [TestFixture]
    public class Meeting_Rooms_IiTests
    {
        [Test]
        public void Test0()
        {
            //Dictionary<int, int> meetings = new Dictionary<int, int>();
            //meetings.Add(7, 10);

            int[,] meets = new int[,] { { 0, 30 }, { 5, 10 }, { 15, 20 } };
            int output = 2;

            var meeting_Rooms_Ii = new Meeting_Rooms_Ii();
            var actual = meeting_Rooms_Ii.MinMeetingRoom(meets);

            Assert.AreEqual(output, actual);
        }        
    }
}
