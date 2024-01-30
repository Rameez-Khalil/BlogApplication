/*
 * DB CONTEXT: 
 *      A bridge between db models and the databasae.
 *      We tell EF what tables to create in what fashion.
 *      We also define relationship between tables.
 *      
 *      DbContext tries to achieve Unit Of Work (Data Consistency) and Repository Pattern (Separation Of Data Access logic and mapping those entities to the business logic).
 *      
 *      
 *      CREATING DB CLASS: 
 *          Create a data folder.
 *          Inside this folder, create a dbcontext class.
 *          
 *         DBSET: 
 *         DBSet<T> this class is used for CRUD operations.
 *         It represents an entitiy set which is a table.
 *         Our Context class must include this DbSet for the props
 *         which are to be used for mapping of props into our table.
 *          
 *          
 */