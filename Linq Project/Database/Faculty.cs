using System;
using System.Collections.Generic;


public partial class Faculty
{
    public int FId { get; set; }

    public string? FName { get; set; }

    public int? DeptId { get; set; }

    public string? Standing { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
