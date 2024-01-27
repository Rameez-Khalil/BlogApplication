/*
 * DATA BINDING : 
 *      There are two ways to capture the data
 *          1. Read Incoming Request - Read data one after another.
 *          2. Model Binding - Dynamically bind the data into an object, and pass that object to our controller.
 *    
 *    
 * POST METHOD FOR CAPTURING : 
 *          We will need to create another method to capture the data.
 *          
 *          FIRST METHOD : 
 *              [HttpPost]
                    [ActionName("Add")]
                    public IActionResult SubmitTag()
                    {
                        var name = Request.Form["name"];
                        var displayName = Request.Form["displayName"];
                        return View("Add"); 
                    }

            SECOND METHOD : 
                 1. We will need to create another folder named ViewModels.
                 2. Inside this folder, we will need to create another TagRequest cs file so we can capture thea data.
                 3. The props that we will create under this model, need to be attached to the controller.
                 4. name attribute will be replaced by asp-for = {name of the prop}.
                 5. @model namespace.ViewModelFile.

                  [HttpPost]
                    public IActionResult Add(AddTagRequest addTagRequest)
                    {
                        var name = addTagRequest.Name; 
                        var displayName = addTagRequest.DisplayName;
                        return View("Add"); 
                    }
 */