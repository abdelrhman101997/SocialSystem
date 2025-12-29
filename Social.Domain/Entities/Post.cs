using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Entities
{
    public  class Post :BaseEntity
    {
      
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
