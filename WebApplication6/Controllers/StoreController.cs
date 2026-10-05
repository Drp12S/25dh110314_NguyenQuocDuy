// Dùng ProductCardViewModel trong thư mục Models
using WebApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6;

// Namespace chứa các Controller
namespace WebApplication6.Controllers
{
    // Controller xử lý các request của trang Store
    public class StoreController : Controller
    {
        // GET: Store
        // Action Index xử lý URL /Store/Index
        public ActionResult Index()
        {
            // Tạo danh sách sản phẩm mẫu
            var products = new List<ProductCardViewModel>
            {
// Sản phẩm mẫu 1
                new ProductCardViewModel { ProductID = 1, NamePro = "Nike Air Zoom", CategoryName = "Giày thể thao", Price = 1290000, ImagePro = "shoe-01.jpg" },
// Sản phẩm mẫu 2
                new ProductCardViewModel { ProductID = 2, NamePro = "Adidas Training Tee", CategoryName = "Áo quần thi đấu", Price = 590000, ImagePro = "shirt-01.jpg" },
// Sản phẩm mẫu 3
                new ProductCardViewModel { ProductID = 3, NamePro = "Gym Performance Set", CategoryName = "Dụng cụ thể thao", Price = 890000, ImagePro = "gym-01.jpg" },
// Sản phẩm mẫu 4
                new ProductCardViewModel { ProductID = 4, NamePro = "Running Shoes Pro", CategoryName = "Giày thể thao", Price = 1490000, ImagePro = "shoe-02.jpg" }
            };

            // Truyền products sang View Index
            return View(products);

        }
    }
}