using Amanah.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amanah.Interfaces
{
    public interface IInvoiceBLL
    {
        List<Invoice> GetInvoices(int invoiceId=0);
        bool UpdateInvoice(Invoice inv);
        bool DeleteInvoice(int invoiceId);
    }
}
