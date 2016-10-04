using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStoreApp.Models;

namespace MusicStore.Web.Controllers
{
    public class ArtistController : Controller
    {
        private ArtistService _service;

        public ArtistController()
        {
            _service = new ArtistService();
        }
        // GET: Artist
        [HttpGet]
        public ActionResult Index()
        {
            var artists = _service.GetArtists();
            return View(artists);
        }
        [HttpGet]
        public ActionResult Create()
        { var artist = new Artist();
            return View(artist);
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            _service.CreateArtist(artist);
            return View("Index");
        }
       
    }
}