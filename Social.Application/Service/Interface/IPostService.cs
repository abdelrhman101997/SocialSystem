using Social.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Service.Interface
{
    public interface IPostService
    {
        Task<Post> CreatePost(Post post);   
    }
}
