using AggregatorLibrary.LiqPay.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AggregatorLibrary.LiqPay.AspNetCore
{
    public interface ILiqPayReceiveController
    {
        Task<IActionResult> ReceiveLiqPayPaymentQuery(LiqPayCallbackModel model);
    }
}
