namespace ASP6.Controllers;

using Microsoft.AspNetCore.Mvc;
using ASP6.ViewModels;

public class ProductController : Controller
{
    [HttpGet]
    public IActionResult SelectQuantity()
    {
        return View(new ProductQuantity());
    }

    [HttpPost]
    public IActionResult SelectQuantity(ProductQuantity model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("OrderDetails", new { quantity = model.Quantity });
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult OrderDetails(int quantity)
    {
        var model = new OrderDetailModel
        {
            Quantity = quantity
        };

        for (int i = 0; i < quantity; i++)
        {
            model.Products.Add(new ProductOrder());
        }

        return View(model);
    }

    [HttpPost]
    public IActionResult OrderConfirmation(OrderDetailModel model)
    {
        if (ModelState.IsValid)
        {
            return View(model);
        }

        return RedirectToAction("OrderDetails", new { quantity = model.Quantity });
    }
}