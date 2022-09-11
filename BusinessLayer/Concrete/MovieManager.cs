using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public void TAdd(Movie t)
        {
            _movieDal.Insert(t);
        }

        public void TDelete(Movie t)
        {
            _movieDal.Delete(t);
        }

        public List<Movie> TGetByDirectorName(string name)
        {
            return _movieDal.GetListByFilter(x => x.Director.Contains(name));
        }

        public List<Movie> TGetByGenre(string genre)
        {
            return _movieDal.GetListByFilter(x => x.Genre == genre);
        }

       

        public Movie TGetById(int id)
        {
            return _movieDal.GetById(id);
        }

        public List<Movie> TGetByMovieName(string movieName)
        {
            return _movieDal.GetListByFilter(x => x.Name.Contains(movieName));
        }

        public List<Movie> TGetByMovieYear(int y1, int y2)
        {
            return _movieDal.GetListByFilter(x => x.Year>=y1 && x.Year<=y2);
        }

        public List<Movie> TGetList()
        {
            return _movieDal.GetList();
        }

        public void TUpdate(Movie t)
        {
            _movieDal.Update(t);
        }
    }
}
