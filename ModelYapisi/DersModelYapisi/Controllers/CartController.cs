using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {
        public List<CartProductViewModel> cartProducts = new List<CartProductViewModel>();
        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Robot Süpürge",Price = 8.000M };
            var product2 = new Product { Id = 2, Name = "Çay Makinesi",Price = 5.000M };
            var product3 = new Product { Id = 3, Name = "Kahve Makinesi",Price = 6.000M };
            
            var cartProduct1 = new CartProductViewModel { Id =  1,Product = product1,Quantitiy=5,Price = 40.000M};
            var cartProduct2 = new CartProductViewModel { Id =  2,Product = product2,Quantitiy=10,Price = 50.000M};
            var cartProduct3 = new CartProductViewModel { Id =  3,Product = product3,Quantitiy=15,Price = 90.000M};
            
            cartProducts.Add(cartProduct1);
            cartProducts.Add(cartProduct2);
            cartProducts.Add(cartProduct3);

            return View(cartProducts);
        }
    }
}
