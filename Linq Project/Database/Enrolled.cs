

public partial class Enrolled
{
    public int Id { get; set; }

    public int? SId { get; set; }

    public int? CId { get; set; }

    public virtual Class? CIdNavigation { get; set; }

    public virtual Student? SIdNavigation { get; set; }
}
