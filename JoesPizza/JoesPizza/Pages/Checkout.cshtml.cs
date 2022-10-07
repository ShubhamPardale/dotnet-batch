using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JoesPizza.Entities;
using JoesPizza.Session;
using JoesPizza.Models;

namespace JoesPizza.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly ILogger<CheckoutModel> _logger;

        public CheckoutModel(ILogger<CheckoutModel> logger)
        {
            _logger = logger;
        }

        public List<Item> cart { get; set; }
        public double Total { get; set; }

        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            { Total = cart.Sum(i => i.Product.Price * i.Quantity); }
            else
            { Total = 0; }
        }
    }
}
