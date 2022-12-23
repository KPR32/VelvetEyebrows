using System;
using System.Collections.Generic;

namespace VelvetEyebrows.Models;

public partial class Tag
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Color { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
