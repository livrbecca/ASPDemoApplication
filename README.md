# ASPDemoApplication

# ASP.NET
- Umbrella under which Microsoft put all their web-focused tools and applications, everything lives there

# MVC
- One of the things that lives under the umbrella

# Model - View - Controller
- Benefit: All the code is compiled and run on the server, which a user views a website that has been built with MVC, all they see visually is CSS, JS and HTML, no C# code - C# business logic/code is hidden from the user
- MVC => UI-centric pattern

# Controllers
- Link the views with the data, controls the application
- ActionResult is usually a view; controller returns them
- HomeController => under Views, Home folder, Index action will return Index View

# Models
- A class with properties


# Views
Made up of CSS and HTML tags, gets returned by Controllers


# @RenderBody()
Inside HTML body tag
Takes the view / html code and puts in in place
Helpful because the content / views change a lot, not static unlike neav or header

# Razor Syntax
@ symbol - Microsoft creation that allows you to mix C# and html 
@ is to bring in C# code, rendering engine knows when it starts/ends

```<li>@Html.ActionLink("Home", "Index", "Home")</li>```

This creates a link on a page, link is based upon a path/route
Home controller - Index Action - Text will be ‘Home’
Routing - App_Start
Routing happens in App_Start folder
 ``` routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );```

Default route - after the localhost:port-number route, next route to look for is controller/action/id - Home controller /Index action /Id is optional

