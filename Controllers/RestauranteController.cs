
using Microsoft.AspNetCore.Mvc;

public class RestauranteController : Controller
{
    public RestauranteController()
    {
    }

    public IActionResult Cenas()
    {

        List<CenaModel> cenas = new List<CenaModel>();

        CenaModel c1 = new CenaModel();
        c1.Name = "Burritos";
        c1.Quantity = 2;
        c1.Amount = 100M;
        
        CenaModel c2 = new CenaModel();
        c2.Name = "Bounles";
        c2.Quantity = 10;
        c2.Amount = 250M;

        cenas.Add(c1);
        cenas.Add(c2);

        return View(cenas);
    }
}