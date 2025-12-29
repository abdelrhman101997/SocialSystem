using Social.Domain.Entities;
using Social.Domain.Interface;
using Social.Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Infrastructure.Presistance.Repository
{
    public class PostRepository :Repository<Post> ,IPostRepository 
    
    {
        public PostRepository(ApplicationDBContext context)
            : base(context)
        {

            
        }
    }
}
