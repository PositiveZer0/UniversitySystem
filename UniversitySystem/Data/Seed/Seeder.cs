namespace UniversitySystem.Data.Seed
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using UniversitySystem.Data.Models;

    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var adminRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = "admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });


            var user = new IdentityUser
            {
                Id = "b97122d0-98ec-4e82-a83e-81becf7bc2d7",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEP/isqBqBZ6o1mZC+Qg5npoIiDCYxoFUGK/LZ2vW+5AZwUykMuR7VWnFLQfau/L6bg==",
                EmailConfirmed = true,
                PhoneNumberConfirmed = false,
                PhoneNumber = null,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                AccessFailedCount = 0,
                SecurityStamp = "BCZCUQJFI4GBHUX4DL72DTCW23GRBVEK",
                ConcurrencyStamp = "e66ba402-7a0a-4977-876a-113d0575f9a4",
                LockoutEnabled = true,
            };
            modelBuilder.Entity<IdentityUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = user.Id,
            });

            modelBuilder.Entity<Subject>().HasData(new Subject()
            {
                Id = 1,
                Name = "Матура по български език",
            }, new Subject()
            {
                Id = 2,
                Name = "Свободноизбираема матура",
            }, new Subject()
            {
                Id = 3,
                Name = "Оценка по български език",
            }, new Subject()
            {
                Id = 4,
                Name = "Втора оценка по избираем предмет",
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = 1,
                Name = "AgrarenPU",
                Extension = "jpg"
            },
            new Image
            {
                Id = 2,
                Name = "AmtiiPU",
                Extension = "jpg"
            },
            new Image
            {
                Id = 3,
                Name = "AkademiqMVRSU",
                Extension = "png"
            },
            new Image
            {
                Id = 4,
                Name = "AUBG",
                Extension = "png"
            },
            new Image
            {
                Id = 5,
                Name = "BurgaskiSvobodenUni",
                Extension = "png"
            },
            new Image
            {
                Id = 6,
                Name = "VarnenskiSvobodenUniChernorizec",
                Extension = "png"
            },
            new Image
            {
                Id = 7,
                Name = "VTU",
                Extension = "png"
            },
            new Image
            {
                Id = 8,
                Name = "VoennomorskoUchilishteVaptsarov",
                Extension = "png"
            },
            new Image
            {
                Id = 9,
                Name = "VisheTransportnoKableshkov",
                Extension = "jpg"
            },
            new Image
            {
                Id = 10,
                Name = "VishteTransportnoPoAgrobiznesPu",
                Extension = "png"
            },
            new Image
            {
                Id = 11,
                Name = "VPZIFinansiSO",
                Extension = "png"
            },
            new Image
            {
                Id = 12,
                Name = "VPTIPoshtiSO",
                Extension = "png"
            },
            new Image
            {
                Id = 13,
                Name = "VisheLubenKaravelovSO",
                Extension = "jpg"
            },
            new Image
            {
                Id = 14,
                Name = "EuKolejIkonomikaPU",
                Extension = "jpg"
            },
            new Image
            {
                Id = 15,
                Name = "IkonomicheskiVarna",
                Extension = "png"
            },
            new Image
            {
                Id = 16,
                Name = "KolejPoIkonomikaIAdministraciq",
                Extension = "jpg"
            },
            new Image
            {
                Id = 17,
                Name = "LesotehnicheskiSO",
                Extension = "jpg"
            },
            new Image
            {
                Id = 18,
                Name = "MUVarna",
                Extension = "jpg"
            },
            new Image
            {
                Id = 19,
                Name = "MUPleven",
                Extension = "jpg"
            },
            new Image
            {
                Id = 20,
                Name = "MUPlovdiv",
                Extension = "png"
            }, new Image
            {
                Id = 21,
                Name = "MUSO",
                Extension = "png"
            },
            new Image
            {
                Id = 22,
                Name = "MinnoGeolojkiIvanRilski",
                Extension = "jpg"
            },
            new Image
            {
                Id = 23,
                Name = "NVULevski",
                Extension = "gif"
            },
            new Image
            {
                Id = 24,
                Name = "NATFIZSO",
                Extension = "png"
            },
            new Image
            {
                Id = 25,
                Name = "MuzikalnaAkadPanchoVladigerov",
                Extension = "jpg"
            },
            new Image
            {
                Id = 26,
                Name = "NSASO",
                Extension = "png"
            },
            new Image
            {
                Id = 27,
                Name = "NHASO",
                Extension = "png"
            },
            new Image
            {
                Id = 28,
                Name = "NBUSO",
                Extension = "png"
            },
            new Image
            {
                Id = 29,
                Name = "PaisiiHilendarskiPU",
                Extension = "png"
            },
            new Image
            {
                Id = 30,
                Name = "RusenskiUniversitet",
                Extension = "jpg"
            },
            new Image
            {
                Id = 31,
                Name = "Sofiiski",
                Extension = "png"
            },
            new Image
            {
                Id = 32,
                Name = "StopanskaSvishtov",
                Extension = "png"
            }, new Image
            {
                Id = 33,
                Name = "TUSO",
                Extension = "png"
            },
            new Image
            {
                Id = 34,
                Name = "TUVarna",
                Extension = "png"
            },
            new Image
            {
                Id = 35,
                Name = "TUGAB",
                Extension = "png"
            }, new Image
            {
                Id = 36,
                Name = "TrakiiskiUni",
                Extension = "jpg"
            }, new Image
            {
                Id = 37,
                Name = "AsenZlatarovBurgas",
                Extension = "png"
            }, new Image
            {
                Id = 38,
                Name = "UNSS",
                Extension = "png"
            },
            new Image
            {
                Id = 39,
                Name = "UASGSO",
                Extension = "png"
            },
            new Image
            {
                Id = 40,
                Name = "BITSO",
                Extension = "jpg"
            }, new Image
            {
                Id = 41,
                Name = "UHTSO",
                Extension = "png"
            },
            new Image
            {
                Id = 42,
                Name = "HTMUSO",
                Extension = "png"
            },
            new Image
            {
                Id = 43,
                Name = "Shumen",
                Extension = "png"
            },
            new Image
            {
                Id = 44,
                Name = "UgozapadenBlagoevgrad",
                Extension = "jpg"
            });
        }
    }
}
