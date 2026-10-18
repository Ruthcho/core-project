using Microsoft.AspNetCore.Mvc;
using dotnet.Models;

namespace dotnet.Controllers;

[ApiController]
[Route("קוסמטיקה")]
public class CosmeticsController : ControllerBase
{
    private static readonly string[] ProductNames =
    {
        "קרם לחות לפנים", "סרום ויטמין C", "תכשיר ניקוי עדין", "מסנן קרינה יומי", "שפתון לחות מזין"
    };

    private static readonly string[] Brands =
    {
        "זוהר", "טהור וטבעי", "טל", "עור בריא", "נגיעה רכה"
    };

    private static readonly string[] Categories =
    {
        "טיפוח העור", "איפור", "טיפוח השיער", "הגנה מהשמש", "טיפוח הגוף"
    };

    private static readonly List<Cosmetic> Products = Enumerable.Range(1, 5)
        .Select(index => new Cosmetic
        {
            Id = index,
            Name = ProductNames[index - 1],
            Brand = Brands[index - 1],
            Price = Random.Shared.Next(20, 301),
            Category = Categories[index - 1]
        })
        .ToList();

    private readonly ILogger<CosmeticsController> _logger;

    public CosmeticsController(ILogger<CosmeticsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "קבלת מוצרי קוסמטיקה")]
    public IEnumerable<Cosmetic> Get()
    {
        return Products;
    }

    [HttpGet("מוצר/{id}", Name = "קבלת מוצר קוסמטיקה לפי מזהה")]
    public ActionResult<Cosmetic> GetById(int id)
    {
        var cosmetic = Products.FirstOrDefault(p => p.Id == id);

        if (cosmetic is null)
        {
            return NotFound();
        }

        return Ok(cosmetic);
    }
}