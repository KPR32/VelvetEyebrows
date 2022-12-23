using System;
using System.Collections.Generic;

namespace VelvetEyebrows.Models;

public partial class ClientService
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int ServiceId { get; set; }

    public DateTime StartTime { get; set; }

    public string? Comment { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<DocumentByService> DocumentByServices { get; } = new List<DocumentByService>();

    public virtual ICollection<ProductSale> ProductSales { get; } = new List<ProductSale>();

    public virtual Service Service { get; set; } = null!;
    public TimeSpan Time
    {
        get
        {

            return StartTime.Subtract(DateTime.Now);
        }
    }
}
