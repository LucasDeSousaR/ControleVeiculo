using ControleVeiculo.Models;
using System.Linq;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
using System;

public class VeiculosController : Controller
{
    private VeiculosContext db = new VeiculosContext();

    public ActionResult Index()
    {
        var veiculos = db.Veiculos.ToList();
        return View(veiculos);
    }

    public ActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Veiculo veiculo)
    {
        if (ModelState.IsValid)
        {
            db.Veiculos.Add(veiculo);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        return View(veiculo);
    }
    public ActionResult Edit(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Veiculo veiculo = db.Veiculos.Find(id);

        if (veiculo == null)
        {
            return HttpNotFound();
        }

        return View(veiculo);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(Veiculo veiculo)
    {
        if (ModelState.IsValid)
        {
            db.Entry(veiculo).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(veiculo);
    }
    public ActionResult Delete(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Veiculo veiculo = db.Veiculos.Find(id);

        if (veiculo == null)
        {
            return HttpNotFound();
        }

        return View(veiculo);
    }
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
        Veiculo veiculo = db.Veiculos.Find(id);
        db.Veiculos.Remove(veiculo);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    public ActionResult Details(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Veiculo veiculo = db.Veiculos.Find(id);

        if (veiculo == null)
        {
            return HttpNotFound();
        }

        return View(veiculo);
    }
    public ActionResult Search(string searchString, double? precoMin, double? precoMax, int? ano)
    {
        var veiculos = from v in db.Veiculos
                       select v;

        if (!String.IsNullOrEmpty(searchString))
        {
            veiculos = veiculos.Where(v => v.MODELO.Contains(searchString) || v.MARCA.Contains(searchString));
        }

        if (precoMin.HasValue)
        {
            veiculos = veiculos.Where(v => v.PRECO >= precoMin);
        }

        if (precoMax.HasValue)
        {
            veiculos = veiculos.Where(v => v.PRECO <= precoMax);
        }

        if (ano.HasValue)
        {
            veiculos = veiculos.Where(v => v.ANO == ano);
        }

        return View("Search", veiculos.ToList());
    }

}
