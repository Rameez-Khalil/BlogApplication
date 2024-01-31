/*
 * DELETE FUNCTIONALITY : 
 *      Admin can use a button to delete the details/tags.
 *      Since we want to display the delete button side by side or rigt next to the submit button under Edit view,
 *      we will wrap the buttons under div container with flex items.
 *      
 *       <div class="mb-3">
            <div class="d-flex">
                <button class="btn btn-dark" type="submit">Update</button>
                <button class="btn btn-danger" type="submit" asp-area="" asp-action="Delete" asp-controller="AdminTags">Delete</button>
            </div>

        </div>
 *      
 *      1. Create a button to perform delete functionality.
 *      2. Add these asp helper tags to the anchor tag asp-area="" asp-action="Delete" asp-controller="AdminTags".
 *      3. Create an action Delete under AdminTagsControler.
 *      4. [HttpPost]
        public IActionResult Delete(EditTagRequest editTagRequest)
        {
            var tag = bloggieDbContext.Tags.Find(editTagRequest.Id);
            if (tag != null)
            {
                bloggieDbContext.Tags.Remove(tag);
                bloggieDbContext.SaveChanges();

                //show success notification.
                return RedirectToAction("List");

            }
            return RedirectToAction("Edit", new { id = editTagRequest.Id });

        }
 */