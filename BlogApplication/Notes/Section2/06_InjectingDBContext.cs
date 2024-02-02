/*
 * INJECTING DBCONTEXT: 
 *      Dependency Injection is being used for this purpose.
 *      We will inject the dependency into our services container
 *      living under program.cs
 *      
 *      BUILDER : 
 *             1. builder is an object coming from WebApplicationBuilder
 *             2. builder.services.AddDbContext<DbContextType> 
 *             //We will pass the options from our DBContext class
                //builder object will fetch the name of provided connection string
                builder.Services.AddDbContext<BloggieDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("BloggieDbConnection")));
 *             
 *     DEPENDENCY INJECTION:
 *          Dependency Injection is all about giving an object its dependency without letting the receiving end constructing it.
 *          
 *          
 */