using BandsApp.Web.Models;
using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;


namespace BandsApp.Web.Controllers;

public class BandsController : Controller
{
    BandService bandService = new BandService(); 

    [Route("")]
    public IActionResult Index()
    {
        var bands = bandService.GetAllBands();
        return View(bands);
    }
    [Route ("details/{id}")]

    public IActionResult Details(int id)
    {
        var band = bandService.GetById(id);
        return View(band);
    }

}
