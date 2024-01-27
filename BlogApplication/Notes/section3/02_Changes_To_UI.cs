/*
 * BASIC UI: 
 *      By default our application uses BootStrap.
 *      If we hit the URL localhost/Home/Privacy.
 *      Home is our controller.
 *      Privacy is our Action
 *      
 *  UNDERSTANDNG ACTION AND CONTROLLER RELATION: 
 *      Every action corresponds to the appropriate view.
 *      Under Home controller folder, all the actions will have their views.
 *      RenderBody() is responsible to showcase content from different views
 *      
 *  CHANGES TO UI: 
 *      Under _Layout please add this snippet.
        <li class="nav-item dropdown">
         <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Admin
       </a>
        <ul class="dropdown-menu">
         <li><a class="dropdown-item" href="#">Add A New Tag</a></li>
        </ul>
       </li>
 *      
 */