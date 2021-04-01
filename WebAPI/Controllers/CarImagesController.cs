using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _carImageService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _carImageService.GetAllByCarId(carId);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name ="Image")]IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(file,carImage);
            return StatusCode(result.Success ? 200 : 400, result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Update(file,carImage);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
