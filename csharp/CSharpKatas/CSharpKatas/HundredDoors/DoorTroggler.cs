using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKatas.HundredDoors
{
    public class DoorToggler
    {
        public IEnumerable<Door> Doors { get; private set; }
        private int _skipCount;

        public DoorToggler(IEnumerable<Door> doors)
        {
            Doors = doors;
        }

        public void ToggleTraverse()
        {
            var currentSkipCount = _skipCount;
            foreach (var door in Doors)
            {
                if (currentSkipCount == 0)
                {
                    door.IsOpen = !door.IsOpen;
                    currentSkipCount = _skipCount;
                }
                else
                {
                    currentSkipCount--;
                }
            }
            _skipCount++;
        }
    }
}
