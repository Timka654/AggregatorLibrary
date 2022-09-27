using AggregatorLibrary.Tinkoff.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AggregatorLibrary.Tinkoff.AspNetCore
{
    public interface ITinkoffReceiveController
    {
        Task<IActionResult> ReceiveTinkoffPaymentQuery(TinkoffCallbackModel model);
    }
}
