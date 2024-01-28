using BlogApplication.Data;
using BlogApplication.Models.Domain;
using BlogApplication.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace BlogApplication.Controllers
{


    public class AdminTagsController : Controller
    {
        //privatae field so we can use it.
        private BloggieDbContext bloggieDbContext; 

        //Constructor Injection.
        //BloggieDB will be injected as a parameter.

        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }
        //We need to provide a form so user can fill it and 
        //our controller can use the data and inject it into our database.

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //Mapping addTagRequest to the domain model.

            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };
            bloggieDbContext.Tags.Add(tag); 
            
            //Saving the changes
            bloggieDbContext.SaveChanges();
            return View("Add");
        }


    }
}
