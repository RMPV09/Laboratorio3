using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio3.Models;
namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var songs = getListOfSongs();
            ViewBag.MainTitle = "My favourite song";
            return View(songs);
        }
        private List<SongModel> getListOfSongs()
        {
            List<SongModel> songs = new List<SongModel>();
            songs.Add(new SongModel
            {
                Id = 1,
                Name = "Sleepwalking",
                Genre = "Metalcore",
                ReleasedDate = new DateTime(2013, 03, 01),
                Band = "Bring_Me_The_Horizon"
            }); ;

            return songs;

        }
    }
}
