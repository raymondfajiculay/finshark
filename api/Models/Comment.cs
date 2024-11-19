namespace api.Models;

public class Comment
{
    public int Id { get; set; }
    
    public string Title { get; set; } = String.Empty;
    
    public string Content { get; set; } = String.Empty;
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    
    //Reference 
    public int? StockId { get; set; }
    
    public Stock? Stock { get; set; }
}