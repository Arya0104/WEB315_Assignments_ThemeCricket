# WEB315_Assignments_ThemeCricket

1. Created PRIVATE repository WEB315_Assignments_ThemeCricket
2. gitignore created
3. readme created
4. Collabration link sent Majid1292
5. Creating WebApplication.
6. Updating the welcome page
comitted successfully

7. Created Models folder and ThemeCricket.cs file and created 6 properties including one ID and one date
comitted successfully

8. Installing the EF Tools and NuGet packages
    dotnet tool install --global dotnet-ef --version 5
    dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

    installed successfully and comitting

9. Using Scaffolding terminal commands to build out CRUD pages for model
    dotnet-aspnet-codegenerator razorpage -m ThemeCricket -dc ThemeCricketContext -udl -outDir Pages/ThemeCricket --referenceScriptLibraries -sqlite

    successfully installed and comitted successfully

10. Creating the initial database schema using EF's  migration feature
    dotnet ef migrations add InitialCreate
    dotnet ef database update

    Committed successfully

11. Adding Theme Index to the Nav bar of Home page
successfully installed and comitted successfully

12. Creating 6 Database values for the properties created in Theme. Created new file as SeedData.cs Commit successfully

13. Updated Database values and Initializing SeedData.cs 
    Was getting too many errors in dotnet build, beacuse I failed to update database first before initializing and updated it on old value, then had to manually update the CRUD pages and ran command dotnet ef migrations add "rating"

    Completed successfully and comitted successfully

   ////////////// Continuing with Assignment 02 - By the name Assignment_02_Branch///////////////////

1. Branch created by the name Assignment-2
2. 2 new property added as an int and string... commit successfully