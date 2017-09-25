using System;
using CoreSWOAS.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace CoreSWOAS.Controllers
{
    /// <inheritdoc />
    /// <summary>
    /// Default sample REST API controller
    /// </summary>
    public sealed class PostItApiController : Controller
    {
        /// <summary>
        /// Get a post-it
        /// </summary>
        /// <param name="guid"></param>
        /// <response code="400">invalid input, object invalid</response>
        [HttpGet]
        [Route("/toolbox/1.0.0/postit")]
        [SwaggerOperation("GetPostIt")]
        public PostIt GetPostIt([FromBody] string guid)
        {
            return new PostIt { Title = "fu", Content = "bar" };
        }

        /// <summary>
        /// Create a post-it
        /// </summary>
        /// <param name="postIt"></param>
        /// <response code="201">item created</response>
        /// <response code="400">invalid input, object invalid</response>
        [HttpPost]
        [Route("/toolbox/1.0.0/postit")]
        [SwaggerOperation("AddPostIt")]
        public string AddPostIt([FromBody] PostIt postIt)
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Update a post-it
        /// </summary>
        /// <param name="postIt"></param>
        /// <response code="201">item updated</response>
        /// <response code="400">invalid input, object invalid</response>
        [HttpPatch]
        [Route("/toolbox/1.0.0/postit")]
        [SwaggerOperation("UpdatePostIt")]
        public void UpdatePostIt([FromBody] InstancedPostIt postIt)
        {
        }

        /// <summary>
        /// Delete a post-it
        /// </summary>
        /// <param name="guid"></param>
        /// <response code="201">item deleted</response>
        /// <response code="400">invalid input, object invalid</response>
        [HttpDelete]
        [Route("/toolbox/1.0.0/postit")]
        [SwaggerOperation("DeletePostIt")]
        public void DeletePostIt([FromBody] string guid)
        {
        }
    }
}
