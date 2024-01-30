/*
 * UPDATING RECORDS ONE BY ONE: 
 *      1. Create another view.
 *      2. This view will be responsible for fetching the data for that particular tag by its ID, so we can perform CRUD operations.
 *      3. Add the following snippet into the table, so we can redirect the user to another page.
         <td>
             <a asp-area="" asp-controller="AdminTags" asp-action="Edit"> Edit</a>
        </td>
        4. Create an Action under AdminTags controller named Edit, this will return the view named Edit.
         [HttpGet]
        public IActionResult Edit() {
            return View(); 
        }
        5. We need to send ID of the tag to another page so we can fetch the data associated with it.
            asp-route-id = "@Tag.Id".
        6. We need to capture this ID inside of our controller, the name of the parameter must match with the name we have given asp-route-id, here id should become the name of the paramter.
         [HttpGet]
        public IActionResult Edit(Guid id) {
            return View(); 
        }
        7. Now we need to use EF to talk to the database.
            var tag = BloggieDbContext.Tags.FirstOrDefault(x=>x.Id = id); .
        8. We will make use of model binding approach, for that we will be creating another DB File.
        9. Create a modelbinding file in the view models folder.    
                namespace BlogApplication.Models.ViewModels
                {
                    public class EditTagRequest
                    {
                        public Guid Id { get; set; }
                        public string Name { get; set; }
                        public string DisplayName { get; set; }
                    }
                }

        10. Change the controller function.
             [HttpGet]
        public IActionResult Edit(Guid id) {
            var tag = bloggieDbContext.Tags.FirstOrDefault(x => x.Id == id);
            if(tag!=null)
            {
                var editTagRequest = new EditTagRequest
                {
                    Id = tag.Id,
                    Name = tag.Name,
                    DisplayName = tag.DisplayName
                }; 
            }
            return View(editTagRequest); 
        }
        11. Update the following code in our Edit html file.
    
            @model BlogApplication.Models.ViewModels.EditTagRequest

            <div class="bg-secondary bg-opacity-10 py-2">
                <div class="container">
                    <h1>Edit Tag Admin Functionality</h1>
                </div>
            </div>


            <div class="container py-5">
                <form method="post">
                    <!--Form fields-->
                    <div class="mb-3">
                        <label class="form-label">Id</label>
                        <input type="text" id="id" class="form-control" asp-for="Id" readonly />
                    </div>
                    <div class="mb-3">
                        <label class="form-label">Name</label>
                        <input type="text" id="name" class="form-control" asp-for="Name" />
                    </div>
                    <div class="mb-3">
                        <label class="form-label">Display Name</label>
                        <input type="text" id="displayName" class="form-control" asp-for="DisplayName" />
                    </div>

                    <div class="mb-3">
                        <button class="btn btn-dark" type="submit">Update</button>
                    </div>
                </form>
            </div>

    12. This method will handle the post request sent by the client.
         [HttpPost]
        public IActionResult Edit(EditTagRequest editTagRequest)
        {
            //create a new tag element based off of the domain model.
            var tag = new Tag
            {
                Name = editTagRequest.Name,
                DisplayName = editTagRequest.DisplayName,
                Id = editTagRequest.Id
            };


            var existingTag = bloggieDbContext.Tags.Find(tag.Id);
            if (existingTag != null)
            {
                existingTag.Name = tag.Name;
                existingTag.DisplayName = tag.DisplayName;

                //Save the changes.
                bloggieDbContext.SaveChanges();

                //Show success notification.
                return RedirectToAction("Edit", new { id = editTagRequest.Id });
            }

            //If for some reason we were not able to handle the user request properly.
            //Show failure notification.
            return RedirectToAction("Edit", new { id = editTagRequest.Id });

        }
    

            
            
 */