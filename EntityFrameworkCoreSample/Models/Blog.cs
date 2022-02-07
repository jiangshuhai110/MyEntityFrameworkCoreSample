using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EntityFrameworkCoreSample.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Name { get; set; }
         
        public string Url { get; set; }

        public string Url2 { get; set; }

        public DateTime CreateDate { get; set; }


        public ICollection<Post> Posts { get; set; }
    }
}
