using CoreSWOAS.Business.Interfaces;
using CoreSWOAS.Framework;
using CoreSWOAS.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace CoreSWOAS.Controllers
{
    /// <inheritdoc />
    /// <summary>
    /// Default sample REST API controller
    /// </summary>
    public sealed class PostItApiController : DefaultController
    {
        private readonly IPostItService _service;

        /// <inheritdoc />
        public PostItApiController(IPostItService service)
        {
            _service = service;
        }

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
            return _service.Get(guid);
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
            return _service.Create(postIt);
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
            _service.Update(postIt);
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
            _service.Delete(guid);
        }
    }
}