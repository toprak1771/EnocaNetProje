using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnocaNetProje.Models
{
    public class CreateMovieModel
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Lütfen filmin adını giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen filmin türünü giriniz.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Lütfen filmin yönetmenini giriniz.")]
        public string Director { get; set; }

       
        public string Image { get; set; }

        [Required(ErrorMessage = "Lütfen filmin yılını giriniz.")]
        [Range(1900, 2100, ErrorMessage = "Lütfen filmin yılını 1900 ile 2100 arasında giriniz")]
        public int Year { get; set; }
        public List<CinemaHall> CinemaHalls { get; set; }

    }
}
