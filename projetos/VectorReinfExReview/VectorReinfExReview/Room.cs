
namespace VectorReinfExReview
{
    class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Bedroom { get; set; }

        public override string ToString()
        {
            return "\nNome: " + Name
                + "\nEmail:" + Email
                + "\nRoom: #" + Bedroom;
        }
    }
}
