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
3. Updating the SeedData class to provide a value for each new model value.
commit successfully
4. updating the migrated values...
using commands as dotnet ef migrations add "rating"
dotnet ef database update
 commit successfully
5. Error - Updating all the CRUD files... commit successfully
5.  Adding validation rules to my model properties as follows:
    All string properties must have a value and cannot be saved without a value. (i.e.
    no null values, strings are required to have a value) - /// Completed successfully
    All strings properties must have either a minimum length, maximum length, or
    both. (ex. a chess player name could have a minimum length of 4 and a maximum
    length of 32) - /// Completed successfully
    The newly added string property (from step 2) must only accept letters, and the
    first letter is required to be uppercase. (i.e. white spaces are also allowed, while
    numbers and special characters are not allowed) - /// Completed successfully
    The newly added integer property (from step 2) must restrict the value to be within
    an range of your choosing - /// Completed successfully
Commit successfully
6. Migration - dotnet ef migrations add "rating Database"
    dotnet ef database update
commit successfully
7. Adding the ability to search my database data on  Razor webapp project's CRUD
    Index page, given the following restrictions:
    You can choose to search against any string property of your model, new or old. - ///Done successfully
    You should be able to submit a value in a form on the CRUD Index page to
    perform the search. - ///Completed successfully
    The search should return data that contains the string value. (i.e. doesn't have to
    be an exact match) - ///Completed successfully
8. Search box worked and Selectlist created successfully
commit successfully ASsignment successfully completed.