using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMovieService : IGenericService<Movie>
    {
        List<Movie> TGetByDirectorName(string name);

        List<Movie> TGetByGenre(string genre);

        List<Movie> TGetByMovieName(string movieName);

        List<Movie> TGetByMovieYear(int y1, int y2);
    }
}
