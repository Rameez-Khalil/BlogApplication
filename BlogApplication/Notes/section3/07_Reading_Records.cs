/*
 * READING TAGS AND SHOWING IN A BOOTSTRAP:
 *  1. We will read the records, and show them in a bootstrap table.
 *  2. Inside the AdminTagsController, create a new ActionMethod named List.
 *  3.  //Read all the data.
        [HttpGet]
        [ActionName("List")]
        public IActionResult List()
        {
            //DB context.
            var tags = bloggieDbContext.Tags.ToList(); 
            return View(tags); 
        }

    4. Create the appropriate view for this List action, by right clicking.
    5. Below is the HTML template for displaying.
    
        <div class="bg-secondary bg-opacity-10 py-2">
            <div class="container">
                <h1>Show Tags</h1>
            </div>
        </div>

        <div class="container py-5">
            @if (Model != null && Model.Any())
            {
                <table class="table">
                    <!--Head-->
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Display Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        @foreach (var tag in Model)
                        {
                            <tr>
                                <td>@tag.Id</td>
                                <td>@tag.Name</td>
                                <td>@tag.DisplayName</td>
                            </tr>
                        }
                    </tbody>
                </table>
            }
            else
            {
                <p>No tags were found</p>
            }
        </div>
    6. @model List<BlogApplication.Models.Domain.Tag>; This makes sure that our view is connected with the type of Model that has been defined.
    7. 
 *  
 */