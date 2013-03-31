using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpKatas.HundredDoors;
using Xunit;
using Xunit.Extensions;

namespace CSharpKatas.Tests.HundredDoors
{
    public class DoorTogglerTests
    {
        public class ToggleTraverse
        {
            [Theory]
            [InlineData(1, 0, true)]
            [InlineData(2, 0, true)]
            [InlineData(2, 1, false)]
            [InlineData(2, 2, true)]
            [InlineData(3, 2, false)]
            [InlineData(100, 99, true)] // Do you see it?
            public void ShouldToggleDoor(int passes, int doorToBeCheck, bool expectedToBeOpen)
            {
                var sut = GetSut();

                for (int i = 0; i < passes; i++)
                {
                    sut.ToggleTraverse();
                }

                for (int i = 0; i < sut.Doors.Count(); i++)
                {
                    Trace.WriteLine(string.Format(
                        "Door {0} is {1}",
                        i+1,
                        sut.Doors.ElementAt(i).IsOpen ? "Open" : "Closed"));
                }

                Assert.Equal(expectedToBeOpen, sut.Doors.ElementAt(doorToBeCheck).IsOpen);
            }

            private static List<Door> GetClosedDoors()
            {
                var doors = new List<Door>();
                for (int i = 0; i < 100; i++)
                {
                    doors.Add(new Door());
                }
                return doors;
            }

            private DoorToggler GetSut()
            {
                return new DoorToggler(GetClosedDoors());
            }
        }
    }
}
