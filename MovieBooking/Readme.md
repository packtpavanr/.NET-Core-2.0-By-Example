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
`@page` directive. This makes it distinct as a Razor page  
`@model IndexModel` Indicates the model to be used for page. But this is same as MVC Razor view. If Index.cshtml view also had a model, it would also have looked the same.  

So now, we know that Razor pages are very similar to the Razor view, just that they have `@page` as the first Razor directive. `@page` must be the first Razor directive as it affects the behavior of other Razor constructs.
Rest of the markup can be same as we do in Razor view as it is just the same Razor.

Next lets look at the `IndexModel`

As shown below, Index.cshtml Razor page that we created went inside the Pages folder. We see that the Index.cshtml also has a code behind file named Index.cshtml.cs (and that's why it is similar to aspx pages, where we used to have .aspx.cs/.aspx.vb as code behind files)  
![Index Model](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/blob/master/MovieBooking/wwwroot/images/IndexModel.png)

IndexModel itself derives from PageModel and getts all the properties that we see in the image above.


