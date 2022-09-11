using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class DataGenerator
    {


        public async static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context=new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange
                        (
                            new Movie()
                            {
                                Name = "Moneyball",
                                Director = "Bennett Miller",
                                Genre = "Drama",
                                Image= "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2011
                            },
                            new Movie()
                            {
                                Name = "Legend",
                                Director = "Brian Helgeland",
                                Genre = "Drama",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2015
                            },
                            new Movie()
                            {
                                Name = "The Gray Man",
                                Director = "Anthony Russo",
                                Genre = "Action",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2022
                            },
                            new Movie()
                            {
                                Name = "The Revenant",
                                Director = "Alejandro G. Inarritu",
                                Genre = "Drama",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2015
                            },
                            new Movie()
                            {
                                Name = "Inception",
                                Director = "Christopher Nolan",
                                Genre = "Science Fiction",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2010
                            },
                            new Movie()
                            {
                                Name = "The Departed",
                                Director = "Martin Scorsese",
                                Genre = "Action",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2006
                            },
                            new Movie()
                            {
                                Name = "Interstellar",
                                Director = "Christopher Nolan",
                                Genre = "Science Fiction",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2014
                            },
                            new Movie()
                            {
                                Name = "The Wolf of Wall Street",
                                Director = "Martin Scorsese",
                                Genre = "Comedy",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2013
                            },
                            new Movie()
                            {
                                Name = "Thor: The Dark World",
                                Director = "Alan Taylor",
                                Genre = "Fantasy",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2013
                            },
                            new Movie()
                            {
                                Name = "Fast Five",
                                Director = "Justin Lin",
                                Genre = "Action",
                                Image = "https://cdn.dsmcdn.com/ty12/product/media/images/20200917/17/11016532/87146765/1/1_org_zoom.jpg",
                                CinemaHalls = new List<CinemaHall>(),
                                Year = 2011,
                                
                            }
                        );
                };
                await context.SaveChangesAsync();

                if (context.CinemaHalls.Count() == 0)
                {
                    context.CinemaHalls.AddRange
                        (
                            new CinemaHall()
                            {
                                Name = "Salon1",
                                MovieId = 1
                            },
                            new CinemaHall()
                            {
                                Name = "Salon2",
                                MovieId = 2
                            },
                            new CinemaHall()
                            {
                                Name = "Salon3",
                                MovieId = 3
                            },
                            new CinemaHall()
                            {
                                Name = "Salon4",
                                MovieId = 3
                            },
                            new CinemaHall()
                            {
                                Name = "Salon5",
                                MovieId = 4
                            },
                            new CinemaHall()
                            {
                                Name = "Salon6",
                                MovieId = 5
                            },
                            new CinemaHall()
                            {
                                Name = "Salon7",
                                MovieId = 5
                            },
                            new CinemaHall()
                            {
                                Name = "Salon8",
                                MovieId = 6
                            },
                            new CinemaHall()
                            {
                                Name = "Salon9",
                                MovieId = 7
                            },
                            new CinemaHall()
                            {
                                Name = "Salon10",
                                MovieId = 8
                            },
                            new CinemaHall()
                            {
                                Name = "Salon11",
                                MovieId = 9
                            },
                            new CinemaHall()
                            {
                                Name = "Salon12",
                                MovieId = 10
                            }
                        );
                };
                await context.SaveChangesAsync();
            }                    
            }
        }
    }

