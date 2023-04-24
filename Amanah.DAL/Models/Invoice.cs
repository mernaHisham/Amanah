using System;
using System.Collections.Generic;

namespace Amanah.DAL.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerType { get; set; } = null!;

    public double Value { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
