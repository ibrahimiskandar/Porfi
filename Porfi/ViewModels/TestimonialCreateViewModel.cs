using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Porfi.ViewModels
{
    public class TestimonialCreateViewModel
    {
        public int Id { get;}
        [Required]
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public int Star { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
