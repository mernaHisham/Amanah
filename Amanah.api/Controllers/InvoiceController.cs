using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Amanah.BLL;
using Amanah.DAL.Models;
using Amanah.Interfaces;

namespace Amanah.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceBLL _invBLL;
        public InvoiceController(IInvoiceBLL invBLL) {
            _invBLL = invBLL;
        }
        [HttpGet]
        public ActionResult GetInvoices(int invId=0)
        {
            List<Invoice> invs = _invBLL.GetInvoices(invId).ToList();
            return Ok(new { invs });
        }
        [HttpPost]
        public ActionResult UpdateInvoice(Invoice inv)
        {
            return Ok(_invBLL.UpdateInvoice(inv));
        }
        [HttpDelete]
        public ActionResult DeleteInvoice(int invId)
        {
            return Ok(_invBLL.DeleteInvoice(invId));
        }
    }
}
