namespace OC.Domain.Models
{
    public class ActorMovie : BaseModel<int>
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public long MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}