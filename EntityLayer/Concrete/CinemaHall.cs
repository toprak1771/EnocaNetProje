using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CinemaHall
    {
        [Key]
        public int CinemaHallId { get; set; }

        [Required(ErrorMessage ="Lütfen sinema salonunun adını giriniz")]
        public string Name { get; set; }
               
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
