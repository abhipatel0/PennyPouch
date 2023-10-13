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


21:29
Added Scaffold. While adding scaffold there was an error which shows that the entity type requires a primary key to be defined. 
so I watced tutorials on youtube and solved it by adding [Key] in the Pouch.cs


2023-10-12

00:29
exactly 1 hour it took....;)
added migration and SeedData, but i was not able to navigate to /Pouches when i click on the logo, Then i updated it in _Layout.cshtml


00:39
Now it's time to add other products...


1:09
Finally Added 10 products in SeedData.cs

1:16
when i tested the application, it only shows the previous data..
So I deleted the data and updated the Database... Then it displayed all the data....


21:44
Added About us page....
Now its time to add style and make our website professional ;)

23:57
Finally all the designing is completed...

2023-10-13
3:16 am
I know its too late but I have to do it....
Updated the copyright year which will automaticaly update.

3:28
Successfully Published my webapp on azure..
now I can say that my assignment 1 is completed..
I learned many things while doing this assignment, abd I really enjoyed the process... ;)

And Here's the link of my webapp:- https://pennypouch20231013032331.azurewebsites.net