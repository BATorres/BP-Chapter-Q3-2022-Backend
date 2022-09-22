using Comic.BL.Repositories;
using Comic.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comic.API.Controllers
{
    [Route("api/comic")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        private readonly IComicRepository _comicService;

        public ComicController(IComicRepository comicService)
        {
            _comicService = comicService;
        }

        // GET: api/comic
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _comicService.GetComics();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/comic/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var userFound = await _comicService.GetComicById(id);
                if (userFound == null) return NotFound();

                return Ok(userFound);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/comic
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ComicModel dataComic)
        {
            try
            {
                var resultComic = await _comicService.PostComic(dataComic);
                return Ok(resultComic);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/comic/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ComicModel dataComic)
        {
            try
            {
                if (id != dataComic.Id) return NotFound();
                await _comicService.UpdateComic(id, dataComic);
                return Ok(new { message = "Data updated successfuly." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // DELETE api/comic/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _comicService.DeleteComicById(id);
                if (result == "NOT_FOUND") return NotFound();
                return Ok(new { message = "Data deleted successfuly." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
