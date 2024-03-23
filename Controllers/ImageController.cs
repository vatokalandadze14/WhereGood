using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Services.ImagesServiceFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Image>>> GetImages()
        {
            return Ok(await _imageService.GetImages());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetImage(Guid id)
        {
            return Ok(await _imageService.GetImage(id));
        }
        [HttpPost]
        public async Task<ActionResult<Image>> AddImage(ImageCreateDto image)
        {
            return Ok(await _imageService.AddImage(image));
        }
        [HttpPut]
        public async Task<ActionResult<Image>> UpdateImage(Guid id, ImageCreateDto image)
        {
            return Ok(await _imageService.UpdateImage(id, image));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<Image>>> DeleteImage(Guid id)
        {
            return Ok(await _imageService.DeleteImage(id));
        }
    }
}
