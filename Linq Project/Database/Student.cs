using System;
using System.Collections.Generic;


public partial class Student
{
    public int SId { get; set; }

    public string? SName { get; set; }

    public string? Major { get; set; }

    public string? Standing { get; set; }

    public virtual ICollection<Enrolled> Enrolleds { get; set; } = new List<Enrolled>();
}
