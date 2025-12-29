using Social.Application.Service.Interface;
using Social.Domain.Entities;
using Social.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Service.ServiceClasses
{
    public class PostService : IPostService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public PostService(IUnitOfWork unitOfWork)
        {
          _unitOfWork = unitOfWork;
        }
        public Task<Post> CreatePost(Post post)
        {
           return _unitOfWork.Repository<Post>().AddAsync(post);  
        }
    }
}
