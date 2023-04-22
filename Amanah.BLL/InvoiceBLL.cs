using Amanah.DAL.Models;
using Amanah.Interfaces;
using Amanah.Repo;

namespace Amanah.BLL
{
    public class InvoiceBLL : IInvoiceBLL
    {
        private readonly IRepository<Invoice> _repo;
        public InvoiceBLL(IRepository<Invoice> repo)
        {
            _repo = repo;
        }
        public List<Invoice> GetInvoices(int invoiceId = 0) =>
             _repo.GetAll().Where(z => invoiceId==0|| z.Id == invoiceId).ToList();
        public bool UpdateInvoice(Invoice inv)
        {
            if (inv.Id == 0)
            {
                _repo.Insert(inv);
            }
            else
            {
                Invoice DT = _repo.GetAll().FirstOrDefault(z => z.Id == inv.Id);
                DT.CustomerName = inv.CustomerName;
                DT.CustomerType = inv.CustomerType;
                DT.Value = inv.Value;
                DT.PaymentMethod = inv.PaymentMethod;
                _repo.Update(DT);
            }
            return true;
        }
        public bool DeleteInvoice(int invoiceId)
        {
            Invoice inv = _repo.GetAll().FirstOrDefault(z => z.Id == invoiceId);
            _repo.Delete(inv);
            return true;
        }
    }
}
