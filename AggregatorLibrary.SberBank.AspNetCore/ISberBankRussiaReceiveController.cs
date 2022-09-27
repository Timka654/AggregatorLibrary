using AggregatorLibrary.SberBank.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AggregatorLibrary.SberBank.AspNetCore
{
    public interface ISberBankRussiaReceiveController
    {
        Task<IActionResult> ReceiveSberBankPaymentQuery(SberBankCallbackModel model);
    }
}
