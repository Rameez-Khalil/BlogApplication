/*
 * EF CORE MIGRATIONS: 
 *      1. EF Core migration is a way to update database schema to
 *      match changes in the application's data model.
 *      2. When we make changes to our data model, such that
 *      adding/modifying entities we use migrations to propagate those changes to the underlying database.
 *      
 *      EF CORE BEHIND THE SCENES: 
 *          EF looked into our DBcontext class and saw which props to be converted into table.
 *          
 *      COMMANDS: 
 *          Add-Migration "Name Of Migration".
 *          Update-Database
 *          
 */