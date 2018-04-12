# Movie Booking App

This file provides a high level explanation of concepts used in Movie Booking App. Before diving into the working of the app, I would like to call out that the intention of Movie Booking App is to make the reader familiar with Entity Framework Core and Razor pages. We have already seen and worked with Entity Framework core in the sample application, where we did CRUD operations using Entity Framework Core.
We touched upon Razor pages in Chapter # 6 of the book, but did not see it in detail, so we will first undertsand what are Razor pages and then move on to the movie booking app development.

## Razor Pages

Recall that even if we need to create a simple view using MVC framework, we need to create a model, view and controller. At times model may not be needed (by using ViewBag), but even in this scenario, we still need to create a controller and a view. This is bare minimum work that we need to do, to create the view and wire it up.
ASP.NET Core 2.0 comes up with a new framework for creating the pages, without the complexity and work that comes by virtue of using MVC. Its pretty safe to say, that Razor pages are leaner version of MVC and reminds us of the old school aspx web forms.
Razor Pages makes the UI development very productive and easier. And the best part is that you need not do anything extra to leverage the goodness of Razor pages. The normal ASP.NET Core 2.0 web project is ready to use this new feature of ASP.NET Core 2.0.
If we were to create a view named Index, we would create a HomeController (or any other controller as required), then add an action named Index and finally, return View in the action, which would wire up to Index.cshtml Razor view. This Index.cshtml view sits inside Views folder in the subfolder named Home and looks like:
```
@{
    ViewData["Title"] = "Home Page";
}

<!--HTML/Razor markup for the view -->
```

and in the solution explorer, the location is as shown below:

![Razor View](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/blob/master/MovieBooking/wwwroot/images/RazorView.png)

Now, lets see how we can achieve the same using the new Razor pages. Add new item to your project, below dialog would display

![Add RazorPage](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/blob/master/MovieBooking/wwwroot/images/RazorPage.png)

Choose RazorPage as shown above and name it as Index.cshtml

Below is how a simple Razor page corresponding to Index action (that we defined above) looks like:

```
@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}
```

Notice that RazorPage looks very similar to the view we created, just that it has two additional lines of code in  
`@page` directive. This directive tells the Razor engine that Hey! I am a cshtml file, but I am a Razor page (and not view :)). Treat me as an action! 
`@model IndexModel` Indicates the model to be used for page. But this is same as MVC Razor view. If Index.cshtml view also had a model, it would also have looked the same.  

So now, we know that Razor pages are very similar to the Razor view, just that they have `@page` as the first Razor directive. `@page` must be the first Razor directive as it affects the behavior of other Razor constructs.
Rest of the markup can be same as we do in Razor view.

Index.cshtml Razor page that we created went inside the Pages folder. This is the default location for the Razor pages, but can be changed. You would also notice that we do not have any Views and Controllers folder. So what happens to the Layout, ViewImports, ViewStart views that we saw earlier. They are now created right inside Pages folder and there is no Shared folder that we see in Views. 

We can use and do everything inside Razor pages that comes with MVC, so model binding works as is. We have handlers in razor page, which can do the same work as action methods do in controller. All the goodness of Tag Helpers and Html helpers is available in Razor pages as well. The routing is also pretty simple. The path of the Razor page in the project file system determines the matching url. To give an example, below would be the mapping for file system path and url

Physical File System Path | **URL**
--- | --- 
~Pages/Index.cshtml | **/** or **/Index**
~Pages/Orders/Index.cshtml | **/Orders** or **/Orders/Index**
~Pages/Orders/Edit.cshtml | **/Orders/Edit/1**
~Pages/Orders/Create.cshtml | **/Orders/Create**

Route can be configured in the `@page` directive. For example, if your Razor page expects an order id (lets name the property as id) for editing the order, we can define the page route as below:
```
@page "{id}"
```  
or  
```
@page "{id:int}"
```  
If you wish to pass multiple parameters like this, we can do so for as many parameters as we want. The below code sample demonstrates two parameters
```
@page "{id:int}/{seats:int}"
```  
This much information on routing would be good enough to complete our sample app. Detailed coverage on routing is beyond the scope of this by example book, so interested readers may want to read more about routing [here](https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages/razor-pages-convention-features?view=aspnetcore-2.0)

Next lets look at the `IndexModel`  
![Index Model](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/blob/master/MovieBooking/wwwroot/images/IndexModel.png)  
We see that the Index.cshtml also has a code behind file named Index.cshtml.cs (and that's why it is similar to aspx pages, where we used to have .aspx.cs/.aspx.vb as code behind files). This provides neat code seperation, i.e. Razor inside cshtml and the C# code in code behind file. This code behind file is also the model of the page.  
Let's have a look at the code behind **.cs** file
```
namespace MovieBooking.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }        
    }
}
```  
`IndexModel` itself derives from `PageModel` and gets all the properties that we see in the image above. Notice that the convention of model class is `<PageName>Model`. For Index page, it becomes `IndexModel` and so on. We can define properties, handlers (think of them as actions) and other logic in this file and this is what makes the Razor Pages extremely powerful and productive. We can do dependency injection in the code behind pages, the same way we did for controllers

Notice that the `IndexModel` (created from default template of PageModel) has a method named `OnGet()`. This is the handler for the GET HTTP Request. Like wise we can add handlers for any HTTP verb, like PUT, POST, DELETE. We can also have `async` handlers as shown below
```
public async Task<IActionResult> OnGetAsync(int id)
{
}

public async Task<IActionResult> OnPostAsync()
{
     if (!ModelState.IsValid)
     {
          return Page();
     }
     
     return this.RedirectToPage("/BookTicket", this.SelectedMovieId);
}
```  
`OnGet` handler is used to initialize the state of the page, when its loaded. So for example, if we have 



