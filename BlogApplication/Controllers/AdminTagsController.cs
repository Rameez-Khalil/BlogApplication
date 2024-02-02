using BlogApplication.Data;
using BlogApplication.Models.Domain;
using BlogApplication.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //Get the view named Add.
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Store the data.
        [HttpPost]
        [ActionName("Add")]
        public async Task<IActionResult> Add(AddTagRequest addTagRequest)
        {
            //Mapping addTagRequest to the domain model.

            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };
            await bloggieDbContext.Tags.AddAsync(tag);

            //Saving the changes
            await bloggieDbContext.SaveChangesAsync();
            return RedirectToAction("List");
        }

        //Read all the data.
        [HttpGet]
        [ActionName("List")]
        public async Task<IActionResult> List()
        {
            //DB context.
             var tags = await bloggieDbContext.Tags.ToListAsync();
            return View(tags);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var tag = await bloggieDbContext.Tags.FirstOrDefaultAsync(x => x.Id == id);
            if (tag != null)
            {
                var editTagRequest = new EditTagRequest
                {
                    Id = tag.Id,
                    Name = tag.Name,
                    DisplayName = tag.DisplayName
                };
                return View(editTagRequest);
            }
            //In case when there was no tag located.
            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditTagRequest editTagRequest)
        {
            //create a new tag element based off of the domain model.
            var tag = new Tag
            {
                Name = editTagRequest.Name,
                DisplayName = editTagRequest.DisplayName,
                Id = editTagRequest.Id
            };


            var existingTag = await bloggieDbContext.Tags.FindAsync(tag.Id);
            if (existingTag != null)
            {
                existingTag.Name = tag.Name;
                existingTag.DisplayName = tag.DisplayName;

                //Save the changes.
                await bloggieDbContext.SaveChangesAsync();

                //Show success notification.
                return RedirectToAction("Edit", new { id = editTagRequest.Id });
            }

            //If for some reason we were not able to handle the user request properly.
            //Show failure notification.
            return RedirectToAction("Edit", new { id = editTagRequest.Id });

        }

        [HttpPost]
        public async Task<IActionResult> Delete(EditTagRequest editTagRequest)
        {
            var tag = await bloggieDbContext.Tags.FindAsync(editTagRequest.Id);
            if (tag != null)
            {
                bloggieDbContext.Tags.Remove(tag);
                await bloggieDbContext.SaveChangesAsync();

                //show success notification.
                return RedirectToAction("List");

            }
            return RedirectToAction("Edit", new { id = editTagRequest.Id });

        }



    }
}
