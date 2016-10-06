using MusicStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Web.Controllers
{
    public class AlbumController : Controller
    {
        private AlbumService _albumService;

        public AlbumController()
        {
            _albumService = new AlbumService();
        }
        // GET: Album
        public ActionResult Index()
        {
            var albumList= _albumService.GetAllAlbums();
            return View(albumList);
        }

        public ActionResult Create()
        {  
            return View();
        }
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    //return View();
        //}
        [HttpPost]
        public ActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumService.CreateAlbum(album);
                return View("Index");
            }
            else
            {
                return View();
            }
            
        }
    }
}