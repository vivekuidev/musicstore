using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Models
{
    public class AlbumService
    {
        private MvcMusicStoreEntities _context;

        public AlbumService()
        {
            _context = new MvcMusicStoreEntities();
        }
        public List<Album> GetAllAlbums()
        {
            var result = _context.Albums.ToList();
            return result;
        }
        public Album GetAlbumById(int id)
        {
            var result = _context.Albums.FirstOrDefault(x => x.AlbumId == id);
            return result;
        }

    }
}
