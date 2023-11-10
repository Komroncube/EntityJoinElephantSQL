namespace EntityJoin.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Laptop> Laptops { get; set; }
    }
}
