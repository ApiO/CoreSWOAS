using System;
using CoreSWOAS.Data.Interfaces;
using CoreSWOAS.Models;

namespace CoreSWOAS.Data.Repositories
{
    /// <inheritdoc />
    public class PostItRepository : IPostItRepository
    {
        // see also core configuration system: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration

        public PostIt Get(string guid)
        {
            return new PostIt { Title = "title", Content = "content" };
        }

        public string Create(PostIt postit)
        {
            return Guid.NewGuid().ToString();
        }

        public void Update(InstancedPostIt postit)
        {
            // do some stuff
        }

        public void Delete(string guid)
        {
            // do some stuff
        }
    }
}