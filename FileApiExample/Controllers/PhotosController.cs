using FileApiExample.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NuGet.Packaging;

namespace FileApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : Controller
    {
        private readonly FileContext _context;

        public PhotosController(FileContext context)
        {
            _context = context;
        }
        //saving to database
        //[HttpPost("Add")]
        //public IActionResult Add([FromForm] IFormFile photo, [FromQuery] string str)
        //{
        //    try
        //    {
        //        MemoryStream stream = new MemoryStream();
        //        photo.CopyTo(stream);

        //        _context.Photos.Add(new Photo
        //        {
        //            ContentType = photo.ContentType,
        //            Name = photo.Name,
        //            ImageData = stream.ToArray()
        //        });

        //        _context.SaveChanges();

        //        return Ok(photo);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [HttpPost]
        public IActionResult Add([FromForm] Profile profile)
        {

            return Ok(profile);
        }
        // saving to folder 
        //[HttpPost]
        //public IActionResult Add(IFormFile photo)
        //{
        //    try
        //    {
        //        string filePath = $"Photos/{photo.Name}_{DateTime.Now.ToString("yyyy_MM_dd_H_m_s")}{Path.GetExtension(photo.FileName)}";
        //        using (FileStream file = new FileStream(filePath, FileMode.Create))
        //        {
        //            photo.CopyTo(file);

        //        }

        //        _context.Photos.Add(new Photo
        //        {
        //            ContentType = photo.ContentType,
        //            Name = photo.Name,
        //            FilePath = filePath
        //        });
        //        _context.SaveChanges();

        //        return Ok(photo);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}


        // saving to database
        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    var photo = _context.Photos.FirstOrDefault(x => x.Id == id);
        //    if (photo is null)
        //    {
        //        return NotFound();
        //    }

        //    return File(photo.ImageData, photo.ContentType, "fromapi_" + photo.Name);
        //    0 - 255

        //      111
        //      001
        //      001
        //}


        // saving to folder 
        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    var photo = _context.Photos.FirstOrDefault(x => x.Id == id);
        //    if (photo is null)
        //    {
        //        return NotFound();
        //    }
        //    var fileOnDisk = new FileInfo(photo.FilePath);
        //    if (!fileOnDisk.Exists)
        //    {
        //        return NotFound("File not found on disk.");
        //    }
        //    var fileStream = new FileStream(photo.FilePath, FileMode.Open, FileAccess.Read);
        //    return File(fileStream, photo.ContentType, "fromapi_" + photo.Name);
        //}

    }
}
