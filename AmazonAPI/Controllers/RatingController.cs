using Amazon.Application.Services;
using Amazon.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService ratingService;

        public RatingController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
        }
        [HttpPost]
        [Route("addRate")]
        public async Task<IActionResult> addRate(RatingDTO ratingDTO)
        {
            var rate= await ratingService.createRating(ratingDTO);
            return rate != null ? Ok(rate) : BadRequest();
        }
        [HttpGet]
        [Route("getAllRating")]
        public async Task<IActionResult> getAllRatingByProductId(int productId)
        {
            var rate = await ratingService.GetAllByProductIdAsync(productId);
            return rate != null ? Ok(rate) : BadRequest();
        }
    }
}
