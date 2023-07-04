using System;
using System.Collections.Generic;
using backtask.Models;
using Microsoft.AspNetCore.Mvc;

public class ProductController:Controller
{
    private List<Product> _products;

    public ProductController()
    {
      _products = new List<Product>()
    {

            new Product{ Id=1,ProductName= "Iphone X"},
            new Product{ Id=2,ProductName= "Iphone 11"},
            new Product{ Id=3,ProductName= "Iphone 12"}
    };
    }

    public IActionResult Index()
    {
       

        ViewBag.Products = _products;
        return View();
    }

    public IActionResult Info( int id)
    {
        var product = _products.Find(x => x.Id == id);
        ViewBag.Product = product;
        return View();
    }


    public IActionResult Detail (string ProductName,int id)
    {
        ViewData["name"] = ProductName;
        ViewBag.id = id;
        return View();
    }

   
}
 

