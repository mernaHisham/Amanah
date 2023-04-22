using System;
using System.Collections.Generic;

namespace Amanah.DAL.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Invoice> InvoiceCreatedByNavigations { get; set; } = new List<Invoice>();

    public virtual ICollection<Invoice> InvoiceUpdatedByNavigations { get; set; } = new List<Invoice>();
}
