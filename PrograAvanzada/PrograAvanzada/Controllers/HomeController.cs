using PrograAvanzada.Models;
using System.Collections.Generic;
using System.Web.Mvc;

public class HomeController : Controller
{
    // Lista estática para almacenar reseñas en memoria
    private static List<Review> _reviews = new List<Review>
    {
        new Review { CustomerName = "Juan Pérez", Comment = "¡Gran servicio y excelente selección de productos!", Rating = 5 },
        new Review { CustomerName = "Ana López", Comment = "Me encanta la variedad que ofrecen. Siempre encuentro algo interesante.", Rating = 4 },
        new Review { CustomerName = "Carlos Ramírez", Comment = "El envío fue rápido y el producto llegó en perfectas condiciones.", Rating = 5 }
    };

    public ActionResult Index()
    {
        return View();
    }

    public ActionResult About()
    {
        var model = new ReviewViewModel();
        ViewBag.Reviews = _reviews;
        return View(model);
    }

    [HttpPost]
    public ActionResult AddReview(ReviewViewModel model)
    {
        if (ModelState.IsValid)
        {
            var newReview = new Review
            {
                CustomerName = model.CustomerName,
                Comment = model.Comment,
                Rating = model.Rating
            };

            _reviews.Add(newReview);
            ViewBag.Message = "Thank you for your review!";
        }

        ViewBag.Reviews = _reviews;
        return View("About", model);
    }
}