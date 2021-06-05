namespace OC.Domain.Models
{
    public class CategoryMovie : BaseModel<long>
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public long MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}