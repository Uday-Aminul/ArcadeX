using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;
using ArcadeX.Api.Repositories.ReviewRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ArcadeX.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewsController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        [HttpGet]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> GetAll()
        {
            var reviewDomains = await _reviewRepository.GetAllReviewsAsync();
            return Ok(reviewDomains);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var reviewDomain = await _reviewRepository.GetReviewByIdAsync(id);
            if (reviewDomain is null)
            {
                return NotFound();
            }
            return Ok(reviewDomain);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var reviewDomains = await _reviewRepository.DeleteReviewByIdAsync(id);
            if (reviewDomains is null)
            {
                return NotFound();
            }
            return Ok(reviewDomains);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Review updatedreview)
        {
            var reviewDomain = await _reviewRepository.UpdateReviewByIdAsync(id, updatedreview);
            if (reviewDomain is null)
            {
                return NotFound();
            }
            return Ok(reviewDomain);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Review newreview)
        {
            var reviewDomain = await _reviewRepository.CreateReviewAsync(newreview);
            return CreatedAtAction(nameof(GetById), new { id = reviewDomain.Id }, reviewDomain);
        }
    }
}