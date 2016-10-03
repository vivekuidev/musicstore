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
        public ActionResult Index()
        {
            var artists = _service.GetArtists();
            return View(artists);
        }

        public ActionResult Create()
        { var artist = new Artist();
            return View(artist);
        }
       
    }
}