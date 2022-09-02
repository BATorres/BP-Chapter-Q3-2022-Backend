using Comic.BL.Repositories;
using Comic.DAL;
using Comic.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Comic.BL.Services
{
    public class ComicService: IComicRepository
    {
        private readonly ApiDbContext _context;

        // Creamos un constructor e inyectar el contexto
        public ComicService(ApiDbContext context)
        {
            _context = context;
        }


        // GET Comics
        public async Task<IEnumerable<ComicModel>> GetComics()
        {
            var listUsers = await _context.Comic.ToListAsync();
            return listUsers;
        }

        // GET Comic By Id
        public async Task<ComicModel> GetComicById(int id)
        {

            var comicFound = await _context.Comic.FindAsync(id);
            return comicFound;
        }


        // POST Comic
        public async Task<ComicModel> PostComic(ComicModel dataComic)
        {
            _context.Comic.Add(dataComic);
            await _context.SaveChangesAsync();
            return dataComic;
        }


        // UPDATE
        public async Task<ComicModel> UpdateComic(int id, ComicModel dataComic)
        {
            _context.Comic.Update(dataComic);
            await _context.SaveChangesAsync();
            return dataComic;
        }

        // DELETE
        public async Task<string> DeleteComicById(int id)
        {
            var comicFound = await _context.Comic.FindAsync(id);
            if (comicFound == null)
            {
                return "NOT_FOUND";
            }
            _context.Comic.Remove(comicFound);
            await _context.SaveChangesAsync();
            return "OK";
        }
    }
}
