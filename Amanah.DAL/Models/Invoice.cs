using System;
using System.Collections.Generic;

namespace Amanah.DAL.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerType { get; set; } = null!;

    public double Value { get; set; }

    public int PaymentMethod { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
