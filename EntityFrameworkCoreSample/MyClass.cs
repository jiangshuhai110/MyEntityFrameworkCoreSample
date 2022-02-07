using EntityFrameworkCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;

namespace EntityFrameworkCoreSample
{
    public class MyClass
    {

        private readonly BloggingContext _context;

        public MyClass(BloggingContext context)
        {
            _context = context;
        }

        public void RunSample()
        {

        }
    }
}
