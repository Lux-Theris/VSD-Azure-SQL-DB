public class ToDo{
  public int ID { get; set; }
  public string? Description { get; set; }
  public bool Finished { get; set; } = false;
  public DateTime? DueDate { get; set; }
}