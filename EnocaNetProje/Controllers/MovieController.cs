using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EnocaNetProje.Models;
using EntityLayer.Concrete;
using FluentValidation;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnocaNetProje.Controllers
{
    public class MovieController : Controller
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        CinemaHallManager cinemaHallManager = new CinemaHallManager(new EfCinemaHallDal());
        Context context = new Context();


        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Movies.Include(x => x.CinemaHalls).ToList();
            ViewBag.directors = context.Movies.Select(x => x.Director).ToList();
            ViewBag.Values = context.Movies.Select(x => x.Genre).ToList();
            //var values = movieManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult GetMoviesByDirector(IFormCollection data)
        {
            var value1 = data["DirectorName"];
            var values2 = movieManager.TGetByDirectorName(value1);
            if (values2.Count() != 0)
            {
                return View(values2);
            }
            else
            {
                TempData["errorDirector"] = "There is no director in database";
                return View(values2);
                //return RedirectToAction("Index", "Movie");
            }
        }

        [HttpGet]
        public IActionResult MovieDetails(int id)
        {
            var movie = context.Movies.Include(x => x.CinemaHalls).Where(a => a.MovieId == id).FirstOrDefault();
            return View(movie);
        }

        [HttpPost]
        public IActionResult GetMoviesByGenre(IFormCollection data)
        {
            var value1 = data["Genre"];
            var values2 = movieManager.TGetByGenre(value1);
            if (values2.Count() != 0)
            {
                return View(values2);
            }
            else
            {
                TempData["errorGenre"] = "There is no genre in database";
                return View(values2);
                //return RedirectToAction("Index", "Movie");
            }
        }
        [HttpPost]
        public IActionResult GetMoviesByName(IFormCollection data)
        {
            var value1 = data["MovieName"];
            var values2 = movieManager.TGetByMovieName(value1);
            if (values2.Count()!=0)
            {
                return View(values2);
            }
            else
            {
                TempData["errorMovieName"] = "There is no movie in database";
                return View(values2);
                //return RedirectToAction("Index","Movie");
            }
            
        }
        [HttpPost]
        public IActionResult GetMoviesByYear(IFormCollection datas)
        {
            var value1 = Convert.ToInt32(datas["Year1"]);
            var value2 = Convert.ToInt32(datas["Year2"]);
            var values3 = movieManager.TGetByMovieYear(value1, value2);
            if (values3.Count() != 0)
            {
                return View(values3);
            }
            else
            {
                TempData["errorMovieYear"] = "There is no movie in year.";
                return View(values3);
                //return RedirectToAction("Index","Movie");
            }
        }

        [HttpGet]
        public IActionResult GetHalls()
        {
            var values = context.CinemaHalls.Include(x => x.Movie).ToList();
            //var values = cinemaHallManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.cinemaHalls = cinemaHallManager.TGetList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateMovieModel createMovieModel)
        {
            
            
            Movie movie = new Movie() 
            {
                Name=createMovieModel.Name,
                Genre=createMovieModel.Genre,
                Director=createMovieModel.Director,
                Year=createMovieModel.Year,
                Image=createMovieModel.Image,
                CinemaHalls=createMovieModel.CinemaHalls
            };
            movieManager.TAdd(movie);
            return RedirectToAction("Index","Movie");

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.cinemaHalls2 = cinemaHallManager.TGetList();
            var UpdateMovie = context.Movies.Include(x=>x.CinemaHalls).SingleOrDefault(x => x.MovieId == id);
            CreateMovieModel createMovieModel = new CreateMovieModel();
            if (UpdateMovie != null)
            {               
                createMovieModel.MovieId = UpdateMovie.MovieId;
                createMovieModel.Name = UpdateMovie.Name;
                createMovieModel.Image = UpdateMovie.Image;
                createMovieModel.Year = UpdateMovie.Year;
                createMovieModel.Genre = UpdateMovie.Genre;
                createMovieModel.Director = UpdateMovie.Director;
                createMovieModel.CinemaHalls = UpdateMovie.CinemaHalls;
                return View(createMovieModel);
                
            }
            else
            {
                ViewBag.error = "Film Bulunamadı";
                return View("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(CreateMovieModel movieModel)
        {
            var UpdateMovie = context.Movies.Include(x => x.CinemaHalls).SingleOrDefault(x => x.MovieId == movieModel.MovieId);
            if (UpdateMovie != null)
            {
                UpdateMovie.MovieId = movieModel.MovieId;
                UpdateMovie.Name = movieModel.Name;
                UpdateMovie.Image = movieModel.Image;
                UpdateMovie.Year = movieModel.Year;
                UpdateMovie.Genre = movieModel.Genre;
                UpdateMovie.Director = movieModel.Director;
                
                movieManager.TUpdate(UpdateMovie);
                return RedirectToAction("Index");

            }
            else 
            {
                return View(movieModel);
            }
        }

        
        public IActionResult Delete(int id)
        {
            var movieList = movieManager.TGetList();
            foreach (var item in movieList)
            {
                if (item.MovieId==id)
                {
                    movieManager.TDelete(item);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error2 = "There is a fault in delete operations.";
                }
            }
            return View();
        }


    }
}
