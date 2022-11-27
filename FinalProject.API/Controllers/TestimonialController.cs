using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;
        public TestimonialController(ITestimonialService _testimonialService)
        {
            this.testimonialService = _testimonialService;
        }

        [HttpGet("GetAlltestimonial")]
        public List<Testimonial> GetAlltestimonial()
        {
            return testimonialService.GetAlltestimonial();
        }
        [HttpPost("CREATEtestimonial")]
        public void CREATEtestimonial(Testimonial testimonial)
        {
            testimonialService.CREATEtestimonial(testimonial);
        }
        [HttpPut("UPDATEtestimonial/{id}")]
        public void UPDATEtestimonial(int id, Testimonial testimonial)
        {
            testimonialService.UPDATEtestimonial(id, testimonial);
        }
        [HttpGet("GettestimonialtById/{id}")]
        public Testimonial GettestimonialtById(int id)
        {
            return testimonialService.GettestimonialtById(id);
        }
        [HttpDelete("Deletetestimonial/{id}")]
        public void Deletetestimonial(int id)
        {
            testimonialService.Deletetestimonial(id);
        }

        [HttpPost]
        [Route("UploadDocuments")]
        [HttpPost]
        public User UploadImage()
        {
            var file = Request.Form.Files[0];
            var filename = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("Documents", filename);
            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            User item = new User();
            item.Imagepath = filename;
            return item;
        }
    }
}
