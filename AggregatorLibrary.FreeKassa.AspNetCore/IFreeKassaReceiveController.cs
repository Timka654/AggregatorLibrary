using AggregatorLibrary.FreeKassa.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AggregatorLibrary.FreeKassa.AspNetCore
{
    public interface IFreeKassaReceiveController
    {
        Task<IActionResult> ReceiveFreeKassaPaymentQuery(FreeKassaCallbackModel model);
    }
}
