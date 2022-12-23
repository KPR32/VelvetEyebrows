using System;
using System.Collections.Generic;

namespace VelvetEyebrows.Models;

public partial class Client
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateTime? Birthday { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string GenderCode { get; set; } = null!;

    public string? PhotoPath { get; set; }

    public virtual ICollection<ClientService> ClientServices { get; } = new List<ClientService>();

    public virtual Gender GenderCodeNavigation { get; set; } = null!;

    public virtual ICollection<Tag> Tags { get; } = new List<Tag>();
}
