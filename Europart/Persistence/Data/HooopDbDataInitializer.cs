using EuropArt.Domain.Artists;
using EuropArt.Domain.Artworks;
using EuropArt.Domain.Common;
using EuropArt.Domain.Likes;
using EuropArt.Domain.Messages;
using EuropArt.Domain.Users;
using EuropArt.Domain.YouthArtworks;
using EuropArt.Persistence.Data;
using System;
using System.Collections.Generic;

namespace EuropArt.Persistence.Data
{
    public class HooopDataInitializer
    {
        private readonly HooopDbContext _dbContext;
        public HooopDataInitializer(HooopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void SeedData()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                User user = new User("Zowie", "Verschuere", "61c1f6a95d5b77007062b218", DateTime.Now);
                User admin = new User("Stef", "Boerjan", "619aaf7421f2b9006fb6eeaa", DateTime.Now);
                _dbContext.Users.AddRange(user, admin); 

                Artist artist2 = new Artist("Wolf", "De Rechter", "Belgium", "Zele", "3800", "Magda Cafmeyerstraat 2", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/124.jpg", DateTime.Now, "Dit is de beschrijving van ...", "www.Lander.be", "619e6d8a8a4c39007207b719");
                Artist artist3 = new Artist("Alex", "De Cock", "Belgium", "Oudenaarde", "9300", "Paalstraat 3", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/125.jpg", DateTime.Now, "Dit is de beschrijving van ...", "www.Alex.be", "61b650bcfcbfe500716d6b1d");
                Artist artist4 = new Artist("Gert", "Meert", "Belgium", "Aalst", "8700", "Pauverleutestraat 6", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/126.jpg", DateTime.Now, "Dit is de beschrijving van ...", "www.Gert.be", "61b650d61c2b8d0069dc044e");

                YouthArtist youthArtist1 = new YouthArtist("Logan", "De Vriend", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/146.jpg", DateTime.Now, "61b650d61c2b8d0069dc044e");
                YouthArtist youthArtist2 = new YouthArtist("Jason", "Smet", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/156.jpg", DateTime.Now, "61b650d61c2b8d0069dc044e");
                YouthArtist youthArtist3 = new YouthArtist("Tuur", "Kwissens", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/135.jpg", DateTime.Now, "61b650d61c2b8d0069dc044e");
                YouthArtist youthArtist4 = new YouthArtist("Patrik", "Goosens", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/165.jpg", DateTime.Now, "61b650d61c2b8d0069dc044e");

                List<Artist> artists = new List<Artist> { artist2, artist3, artist2, artist4 };
                List<YouthArtist> youthArtists = new List<YouthArtist> { youthArtist1, youthArtist2, youthArtist3, youthArtist4 };
                _dbContext.Artists.AddRange(artists);
                _dbContext.YouthArtists.AddRange(youthArtists);

                Artwork artwork1 = new Artwork("Emmer2", new Money(3M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-222), "abstract", "sculptures", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/1.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/2.jpg") });
                Artwork artwork2 = new Artwork("Zonnebloem", new Money(4M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-40), "modern", "painting", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/3.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/4.jpg") });
                Artwork artwork3 = new Artwork("Boter", new Money(12M), "dit is een beschrijving", artist2, DateTime.Now, "surrealism", "sculptures", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/5.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/6.jpg") });
                Artwork artwork4 = new Artwork("Koffielepel", new Money(65M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-80), "modern", "painting", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/7.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/8.jpg") });
                Artwork artwork5 = new Artwork("Tas", new Money(43M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-200), "abstract", "photography", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/9.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/10.jpg") });
                Artwork artwork6 = new Artwork("Hesp", new Money(543M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-25), "minimalism", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/30.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/12.jpg") });
                Artwork artwork7 = new Artwork("Kaas", new Money(23M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-320), "surrealism", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/31.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/14.jpg") });
                Artwork artwork9 = new Artwork("Maan", new Money(58M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-290), "minimalism", "photography", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/17.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/18.jpg") });
                Artwork artwork10 = new Artwork("Feest", new Money(24M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-180), "abstract", "painting", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/19.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/20.jpg") });
                Artwork artwork11 = new Artwork("Tafel", new Money(38M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-90), "minimalism", "painting", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/21.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/22.jpg") });
                Artwork artwork12 = new Artwork("Stoel", new Money(10M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-60), "surrealism", "photography", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/23.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/24.jpg") });
                Artwork artwork13 = new Artwork("Bank", new Money(201M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-50), "minimalism", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/25.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/26.jpg") });
                Artwork artwork14 = new Artwork("Plant", new Money(158M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/27.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork15 = new Artwork("Auto", new Money(158M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/15.jpg") });
                Artwork artwork16 = new Artwork("Schop", new Money(432M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/29.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/16.jpg") });
                Artwork artwork17 = new Artwork("Blik", new Money(54M), "dit is een beschrijving", artist4, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/11.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/49.jpg") });
                Artwork artwork18 = new Artwork("Beker", new Money(46M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/13.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/50.jpg") });
                Artwork artwork19 = new Artwork("Boek", new Money(87M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/32.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/51.jpg") });
                Artwork artwork20 = new Artwork("Fles", new Money(999M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/33.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/52.jpg") });
                Artwork artwork21 = new Artwork("Gsm", new Money(543M), "dit is een beschrijving", artist4, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/34.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/53.jpg") });
                Artwork artwork22 = new Artwork("Doos", new Money(25M), "dit is een beschrijving", artist4, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/45.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/54.jpg") });
                Artwork artwork23 = new Artwork("Kast", new Money(123M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/35.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork24 = new Artwork("Computer", new Money(432M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/36.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork25 = new Artwork("Koelkast", new Money(15M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/37.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork26 = new Artwork("Raam", new Money(13M), "dit is een beschrijving", artist4, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/39.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork27 = new Artwork("Dak", new Money(92M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/40.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork28 = new Artwork("Huis", new Money(165M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/41.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork29 = new Artwork("Tomaat", new Money(100M), "dit is een beschrijving", artist4, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/42.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork30 = new Artwork("Peer", new Money(1M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/43.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork31 = new Artwork("Aquarium", new Money(89M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/44.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork32 = new Artwork("Vissen", new Money(843M), "dit is een beschrijving", artist2, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/46.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                Artwork artwork33 = new Artwork("Katten", new Money(13M), "dit is een beschrijving", artist3, DateTime.Now.AddHours(-4), "abstract", "drawings", new List<ImagePath>() { new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/47.jpg"), new ImagePath($"https://demostoragehogent.blob.core.windows.net/fakeartworks/28.jpg") });
                
                YouthArtwork youthArtwork1 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork2 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork3 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork4 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork5 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork6 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork7 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork8 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork9 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork10 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);
                YouthArtwork youthArtwork11 = new YouthArtwork("jeugd kunstwerk", "Dit is een jeugdkunstwerk", youthArtist1, DateTime.Now);

                //paar artworks op verkocht zetten
                //artwork2.IsSold = true;
                artwork3.IsSold = true;

                youthArtwork1.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/1.jpg";
                youthArtwork2.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/2.jpg";
                youthArtwork3.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/3.jpg";
                youthArtwork4.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/4.jpg";
                youthArtwork5.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/5.jpg";
                youthArtwork6.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/6.jpg";
                youthArtwork7.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/7.jpg";
                youthArtwork8.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/8.jpg";
                youthArtwork9.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/9.jpg";
                youthArtwork10.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/10.jpg";
                youthArtwork11.ImagePath = $"https://demostoragehogent.blob.core.windows.net/fakeyouthartworks/11.jpg";

                
                List<Artwork> artworks = new List<Artwork> { artwork1, artwork2, artwork3, artwork4 , artwork5 , artwork6 , artwork7 , artwork9 , artwork10 , artwork11 , artwork12 , artwork13 , artwork14, artwork15, artwork16, artwork17, artwork18, artwork19, artwork20, artwork21, artwork22, artwork23, artwork24, artwork25, artwork26, artwork27, artwork28, artwork29, artwork30, artwork31, artwork32, artwork33 };

                
                _dbContext.YouthArtworks.AddRange(youthArtwork1, youthArtwork2, youthArtwork3, youthArtwork4, youthArtwork5, youthArtwork6, youthArtwork7, youthArtwork8, youthArtwork9, youthArtwork10, youthArtwork11);
                _dbContext.Artworks.AddRange(artworks);

                Like like = new Like(artist2.AuthId, artwork1);
                Like like1 = new Like(artist2.AuthId, artwork2);
                Like like2 = new Like(artist2.AuthId, artwork3);

                Conversation conversation = new Conversation(user.AuthId, artist2.AuthId/*, artist1.FirstName, artist1.LastName, artist1.Id*/); 
                Message message = new Message("Hallo, is dit kunstwerk nog beschikbaar?", DateTime.Now , "61c1f6a95d5b77007062b218");
                Message message2 = new Message("Hoi, dit kunstwerk is nog beschikbaar.", DateTime.Now , "619e6d8a8a4c39007207b719");
                Message message3 = new Message("Zou u het zelf kunnen leveren of is het de bedoeling dat ik het kom halen?", DateTime.Now , "61c1f6a95d5b77007062b218");
                Message message4 = new Message("U zult zelf het kunstwerk moeten komen halen.", DateTime.Now , "619e6d8a8a4c39007207b719");
                Message message5 = new Message("Welke dag past voor u deze week?", DateTime.Now , "61c1f6a95d5b77007062b218");
                Message message6 = new Message("Voor  mij past donderdag het best.", DateTime.Now , "619e6d8a8a4c39007207b719");
                Message message7 = new Message("Mijn aderes is Magda Cafmeyerstraat 2 in Zele", DateTime.Now , "619e6d8a8a4c39007207b719");
                Message message8 = new Message("Top, dan kom ik er donderdag in de middag om!", DateTime.Now , "61c1f6a95d5b77007062b218");
                _dbContext.Messages.AddRange(message, message2, message3, message4, message5, message6, message7, message8);
                conversation.Messages.Add(message); 
                conversation.Messages.Add(message2); 
                conversation.Messages.Add(message3); 
                conversation.Messages.Add(message4); 
                conversation.Messages.Add(message5); 
                conversation.Messages.Add(message6); 
                conversation.Messages.Add(message7); 
                conversation.Messages.Add(message8);
            
                _dbContext.Conversations.AddRange(conversation);
                _dbContext.Likes.AddRange(like, like1, like2);
                _dbContext.SaveChanges();
            }
        }
    }
}