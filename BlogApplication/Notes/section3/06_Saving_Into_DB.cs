/*
 * SAVING DATA INTO OUR DB : 
 *  DBCOntext class will be utilized for this purpose.
 *  DBContext data will be used by our EFcore and then it will be stored into our database.
 *  
 *  SAVING DATA INTO OUR DB : 
 *     1. Create a DBCOntext variable.
 *     2. Initialize this variable using constructor injection.
 *     3. Inside our controller function, create an object with the help of DomainName (Tag)
 *      var tag = new Tag{
 *          Name = addTagRequest.Name; 
 *          DisplayName = addTagRequest.DisplayName; 
 *          }
 *          
 *     4. Use the reference variable and catch the property that you want to manipulate (Tags)
 *        bloggieDbContext.Tags.Add(tag); 
 *     5. Save those changes.
 *     
 *     
 *     
 *     CONTROLLER FUNCTION:
 *      public IActionResult Add(AddTagRequest addTagRequest)
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

        REFERENCE VAR: 
         //privatae field so we can use it.
        private BloggieDbContext bloggieDbContext; 

        //Constructor Injection.
        //BloggieDB will be injected as a parameter.

        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }
 */