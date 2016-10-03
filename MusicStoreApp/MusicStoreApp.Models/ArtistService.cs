using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Models
{
    public class ArtistService
    {
        private MvcMusicStoreEntities dbContext;
        public ArtistService()
        {
            dbContext = new MvcMusicStoreEntities();
        }
        public List<Artist> GetArtists()
        {
           return dbContext.Artists.ToList();
        }

        public Artist GetArtist(string artistName)
        {
            return dbContext.Artists.FirstOrDefault(x => x.Name == artistName);
        }

        public int CreateArtist(Artist artist)
        {
            dbContext.Artists.Add(artist);
           return dbContext.SaveChanges();
        }
    }
}
