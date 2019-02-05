namespace CLTeam.Backend.Models
{
    public class Player
    {
        public string Name { get; set; }
        
        public int Id { get; set; }

        // This is override the parent implementation of ToString().
        //    Ever dotnet object has a ToString() method. This is what is show in the debugger
        //    and anytime you just print the object
        public override string ToString()
        {
            return $"Id {Id} Name {Name}";
        }
    }
}