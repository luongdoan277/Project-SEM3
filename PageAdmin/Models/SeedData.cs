using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using PageAdmin.Data;

namespace PageAdmin.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PageAdminContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<PageAdminContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "Trick To Meet Scam",
                        Country = "ThaiLand",
                        Description = "A heartfelt romantic comedy about hoaxes that went wrong for all the right reasons.It starts with a guy named Tower(played by Nadech Kugimiya) who is a fraudster thanks to his handsome looks.along with his skillful and sweet speech.But do not know how skillful this guy is, but in one 'practice', he was caught in the match by a former bank employee named Ina(played by Baifern Pimchanok).",
                        Genre = "Humor",
                        Duration = 128,
                        Language = "ThaiLand",
                        ReleaseDate = DateTime.Parse("2021-01-15"),
                        Trailer = "https://www.youtube.com/embed/x9QhsIA4-LA",
                        Director = "Mez Tharatorn",
                        Cast = "Nadech Kugimiya, Pimchanok Luevisadpaibul, Thiti Mahayotaruk",
                        Status = 1,
                    },
                     new Movie
                     {
                         Title = "Male Born Number 11",
                         Country = "Korea",
                         Description = "Soo Ah is a trainee who transferred to a local school to practice teaching.She became curious about Bu Yeong Seok,the student who was always on the roll,but no one called out ever.The story begins when Soo Ah tries to bring Yeong Seok back to school.",
                         Genre = "Horror",
                         Duration = 112,
                         Language = "Korea",
                         ReleaseDate = DateTime.Parse("2021-01-22"),
                         Director = "Yoo Young Sun",
                         Cast = "Kim So Hye, Johyun, Karin, Ryu Eui Hyun, Park Ji Hoon, Yu Na Gyeol",
                         Status = 1,
                     },
                      new Movie
                      {
                          Title = "You Devil",
                          Country = "American",
                          Description = "Come Play is about a boy Oliver with autism. Through the iPad, Oliver caught waves is the presence of a strange creature in his home is Larry. Realizing something unusual in their son, the boy's parents realize their family is facing a creepy, inhumane guest",
                          Genre = "Humor",
                          Duration = 128,
                          Language = "English",
                          Trailer = "https://youtu.be/vxxJiVfMxCU",
                          ReleaseDate = DateTime.Parse("2021-01-22"),
                          Director = "Jacob Chase",
                          Cast = "Azhy Robertson, Gillian Jacobs, John Gallagher Jr.",
                          Status = 1,
                      }, new Movie
                      {
                          Title = "Hand Gunner",
                          Country = "American",
                          Description = "In the film,Liam plays Jim - a rancher living near the Arizona border.One day,he discovered two mother and son Mexico were trying to escape to America when chased by the leaders of a drug gang of this country.In the emergency situation,Jim helped out and was reluctant to join and the dangerous escape brought the Mexican boy to safety.",
                          Genre = "Act",
                          Duration = 101,
                          Trailer = "https://youtu.be/0VEQ_x0wsr8",
                          Language = "English",
                          ReleaseDate = DateTime.Parse("2021-01-22"),
                          Director = "Robert Lorenz",
                          Cast = "Liam Neeson, Juan Pablo Raba, Katheryn Winnick",
                          Status = 1,
                      }
                      , new Movie
                      {
                          Title = "Life-and-Death Rescue",
                          Country = "American",
                          Description = "After being awarded the Medal of Honor for his courage in the gun battle against ISIS, US Marine Captain Brad Paxton(Gary Dourdan) suffered the lasting effects of being in a war zone. .Under the care of his loving wife, Kate(Serinda Swan), Brad tries to adapt to normal life.Kate, also a famous archaeologist, was given a once -in-a - lifetime career in Morocco, and Brad urged her to pursue it.However, when Kate arrives, she is caught by a terrorist group demanding $ 10 million in ransom.Brad rushed to Morocco when the US ambassador(Andy Garcia) stopped negotiations on Kate's release because the deal jeopardized future oil rights negotiations. When the unusual details of Kate's kidnapping are revealed, Brad is forced to use his military skills to find out who is responsible and save the woman he loves",
                          Genre = "Act",
                          Duration = 94,
                          Trailer = "https://youtu.be/jufq5ptDFco",
                          Language = "English",
                          ReleaseDate = DateTime.Parse("2021-01-22"),
                          Director = "Hicham Hajji",
                          Cast = "Gary Dourdan, Serinda Swan, Andy Garcia",
                          Status = 1,
                      }
                       , new Movie
                       {
                           Title = "Curve Of Devil",
                           Country = "Korea",
                           Description = "Model Hyo Jeong(Lee Chae Young) is facing the risk of unemployment when many generations of beautiful children appear.She decided to join a mysterious yoga class that is rumored to help students regain perfect fitness.Here, she studied with three other female trainees including a boxer, a mentally unstable person and an actress who was obsessed with appearance.However, the yoga class began to be investigated by the police because Bo Ra(Kan Mi Youn), who is a former practitioner here, committed a murder.",
                           Genre = "Humor",
                           Duration = 89,
                           Trailer = "https://youtu.be/d-8ccYablfM",
                           Language = "Korea",
                           ReleaseDate = DateTime.Parse("2021-2-25"),
                           Director = "Juhn Jai-hong, Kim Ji-han",
                           Cast = "Kim In-seo, Lee Chae-young, Kan Mi-youn, Jung Joo-yeon, Choi Cheol-ho",
                           Status = 1,
                       }

                        , new Movie
                        {
                            Title = "Soul - Mysterious Life",
                            Country = "America",
                            Description = "What makes you yourself ? Later this year,the famous animated film studio Pixar will release a new work called SOUL - COLOR LIFE with protagonist Joe Gardner(voiced by Jamie Foxx),a music teacher in high school.He just got a unique chance in life when he could be playing Jazz for the most popular band in town.",
                            Genre = "Humor,Animation",
                            Duration = 108,
                            Trailer = "https://youtu.be/0-UHW0iHjpI",
                            Language = "English",
                            ReleaseDate = DateTime.Parse("2020-12-25"),
                            Director = "Pete Docter, Kemp Powers",
                            Cast = "June Squibb, Jamie Foxx, Daveed Diggs",
                            Status = 1,
                        }
                         , new Movie
                         {
                             Title = "Monster hunter",
                             Country = "America",
                             Description = "Monster Hunter is adapted from the popular game series of the same name by Capcom. In the film, captain Artemis of actress Milla Jovovich (Resident Evil) and teammates accidentally step through a mysterious door leading to another world. Here, they have to fight many giant monsters in their journey back to the world. Accompanying them in the battle is the character Hunter of actor Tony Jaa (Ong Bak). Monster Hunter promises to be an action blockbuster with the most epic monster hunts in 2020.",
                             Genre = "Science Fiction",
                             Duration = 104,
                             Trailer = "https://youtu.be/tNQ6-zorzhg",
                             Language = "English",
                             ReleaseDate = DateTime.Parse("2020-12-31"),
                             Director = "Paul W.S. Anderson",
                             Cast = "Milla Jovovich, T.I., Ron Perlman, Diego Boneta, Tony Jaa",
                             Status = 1,
                         }
                    );
                context.SaveChanges();
            }
            if (!context.CinemaHalls.Any())
            {
                context.CinemaHalls.AddRange(
                    new CinemaHall
                    {
                        Name = "P1",
                        TotalSeats = 80,
                    },
                      new CinemaHall
                      {
                          Name = "P2",
                          TotalSeats = 80,
                      },
                      new CinemaHall
                      {
                          Name = "P3",
                          TotalSeats = 80,
                      },
                      new CinemaHall
                      {
                          Name = "P4",
                          TotalSeats = 80,
                      },
                      new CinemaHall
                      {
                          Name = "P5",
                          TotalSeats = 80,
                      },
                      new CinemaHall
                      {
                          Name = "P6",
                          TotalSeats = 80,
                      },
                      new CinemaHall
                      {
                          Name = "P7",
                          TotalSeats = 80,
                      },
                      new CinemaHall
                      {
                          Name = "P8",
                          TotalSeats = 80,
                      });
                context.SaveChanges();
            }
            if (!context.CinemaSeats.Any())
            {
                context.CinemaSeats.AddRange(
                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 1
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 1

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 1
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 1
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 1
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 1
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 1
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 1
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 1
                    },


                    //P2

                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 2
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 2

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 2
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 2
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 2
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 2
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 2
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 2
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 2
                    },


                    //P3
                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 3
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 3

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 3
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 3
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 3
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 3
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 3
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 3
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 3
                    },



                    //P4
                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 4
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 4

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 4
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 4
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 4
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 4
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 4
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 4
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 4
                    },

                    //P5

                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 5
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 5

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 5
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 5
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 5
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 5
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 5
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 5
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 5
                    },

                    //P6

                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 6
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 6

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 6
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 6
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 6
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 6
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 6
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 6
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 6
                    },

                    //P7

                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 7
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 7

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 7
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 7
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 7
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 7
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 7
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 7
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 7
                    },


                    //P8
                    new CinemaSeat
                    {
                        SeatNumber = "A1",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A2",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A3",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A4",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A5",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A6",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A7",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A8",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A9",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A10",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A11",
                        Type = 1,
                        CinemaHallID = 8
                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A12",
                        Type = 1,
                        CinemaHallID = 8

                    },
                    new CinemaSeat
                    {
                        SeatNumber = "A13",
                        Type = 1,
                        CinemaHallID = 8
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "B1",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B2",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B3",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B4",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B5",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B6",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B7",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B8",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B9",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B10",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B11",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B12",
                        Type = 1,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "B13",
                        Type = 1,
                        CinemaHallID = 8
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "C1",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C2",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C3",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C4",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C5",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C6",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C7",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C8",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C9",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C10",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C11",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C12",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "C13",
                        Type = 2,
                        CinemaHallID = 8
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "D1",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D2",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D3",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D4",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D5",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D6",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D7",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D8",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D9",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D10",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D11",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D12",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "D13",
                        Type = 2,
                        CinemaHallID = 8
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "E1",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E2",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E3",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E4",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E5",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E6",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E7",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E8",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E9",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E10",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E11",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E12",
                        Type = 2,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "E13",
                        Type = 2,
                        CinemaHallID = 8
                    },

                    new CinemaSeat
                    {
                        SeatNumber = "F1",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F2",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F3",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F4",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F5",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F6",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F7",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F8",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F9",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F10",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F11",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F12",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "F13",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G1",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G2",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G3",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G4",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G5",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G6",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G7",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G8",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G9",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G10",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G11",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G12",
                        Type = 3,
                        CinemaHallID = 8
                    }, new CinemaSeat
                    {
                        SeatNumber = "G13",
                        Type = 3,
                        CinemaHallID = 8
                    });
                context.SaveChanges();
            }
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {

                    }

                    );
            }
        }
    }
}
