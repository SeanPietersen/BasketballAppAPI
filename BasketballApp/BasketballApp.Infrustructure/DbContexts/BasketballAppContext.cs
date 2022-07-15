using BasketballApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BasketballApp.Infrastructure.DbContexts
{
    public class BasketballAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }

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
* |            |   Zibal                       | 2022=07-11 - Changing passwords for users in databse.
* |            |   Zavijava                    | 2022-07-15 - Adding team entities to my database
* |            |   Zaurak                      | 
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
