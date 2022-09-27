using AggregatorLibrary.Qiwi.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AggregatorLibrary.Qiwi.AspNetCore
{
    public interface IQiwiReceiveController
    {
        Task<IActionResult> ReceiveQiwiPaymentQuery(QiwiCallbackModel model);
    }
}
