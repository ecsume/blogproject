using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstCore.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstCore.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        private Context con;
        public BlogController(Context con)
        {
            this.con = con;
        }
        public ActionResult Index()
        {

            return View(GetAllContent());
        }

        private HomeAllModels GetAllContent()
        {
            var ana = con.Anasayfas.FirstOrDefault();
            var yorum = con.Yorums.ToList();
            var homeAllModels = new HomeAllModels();
            homeAllModels.GetYorum = yorum;
            homeAllModels.GetAnasayfa = ana;


            return homeAllModels;
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Blog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Blog/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Contact()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ContactPost(Iletisim iletisimBilgileri)
        {
            var ılt = con.Iletisims.Add(iletisimBilgileri);
            con.SaveChanges();
            return RedirectToAction(nameof(Contact));
        }

        public ActionResult About()
        {

            var ana = con.Hakkimdas.Where(x => x.id == 1).FirstOrDefault();
            return View(ana);
        }

        [HttpPost]
        public ActionResult YorumPost(Yorum yorumcu)
        {

            con.Yorums.Add(yorumcu);
            //con.Entry(y).State = EntityState.Added;
            con.SaveChanges();

            return RedirectToAction(nameof(Index));

            //return View("Index", GetAllContent());
        }
        public ActionResult Project()
        {

            return View();
        }
    }
}