using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using NextLevel.Models;

namespace NextLevel.Controllers
{
    public class AthletesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private static HttpClient client;

        public bool IsAdmin { get; private set; }

        //private Coordinates coordinates; 

        // GET: Athletes
        public ActionResult Index()
        {
            return View(db.Athletes.ToList());
        }

        // GET: Athletes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // GET: Athletes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Athletes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "age,gradeLevel,firstName,lastName,emailAddress,schoolName,city,state,zipCode,postion,height,weight")] Athlete athlete)
        {
            if (ModelState.IsValid)
            {
                db.Athletes.Add(athlete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(athlete);
        }
        //public string UploadVideo(HttpFileCollection video)
        //{
        //    if (video.Count <= 0) return null;
        //    var fileName = Path.GetFileName(video.Get(0).FileName);
        //    var path = Path.Combine(Server.MapPath("~/Content/Videos"), fileName);
        //    // save video here
        //    return fileName;
        //}
        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult Update(int? id, string title, string body, DateTime dateTime, string tags)
        //{
        //    if (!IsAdmin)
        //    {
        //        return RedirectToAction("Index");
        //    }

        //    var post = GetPost(id); // get the post object

        //    var video = System.Web.HttpContext.Current.Request.Files;

        //    post.Title = title;
        //    post.Body = body;
        //    post.DateTime = dateTime;
        //    post.Tags.Clear();
        //    post.VideoFileName = UploadVideo(video);
        //    // continued, more code
        //}

        //private object GetPost(int? id)
        //{
        //    throw new NotImplementedException();
        //}

        //public class Video
        //{
        //    public HttpFileCollection File { get; set; }
        //}

        // GET: Athletes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // POST: Athletes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "age,gradeLevel,firstName,lastName,emailAddress,schoolName,city,state,zipCode,postion,height,weight")] Athlete athlete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(athlete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(athlete);
        }
        


        // GET: Athletes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // POST: Athletes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Athlete athlete = db.Athletes.Find(id);
            db.Athletes.Remove(athlete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
