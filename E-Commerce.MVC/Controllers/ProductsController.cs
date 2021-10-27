using E_Commerce.Core.BusinessLayer;
using E_Commerce.MVC.Helper;
using E_Commerce.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IBusinessLayer BL;

        public ProductsController(IBusinessLayer BL)
        {
            this.BL = BL;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = BL.FetchProducts();

            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();

            foreach (var item in products)
            {
                productsViewModel.Add(item.ToProductViewModel());
            }

            return View(productsViewModel);
        }

        public IActionResult Details(int id)
        {
            if (id <= 0)
            {
                return View("Index");
            }
            var prod = BL.GetProductById(id);

            var prodViewModel = prod.ToProductViewModel();
            return View(prodViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadViewBag();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = productViewModel.ToProduct();
                BL.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }



        private void LoadViewBag()
        {

            ViewBag.Categories = new SelectList(new[]{
                "Electronic",
                "Clothes",
                "HomeLife"
            });
            
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = BL.FetchProducts().FirstOrDefault(p => p.Id == id);
            var productViewModel = product.ToProductViewModel();
            LoadViewBag();
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Update(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = productViewModel.ToProduct();
                BL.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = BL.FetchProducts().FirstOrDefault(p => p.Id == id);
            var productViewModel = product.ToProductViewModel();
            LoadViewBag();
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Delete(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = productViewModel.ToProduct();
                BL.DeleteProduct(product.Id);
                return RedirectToAction(nameof(Index));

            }
            return View(productViewModel);
        }

    }
}
