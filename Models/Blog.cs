public class Blog
{
   public int ID { get; set; }
    public string? Name { get; set; }

    public DateTime Date { get; set; }
   ICollection<Post> posts { get; set; }
    
}
