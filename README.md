# .NET Core 2.0 By Example
Code sample to accompany the book *.NET Core 2.0 By Example*, published by Packt

## Chapter 1

[Hello .NET Core 2](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/HelloDotNetCore2)

[F# Console Application](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/FSharpGettingStarted)

### Key takeaways
1. Getting started with .NET Core 2.0 and required setup.
2. Getting started with F# and required setup.

## Chapter 2

[Ubuntu Code Samples](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/Ubuntu%20Code%20Samples)

[PInvoke Example](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/DllImport)

[Example Dll](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/ExampleDLL)

### Key takeaways
1. Getting started with PInvoke using .NET Core
2. Introduction to NCurse and how to consume it from .NET Core

## Chapter 3
[Getting Started](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/GettingStarted)

[Tic-tac-toe](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/TicTacToeGame)

### Key takeaways:
1. Configuring services in ASP.NET Core apps.
2. Configuring and using SignalR Core with ASP.NET Core

### Demo
[Play Tic-tac-toe](http://testdecompression.azurewebsites.net/)
1. The above link would take you to Register page. Register with your name and display image (size should be less than 1 MB) that you wish to use for playing instead of X or O icon, and click Register button.
2. Upon registration, user would be navigated to the "Find Opponent Player" screen, to find an opponent player, against which you can play. Click on the button to find if you have any opponent player. If you don't find anyone, ask your friend to register and find opponent player. Both of you, should now be able to play a game of tic-tac-toe. Enjoy the game!
               
## Chapter 4, 5 and 6
[Let's Chat](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/LetsChat)                        

[Let's Chat Test](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/LetsChatTest)

[Faq Bot](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/FaqBot)

### Key takeaways
1. Integrating Facebook login with your ASP.NET Core app. Google/Microsoft/Twitter can be learnt and tried from [ASP.NET Core documentation](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/)
2. Using configuration.
3. Intro to authorization and authentication.
4. Learn to develop simple FAQ BOT.
5. Get started with simple unit tests.

### Demo
[Let's Chat](https://packtletschat.azurewebsites.net) - Online Chat Room
1. The above link would redirect to Facebook login screen (if you are not already logged in to Facebook). Instead of fetching the user name and image from the user input, the app uses your Facebook profile to get user name and profile picture.
2. Upon login, user would be redirected to Chat Room page. You would be able to chat with all the logged in people in the Let's Chat app.
It displays the message when a user joins or leaves the room and also shows Online Users on the left panel. Happy chatting!

## Chapter 7

[Reference to Cloud Storage Resources with .NET Core 2.0](https://docs.microsoft.com/en-us/aspnet/core/data/azure-storage/?view=aspnetcore-2.0)

## Chapter 8
[Getting Started With EF Core](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/GettingStartedWithEFCore)

[Movie Booking app](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/tree/master/MovieBooking)

[Extended Chapter 8](https://github.com/packtpavanr/.NET-Core-2.0-By-Example/blob/master/MovieBooking/Readme.md)

### Key takeways:
1. Getting started with Entity Framework Core.
2. Learn to do simple CRUD operations using ASP.NET Core 2.0 and apply migrations.
3. Deploy an ASP.NET Core app to Azure.
4. Introduction to Razor pages. I feel Razor pages makes UI development fast and controller approach can be used to make Web APIs. This choice of UI and API development should be very productive, while still maintaining separation of concerns.

### Demo
[Movie Booking App](http://packtmoviebookingapp.azurewebsites.net/)

Just browse the link. The data is fetched from the DataStore class and getting it from SQL database (as hosting and deploying on Azure is a cost) is left as an exercise to the reader. Please refer to Getting Started With EF Core sample to accomplish the same.

[Chat BOT](http://packtmoviebookingapp.azurewebsites.net/Chat.html)  

Chat with ASP.NET Core FAQ BOT and do simple converstaion like Hi, Why ASP.NET Core, MVC, about book, etc. Have Fun !

## Chapter 9
[Blazor Source Code](https://github.com/aspnet/Blazor)

### Key takeaways:
1. Introduction to Blazor.
           
# Usage Instructions
### 1. Clone or download the repository by clicking the Clone or download button.
### 2. For C# and .NET Core Samples:
1. Open the *Packt.DotNetCore2ByExamples.Examples.sln* solution file in Visual Studio 2017
2. Run the app as per chapter information given above.
### 3. For F# Project:
* Open the F# sample project solution in Visual Studio 2017 and run the app.
### 4. For C++ and Ubuntu code samples:
* Ubuntu Code samples should be downloaded and opened with Visual Studio Code.
* C++ ExampleDll solution can be directly opened in Visual Studio 2017.

For a thorough undertsanding and extended reading, following resources are recommended:
1. [ASP.NET Documentation](https://docs.microsoft.com/en-us/aspnet/)
2. [Entity Framework Core Source Code](https://github.com/aspnet/EntityFrameworkCore)
3. [ASP.NET Core MVC Source Code](https://github.com/aspnet/Mvc)
4. [Kestrel Server Source Code](https://github.com/aspnet/KestrelHttpServer)
5. [New Announcements from ASP.NET](https://github.com/aspnet/Announcements) - Keep this repo on watch list for latest and greated updates.
6. [ASP.NET Core docker images](https://github.com/aspnet/aspnet-docker)
7. [SignalR Core Source Code](https://github.com/aspnet/SignalR)
8. [ASP.NET Home Repository](https://github.com/aspnet) - Keep exploring, keep learning.

Though the demo apps should work in all modern browsers, we only checked them against Chrome, so in case you face any issues in other browsers, please try using Chrome browser for demos.
For any issues, questions, suggestions or constructive feedback, please contact [Rishabh Verma](mailto:rishabhv@live.com) or [Neha Shrivastava](mailto:shrivastavaneha18@gmail.com)
