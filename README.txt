2023-10-11
16:32
I have created a new web application using ASP.NET Core 3.1 
I'm creating a web application to sell my product which is Wallet and named my store "Penny Pouch".

16:36
Changed the welcome message on home page and tested the application and it worked.

16:55
added model named Pouch.cs and added atributes of the product.

16:59
Got an error when i tried to Add NuGet packages using the following command Install-Package Microsoft.EntityFrameworkCore.SqlServer 
the error was Install-Package : NU1202: Package Microsoft.EntityFrameworkCore.SqlServer 7.0.12 is not compatible with netcoreapp3.1 (.NETCoreApp,Version=v3.1).

17:26
i just look back in my readme of the MvcMovie app which i created in the class and resolved it.
and also i created Data folder and a created PennyPouchContext.cs .
added the code from the tutorial.
registered the database context in the program.cs 

17:32
I'm forgetting something... I guesss...
OOhh.... I did not created the github repository... lets do that first..

17:35
Created the repository

17:42
Added database connection string in appsettings.json