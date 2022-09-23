using Comic.DAL.Models;

namespace Comic.BL.Repositories
{
    public interface IComicRepository
    {
        Task<IEnumerable<ComicModel>> GetComics();
        Task<ComicModel> GetComicById(int id);
        Task<ComicModel> PostComic(ComicModel dataComic);
        Task<ComicModel> UpdateComic(int id, ComicModel dataComic);
        Task<string> DeleteComicById(int id);
    }
}
