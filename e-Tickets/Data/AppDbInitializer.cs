using e_Tickets.Data.Enums;
using e_Tickets.Models;
using eTickets.Data;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Identity;

namespace e_Tickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "IMAX",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of IMAX"
                        },
                        new Cinema()
                        {
                            Name = "Movie House Cinemas",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of Movie House Cinemas"
                        },
                        new Cinema()
                        {
                            Name = "Great Lake's Cinema 3",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of Great Lake's Cinema 3"
                        },
                        new Cinema()
                        {
                            Name = "State Cinemas",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of State Cinemas"
                        },
                        new Cinema()
                        {
                            Name = "Nazareth Cinema",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of Nazareth Cinema"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Matt LeBlanc",
                            Biography = "This is the biography of Matt LeBlanc",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg"
                        },

                         new Actor()
                        {
                            FullName = "Chris Tucker",
                            Biography = "This is the biography of Chris Tucker",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg"
                        },

                          new Actor()
                        {
                            FullName = "Angelina Jolie",
                            Biography = "This is the biography of Angelina Jolie",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg"
                        },

                           new Actor()
                        {
                            FullName = "Jim Carrey",
                            Biography = "This is the biography of Jim Carrey",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg"
                        },

                            new Actor()
                        {
                            FullName = "Will Smith",
                            Biography = "This is the biography of Will Smith",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-5.jpeg"
                        },
                    });

                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                 FullName = "Frank Marshall",
                                 Biography = "This is the biography of Frank Marshall",
                                 ProfilePictureURL = "https://dotnethow.net/images/producers/producer-1.jpeg"
                            },

                              new Producer()
                            {
                                 FullName = "Steven Spielberg",
                                 Biography = "This is the biography of Steven Spielberg",
                                 ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg"
                            },

                                new Producer()
                            {
                                 FullName = "Quentin Tarantino",
                                 Biography = "This is the biography of Quentin Tarantino",
                                 ProfilePictureURL = "https://dotnethow.net/images/producers/producer-3.jpeg"
                            },

                                  new Producer()
                            {
                                 FullName = "Spike Lee",
                                 Biography = "This is the biography of Spike Lee",
                                 ProfilePictureURL = "https://dotnethow.net/images/producers/producer-4.jpeg"
                            },

                                         new Producer()
                            {
                                 FullName = "Jerry Bruckheimer",
                                 Biography = "This is the biography of Jerry Bruckheimer",
                                 ProfilePictureURL = "https://dotnethow.net/images/producers/producer-5.jpeg"
                            }
                        });

                        context.SaveChanges();
                    }

                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                        context.SaveChanges();
                    }

                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                        context.SaveChanges();
                    }
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}


