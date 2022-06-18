public class Post 
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Blog Blog { get; set; }
    public int BlogId { get; set; }


}