using System.Text;
using Microsoft.AspNetCore.Mvc;
using MVCIntroDemo.Models.Product;
using Newtonsoft.Json;
using System.Text.Json;
using Microsoft.Net.Http.Headers;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        private IEnumerable<ProductViewModel> products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name = "Cheese",
                Price = 7.00
            },
            new ProductViewModel()
            {
                Id = 2,
                Name = "Ham",
                Price = 5.50
            },
            new ProductViewModel()
            {
                Id = 3,
                Name = "Bread",
                Price = 1.50
            }
        };

        [ActionName("My-products")]
        public IActionResult All(string keyword)
        {
            if (keyword != null)
            {
                var foundProducts = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
                return View(foundProducts);
            }
            return View(products);
        }

        public IActionResult ById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return BadRequest();
            }

            return View(product);
        }

        public IActionResult AllAsJson()
        {
            return Json(products, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }

        public IActionResult AllAsText()
        {
            var text = string.Empty;
            foreach (var item in products)
            {
                text += $"{item.Id}: {item.Name} - {item.Price} lv.";
                text += "\r\n";
            }

            return Content(text);
        }

        public IActionResult AllAsTextFile()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine($"{product.Id}: {product.Name} - {product.Price} lv.");
            }

            Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment;filename=products.txt");

            return File(Encoding.UTF8.GetBytes(sb.ToString().TrimEnd()), "text/plain");
        }
    }
}
