using CoreSWOAS.Business.Interfaces;
using CoreSWOAS.Data.Interfaces;
using CoreSWOAS.Models;

namespace CoreSWOAS.Business.Services
{
    public class PostItService : IPostItService
    {
        private readonly IPostItRepository _repository;

        public PostItService(IPostItRepository repository)
        {
            _repository = repository;
        }

        public PostIt Get(string guid)
        {
            return _repository.Get(guid);
        }

        public string Create(PostIt postit)
        {
            return _repository.Create(postit);
        }

        public void Update(InstancedPostIt postit)
        {
            _repository.Update(postit);
        }

        public void Delete(string guid)
        {
            _repository.Delete(guid);
        }
    }
}