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
    public class CinemaHallManager : ICinemaHallService
    {
        private readonly ICinemaHallDal _cinemaHalldal;

        public CinemaHallManager(ICinemaHallDal cinemaHalldal)
        {
            _cinemaHalldal = cinemaHalldal;
        }

        public void TAdd(CinemaHall t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(CinemaHall t)
        {
            throw new NotImplementedException();
        }

        public CinemaHall TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CinemaHall> TGetList()
        {
           return _cinemaHalldal.GetList();
        }

        public void TUpdate(CinemaHall t)
        {
            throw new NotImplementedException();
        }
    }
}
