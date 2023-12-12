using System;
using System.Collections.Generic;


public partial class Class
{
    public int CId { get; set; }

    public string? Name { get; set; }

    public string? RoomNumber { get; set; }

    public int? FId { get; set; }

    public virtual ICollection<Enrolled> Enrolleds { get; set; } = new List<Enrolled>();

    public virtual Faculty? FIdNavigation { get; set; }
}
