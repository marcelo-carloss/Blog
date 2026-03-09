using System.ComponentModel.DataAnnotations.Schema;
using System.Formats.Asn1;

[Table("Post")]
public class Post
{
    public Post()
    {
        Tags = new List<Tag>();
    }
    public string Id { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Body { get; set; }
    public string Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public int AuthorId { get; set; }
    public User Author { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<Tag> Tags { get; set; }
}