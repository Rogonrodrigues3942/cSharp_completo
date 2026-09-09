using System.Collections.Generic;
using System.Text;

namespace Hostel
{
    class Bedroom
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString()
        {
            return "Nome: " + Name
                + "\nEmail: " + Email
                + "\nRoom: " + Room;
        }
    }
}
