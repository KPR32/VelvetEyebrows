using System;
using System.Collections.Generic;

namespace VelvetEyebrows.Models;

public partial class Gender
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
