using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Tag")]
public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }

    public List<Post> Posts { get; set; }
}