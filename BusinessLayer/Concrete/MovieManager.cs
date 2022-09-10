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
            throw new NotImplementedException();
        }

        public void TDelete(Movie t)
        {
            throw new NotImplementedException();
        }

        public Movie TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Movie t)
        {
            throw new NotImplementedException();
        }
    }
}
