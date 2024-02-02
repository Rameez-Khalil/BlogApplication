/*
 * MAKING METHODS ASYNC:
 *      Change the method definition, add async keyword and wrap the IActionResult by Task<IActionResult>.
 *      Add await keyword to all those lines which can take time
 *      
 *      FOR EXAMPLE THIS BELOW METHOD:
 *      
 *      //Store the data.
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
            return RedirectToAction("List");
        }

        UPDATED VERSION:

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


             await bloggieDbContext.Tags.Add(tag);

            //Saving the changes
            await bloggieDbContext.SaveChanges();
            return RedirectToAction("List");
        }
 *      
 */