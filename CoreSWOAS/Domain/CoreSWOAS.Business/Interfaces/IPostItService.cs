using CoreSWOAS.Models;

namespace CoreSWOAS.Business.Interfaces
{
    public interface IPostItService
    {
        /// <summary>
        /// Return a post-it
        /// </summary>
        /// <param name="guid">Guid of the post-it to return</param>
        /// <returns></returns>
        PostIt Get(string guid);

        /// <summary>
        /// Create a post-it
        /// </summary>
        /// <param name="postit">Post-it to create</param>
        /// <returns></returns>
        string Create(PostIt postit);

        /// <summary>
        /// Update a post-it
        /// </summary>
        /// <param name="postit">Post-it to update</param>
        void Update(InstancedPostIt postit);

        /// <summary>
        /// Delete a post-it
        /// </summary>
        /// <param name="guid">Guid of the post-it to delete</param>
        void Delete(string guid);
    }
}