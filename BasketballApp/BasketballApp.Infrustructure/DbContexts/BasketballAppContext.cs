using BasketballApp.Domain;
using BasketballApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace BasketballApp.Infrastructure.DbContexts
{
    public class BasketballAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        public BasketballAppContext(DbContextOptions<BasketballAppContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            //Adding Users
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = 1,
                    FirstName = "Sean",
                    LastName = "Pietersen",
                    Email = "seanpietersen7@gmail.com",
                    Password = "Sean1234"
                },
                new User()
                {
                    UserId = 2,
                    FirstName = "Jason",
                    LastName = "Pietersen",
                    Email = "jase.pietersen7@gmail.com",
                    Password = "Jason1234"
                },
                new User()
                {
                    UserId = 3,
                    FirstName = "Percival",
                    LastName = "Pietersen",
                    Email = "pfpietersen@gmail.com",
                    Password = "Percy1234"
                },
                new User()
                {
                    UserId = 4,
                    FirstName = "Claudia",
                    LastName = "Pietersen",
                    Email = "cmpietersen7@gmail.com",
                    Password = "Claudia1234"
                },
                new User()
                {
                    UserId = 5,
                    FirstName = "Rumer",
                    LastName = "Manis",
                    Email = "rumerkerm@gmail.com",
                    Password = "Rumer1234"
                });

            //Adding Teams
            modelBuilder.Entity<Team>().HasData(
                new Team()
                {
                    TeamId = 1,
                    Name = "Los Angeles Lakers",
                    State = "Claifornia"
                },
                new Team()
                {
                    TeamId = 2,
                    Name = "Los Angeles Clippers",
                    State = "Claifornia"
                },
                new Team()
                {
                    TeamId = 3,
                    Name = "Golden State Warriors",
                    State = "Claifornia"
                },
                new Team()
                {
                    TeamId = 4,
                    Name = "Phoenix Suns",
                    State = "Arizona"
                },
                new Team()
                {
                    TeamId = 5,
                    Name = "Denvor Nuggets",
                    State = "Colorado"
                },
                new Team()
                {
                    TeamId = 6,
                    Name = "Miami Heat",
                    State = "Florida"
                },
                new Team()
                {
                    TeamId = 7,
                    Name = "Orlando Magic",
                    State = "Florida"
                },
                new Team()
                {
                    TeamId = 8,
                    Name = "Atlanta Hawks",
                    State = "Georgia"
                },
                new Team()
                {
                    TeamId = 9,
                    Name = "Chicago Bulls",
                    State = "Illinois"
                },
                new Team()
                {
                    TeamId = 10,
                    Name = "Boston Celtics",
                    State = "Massachusetts"
                });

            //Adding players
            modelBuilder.Entity<Player>().HasData(
                new Player()
                {
                    PlayerId = 1,
                    FirstName = "Stephan",
                    LastName = "Curry",
                    DateOfBirth = new DateTime(1998, 3, 14),
                    PlayerHeight = 1.89,
                    PlayerWeight = 83.9,
                    TeamId = 3
                },
                new Player()
                {
                    PlayerId = 2,
                    FirstName = "Lebron",
                    LastName = "James",
                    DateOfBirth = new DateTime(1984, 12, 30),
                    PlayerHeight = 2.10,
                    PlayerWeight = 113.4,
                    TeamId = 1
                },
                new Player()
                {
                    PlayerId = 3,
                    FirstName = "Kawhi",
                    LastName = "Leonard",
                    DateOfBirth = new DateTime(1991, 6, 29),
                    PlayerHeight = 2.04,
                    PlayerWeight = 102.1,
                    TeamId = 2
                },
                new Player()
                {
                    PlayerId = 4,
                    FirstName = "Devin",
                    LastName = "Booker",
                    DateOfBirth = new DateTime(1996, 10, 30),
                    PlayerHeight = 1.98,
                    PlayerWeight = 93.4,
                    TeamId = 4
                },
                new Player()
                {
                    PlayerId = 5,
                    FirstName = "Nikola",
                    LastName = "Jokic",
                    DateOfBirth = new DateTime(1995, 2, 19),
                    PlayerHeight = 2.2,
                    PlayerWeight = 128.8,
                    TeamId = 5
                },
                new Player()
                {
                    PlayerId = 6,
                    FirstName = "Jimmy",
                    LastName = "Butler",
                    DateOfBirth = new DateTime(1989, 8, 14),
                    PlayerHeight = 2.04,
                    PlayerWeight = 104.3,
                    TeamId = 6
                },
                new Player()
                {
                    PlayerId = 7,
                    FirstName = "Gary",
                    LastName = "Harris",
                    DateOfBirth = new DateTime(1994, 9, 14),
                    PlayerHeight = 1.95,
                    PlayerWeight = 95.3,
                    TeamId = 7
                },
                new Player()
                {
                    PlayerId = 8,
                    FirstName = "Trey",
                    LastName = "Young",
                    DateOfBirth = new DateTime(1998, 9, 19),
                    PlayerHeight = 1.86,
                    PlayerWeight = 74.4,
                    TeamId = 8
                },
                new Player()
                {
                    PlayerId = 9,
                    FirstName = "Lonzo",
                    LastName = "Ball",
                    DateOfBirth = new DateTime(1997, 10, 27),
                    PlayerHeight = 2.01,
                    PlayerWeight = 86.2,
                    TeamId = 9
                },
                new Player()
                {
                    PlayerId = 10,
                    FirstName = "Jayson",
                    LastName = "Tatum",
                    DateOfBirth = new DateTime(1998, 3, 3),
                    PlayerHeight = 2.07,
                    PlayerWeight = 95.3,
                    TeamId = 10
                });

            //Adding Coaches
            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    CoachId = 1,
                    FirstName = "Steve",
                    LastName = "Kerr",
                    YearsOfExperience = 10,
                    IsQualified = true,
                    Rank = RankType.Head_Coach,
                    TeamId = 3
                },
                new Coach()
                {
                    CoachId = 2,
                    FirstName = "Mike",
                    LastName = "Brown",
                    YearsOfExperience = 5,
                    IsQualified = true,
                    Rank = RankType.Assistant_Coach,
                    TeamId = 3
                },
                new Coach()
                {
                    CoachId = 3,
                    FirstName = "Frank",
                    LastName = "Vogel",
                    YearsOfExperience = 2,
                    IsQualified = false,
                    Rank = RankType.Head_Coach,
                    TeamId = 1
                },
                new Coach()
                {
                    CoachId = 4,
                    FirstName = "Mike",
                    LastName = "Penberthy",
                    YearsOfExperience = 15,
                    IsQualified = true,
                    Rank = RankType.Assistant_Coach,
                    TeamId = 3
                },
                new Coach()
                {
                    CoachId = 5,
                    FirstName = "Tyronn",
                    LastName = "Lue",
                    YearsOfExperience = 15,
                    IsQualified = true,
                    Rank = RankType.Head_Coach,
                    TeamId = 2
                },
                new Coach()
                {
                    CoachId = 6,
                    FirstName = "Jason",
                    LastName = "Powell",
                    YearsOfExperience = 1,
                    IsQualified = false,
                    Rank = RankType.Technical_Coach,
                    TeamId = 2
                },
                new Coach()
                {
                    CoachId = 7,
                    FirstName = "Mike",
                    LastName = "Penberthy",
                    YearsOfExperience = 15,
                    IsQualified = true,
                    Rank = RankType.Assistant_Coach,
                    TeamId = 3
                },
                new Coach()
                {
                    CoachId = 8,
                    FirstName = "Kevin",
                    LastName = "Young",
                    YearsOfExperience = 1,
                    IsQualified = false,
                    Rank = RankType.Assistant_Coach,
                    TeamId = 4
                },
                new Coach()
                {
                    CoachId = 9,
                    FirstName = "Erik",
                    LastName = "Spoelstra",
                    YearsOfExperience = 5,
                    IsQualified = true,
                    Rank = RankType.Head_Coach,
                    TeamId = 6
                },
                new Coach()
                {
                    CoachId = 10,
                    FirstName = "Nate",
                    LastName = "McMillan",
                    YearsOfExperience = 2,
                    IsQualified = false,
                    Rank = RankType.Head_Coach,
                    TeamId = 8
                },
                new Coach()
                {
                    CoachId = 11,
                    FirstName = "Todd",
                    LastName = "Campbell",
                    YearsOfExperience = 1,
                    IsQualified = false,
                    Rank = RankType.Technical_Coach,
                    TeamId = 9
                },
                new Coach()
                {
                    CoachId = 12,
                    FirstName = "Ime",
                    LastName = "Udoka",
                    YearsOfExperience = 4,
                    IsQualified = false,
                    Rank = RankType.Head_Coach,
                    TeamId = 10
                },
                new Coach()
                {
                    CoachId = 13,
                    FirstName = "Ben",
                    LastName = "Sullivan",
                    YearsOfExperience = 6,
                    IsQualified = true,
                    Rank = RankType.Assistant_Coach,
                    TeamId = 10
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
/*
 *  These are the database migration versions of Smart Cabinet database
 *  Format: YYYY-MM-dd - short summary of migration
 *
* | DATE USED  |   NAME                        |  Created Date & Purpose
* ====================================================================================================================================
* |            |   Zosma                       | 2022-07-11 - Initial migration adding users to database.
* |            |   Zibal                       | 2022=07-11 - Changing passwords for users in database.
* |            |   Zavijava                    | 2022-07-15 - Adding team entities to the database.
* |            |   Zaurak                      | 2022-07-15 - Adding player and coach entities to the database.
* |            |   Zaniah                      | 
* |            |   Yildun                      | 
* |            |   Yed_Prior                   | 
* |            |   Yed_Posterior               | 
* |            |   Wezen                       | 
* |            |   Wazn                        | 
* |            |   Wasat                       |  
* |            |   Vindemiatrix                | 
* |            |   Veritate                    | 
* |            |   Vega                        | 
* |            |   Unukalhai                   | 
* |            |   Unukalhai_Dummy             | 
* |            |   Tyl                         | 
* |            |   Tureis                      | 
* |            |   Torcularis_Septentrionalis  | 
* |            |   Tonatiuh                    | 
* |            |   Titawin                     | 
* |            |   Tien_Kwan                   | 
* |            |   Thuban                      | 
* |            |   Theemin                     | 
* |            |   Thabit                      | 
* |            |   Terebellum                  | 
* |            |   Tejat_Prior                 | 
* |            |   Tejat                       | 
* |            |   Tegmine                     | 
* |            |   Taygeta                     | 
* |            |   Tarazed                     | 
* |            |   Tania_Borealis              | 
* |            |   Tania_Australis             | 
* |            |   Talitha_Australis           | 
* |            |   Talitha                     |
* |            |   Tabit                       |
* |            |   Syrma                       |
* |            |   Sulafat                     |
* |            |   Suhail                      |
* |            |   Subra                       |
* |            |   Sualocin                    |
* |            |   Sterope                     |
* |            |   Spica                       |
* |            |   Skat                        |
* |            |   Situla                      |
* |            |   Sirius                      |
* |            |   Sinistra                    |
* |            |   Sheratan                    |
* |            |   Sheliak                     |
* |            |   Shaula                      |
* |            |   Sham                        |
* |            |   Seginus                     |
* |            |   Segin                       |
* |            |   Scheddi                     |
* |            |   Schedar                     |
* |            |   Scheat                      |
* |            |   Sceptrum                    |
* |            |   Sarir                       |
* |            |   Sarin                       |
* |            |   Sargas                      |
* |            |   Salm                        |
* |            |   Saiph                       |
* |            |   Sadr                        |
* |            |   Sadatoni                    |
* |            |   Sadalsuud                   |
* |            |   Sadalmelik                  |
* |            |   Sadalbari                   |
* |            |   Sadachbia                   |
* |            |   Sabik                       |
* |            |   Rukbat                      |
* |            |   Ruchbah                     |
* |            |   Ruchba                      |
* |            |   Rotanev                     |
* |            |   Rijl_al_Awwa                |
* |            |   Rigil_Kentaurus             |
* |            |   Rigel                       |
* |            |   Regulus                     |
* |            |   Regor                       |
* |            |   Rastaban                    |
* |            |   Rasalhague                  |
* |            |   Rasalgethi                  |
* |            |   Rasalas                     |
* |            |   Ras_Elased_Australis        |
* |            |   Rana                        |
* |            |   Ran                         |
* |            |   Proxima_Centauri            |
* |            |   Propus                      |
* |            |   Procyon                     |
* |            |   Praecipua                   |
* |            |   Porrima                     |
* |            |   Pollux                      |
* |            |   Polaris_Australis           |
* |            |   Polaris                     |
* |            |   Pleione                     |
* |            |   Pherkard                    |
* |            |   Pherkad                     |
* |            |   Phecda                      |
* |            |   Phact                       |
* |            |   Peacock                     |
* |            |   Okul                        |
* |            |   Ogma                        |
* |            |   Nusakan                     |
* |            |   Nunki                       |
* |            |   Nihal                       |
* |            |   Nembus                      |
* |            |   Nekkar                      |
* |            |   Navi                        |
* |            |   Nashira                     |
* |            |   Nash                        |
* |            |   Naos                        |
* |            |   Nair_Al_Saif                |
* |            |   Musica                      |
* |            |   Muscida                     |
* |            |   Muscida                     |
* |            |   Murzim                      |
* |            |   Muphrid                     |
* |            |   Muliphein                   |
* |            |   Mothallah                   |
* |            |   Mizar                       |
* |            |   Misam                       |
* |            |   Mirzam                      |
* |            |   Mirfak                      |
* |            |   Miram                       |
* |            |   Mirach                      |
* |            |   Mira                        |
* |            |   Mintaka                     |
* |            |   Minkar                      |
* |            |   Minelava                    |
* |            |   Minchir                     |
* |            |   Mimosa                      |
* |            |   Miaplacidus                 |
* |            |   Mesarthim                   |
* |            |   Merope                      |
* |            |   Merga                       |
* |            |   Merak                       |
* |            |   Menkib                      |
* |            |   Menkent                     |
* |            |   Menkar                      |
* |            |   Menkalinan                  |
* |            |   Menkab                      |
* |            |   Mekbuda                     |
* |            |   Meissa                      |
* |            |   Megrez                      |
* |            |   Media                       |
* |            |   Mebsuta                     |
* |            |   Matar                       |
* |            |   Marsic                      |
* |            |   Markab                      |
* |            |   Marfik                      |
* |            |   Marfark                     |
* |            |   Maia                        |
* |            |   Mahasim                     |
* |            |   Maasym                      |
* |            |   Lucida_Anseris              |
* |            |   Libertas                    |
* |            |   Lesath                      |
* |            |   La Superba                  |
* |            |   Kurhah                      |
* |            |   Kuma                        |
* |            |   Kullat Nunu                 |
* |            |   Kraz                        |
* |            |   Kornephoros                 |
* |            |   Kochab                      |
* |            |   Kitalpha                    |
* |            |   Keid                        |
* |            |   Kaus Media                  |
* |            |   Kaus Borealis               |
* |            |   Kaus Australis              |
* |            |   Kastra                      |
* |            |   Kaffaljidhma                |
* |            |   Kabdhilinan                 |
* |            |   Jabbah                      |
* |            |   Izar                        |
* |            |   Intercrus                   |
* |            |   Hydrobius                   |
* |            |   Hyadum                      |
* |            |   Homam                       |
* |            |   Hoedus                      |
* |            |   Heze                        |
* |            |   Helvetios                   |
* |            |   Heka                        |
* |            |   Head of Hydrus              |
* |            |   Hassaleh                    |
* |            |   Hamal                       |
* |            |   Haedus                      |
* |            |   Hadar                       |
* |            |   Grumium                     |
* |            |   Graffias                    |
* |            |   Gorgonea Tertia             |
* |            |   Gomeisa                     |
* |            |   Girtab                      |
* |            |   Gienah                      |
* |            |   Giedi                       |
* |            |   Giausar                     |
* |            |   Gemma                       |
* |            |   Gatria                      |
* |            |   Garnet Star                 |
* |            |   Gacrux                      |
* |            |   Furud                       |
* |            |   Fum al Samakah              |
* |            |   Fomalhaut                   |
* |            |   Fafnir                      |
* |            |   Errai                       |
* |            |   Enif                        |
* |            |   Eltanin                     |
* |            |   Elnath                      |
* |            |   Elmuthalleth                |
* |            |   Electra                     |
* |            |   Edasich                     |
* |            |   Duhr                        |
* |            |   Dubhe                       |
* |            |   Dschubba                    |
* |            |   Dnoces                      |
* |            |   Diphda                      |
* |            |   Diadem                      |
* |            |   Dheneb                      |
* |            |   Denebola                    |
* |            |   Deneb Kaitos Schemali       |
* |            |   Deneb el Okab               |
* |            |   Deneb Dulfim                |
* |            |   Deneb Algedi                |
* |            |   Deneb                       |
* |            |   Dabih                       |
* |            |   Cursa                       |
* |            |   Cujam                       |
* |            |   Cor Caroli                  |
* |            |   Copernicus                  |
* |            |   Chow                        |
* |            |   Chertan                     |
* |            |   Cheleb                      |
* |            |   Chara                       |
* |            |   Chara                       |
* |            |   Chalawan                    |
* |            |   Cervantes                   |
* |            |   Celaeno                     |
* |            |   Cebalrai                    |
* |            |   Castor                      |
* |            |   Caph                        |
* |            |   Capella                     |
* |            |   Capella                     |
* |            |   Canopus                     |
* |            |   Bunda                       |
* |            |   Brachium                    |
* |            |   Botein                      |
* |            |   Biham                       |
* |            |   Betria                      |
* |            |   Betelgeuse                  |
* |            |   Benetnasch                  |
* |            |   Bellatrix                   |
* |            |   Beid                        |
* |            |   Baten Kaitos                |
* |            |   Barnard's Star              |
* |            |   Baham                       |
* |            |   Azmidiske                   |
* |            |   Azha                        |
* |            |   Azelfafage                  |
* |            |   Azaleh                      |
* |            |   Avior                       |
* |            |   Auva                        |
* |            |   Atria                       |
* |            |   Atlas                       |
* |            |   Atik                        |
* |            |   Asterope                    |
* |            |   Asterion                    |
* |            |   Aspidiske                   |
* |            |   Askella                     |
* |            |   Asellus Tertius             |
* |            |   Asellus Secundus            |
* |            |   Asellus Primus              |
* |            |   Asellus Borealis            |
* |            |   Asellus Australis           |
* |            |   Ascella                     |
* |            |   Arneb                       |
* |            |   Armus                       |
* |            |   Arkab Prior                 |
* |            |   Arkab Posterior             |
* |            |   Arich                       |
* |            |   Arcturus                    |
* |            |   Antares                     |
* |            |   Ankaa                       |
* |            |   Angetenar                   |
* |            |   Ancha                       |
* |            |   Alzir                       |
* |            |   Alya                        |
* |            |   Alwaid                      |
* |            |   Alula Borealis              |
* |            |   Alula Australis             |
* |            |   Aludra                      |
* |            |   Alterf                      |
* |            |   Altarf                      |
* |            |   Altais                      |
* |            |   Altair                      |
* |            |   Alshat                      |
* |            |   Alshain                     |
* |            |   Alsciaukat                  |
* |            |   Alsafi                      |
* |            |   Alrescha                    |
* |            |   Alrami                      |
* |            |   Alrakis                     |
* |            |   Alrai                       |
* |            |   Alpheratz                   |
* |            |   Alphecca                    |
* |            |   Alphard                     |
* |            |   Alniyat                     |
* |            |   Alnitak                     |
* |            |   Alnilam                     |
* |            |   Alnasl                      |
* |            |   Alnair                      |
* |            |   Almach                      |
* |            |   Almaaz                      |
* |            |   Alkurah                     |
* |            |   Alkes                       |
* |            |   Alkalurops                  |
* |            |   Alkaid                      |
* |            |   Alioth                      |
* |            |   Alhena                      |
* |            |   Algorab                     |
* |            |   Algol                       |
* |            |   Algieba                     |
* |            |   Algenib                     |
* |            |   Algedi                      |
* |            |   Alfirk                      |
* |            |   Alfecca Meridiana           |
* |            |   Aldib                       |
* |            |   Aldhibain                   |
* |            |   Aldhanab                    |
* |            |   Aldhafera                   |
* |            |   Alderamin                   |
* |            |   Aldebaran                   |
* |            |   Alcyone                     |
* |            |   Alcor                       |
* |            |   Alchiba                     |
* |            |   Albireo                     |
* |            |   Albali                      |
* |            |   Albaldah                    |
* |            |   Alathfar                    |
* |            |   Alaraph                     |
* |            |   Alamak                      |
* |            |   Aladfar                     |
* |            |   Al Thalimain                |
* |            |   Al Thalimain                |
* |            |   Al Minliar al Asad          |
* |            |   Al Kurud                    |
* |            |   Al Kaphrah                  |
* |            |   Al Kalb al Rai              |
* |            |   Al Giedi                    |
* |            |   Al Fawaris                  |
* |            |   Ain                         |
* |            |   Adhil                       |
* |            |   Adhara                      |
* |            |   Adhafera                    |
* |            |   Acubens                     |
* |            |   Acrux                       |
* |            |   Acrab                       |
* |            |   Achird                      |
* |            |   Achernar                    |
* |            |   Acamar                      |
* */
