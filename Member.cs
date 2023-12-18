// . A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.

namespace Heist 
{
    public class CrewMember 
    {
        public string Name {get; set;}
        public int Level {get; set;}
        public double CourageFactor {get; set; }

        public void ShowInfo () {
            Console.WriteLine($"Name: {Name} Level: {Level} Courage Factor: {CourageFactor}");
        }
    }
}