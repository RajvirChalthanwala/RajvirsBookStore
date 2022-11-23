2022-10-27  7:12PM ---------------------------------
Creating this web application named : "Rajvir'sBookStore" using ASP.NET
- added the description and enabled the Individual account authorization....
- Added the Runtime complier option just for fun !!!!
- Created the Project at 6:53PM
- commented the line 34 to remove default flagged : "options => options.SignIn.RequireConfirmedAccount = true"
Sucessfully, checked the project and few files mentioned in the PPT

7:13PM 
Created the GIT repo... and updated the git changes to the repository made...
- added the README.txt file in the project which is mandatory...

7:14PM 
completed this steps... mentioned to make it error free for this Book Store application
- Commiting to git repo!!! 🙂
- Description added for the long term support...
- cleaning the project and again rebuilding it 
- Running the project....
- let check what it looks like ;) 

7:15PM
Commented out the SSL Port for the lab use which will not caue the error..
from the properties line I commented the line 7..
Let's finally check the application we just created !!!

7:16PM
No errors were found and everything looks good as per the professor's instruction...
- tried doing debugging test for the natural process to know the solution of problems which will occur in near future...
- Saved the content and doing it further for next steps.. 🙂

7:34PM
- Go to wwwroot > replace the existing site.css file found in the main css folder
- Go to Views > Shared > _Layout.cshtml, change the file name from bootstrap.min.css to bootstrap.css
- Change the nav class from navbar-light to navbar dark and bg-white to bg-primary
- Line 23 - remove text-dark
Created the Bootswatch file and added the css file.
replaced the content which were mentioned in the PPT...
Rebuild the project and cleaned....
commited to git repository and saved the content till Bootswatch file content now after one short break will continue with 
the next 3rd party java file....
Now no errors found !!! ;) 7:37PM 

28-10-2022    12:05PM --------------------------------
- changed the theme as to make it look unique and good...
- go to wwwroot folder
- add the bootstrap.css file downloaded from the bootswatch theme.
- taken "United" theme to check it.....
- cleaned the project and saved the content
- check the application and.....
- commit to Github repository to change it on the repo.... !

12:19PM
- completed the bootswatch step and commited to Github.
- saved the content and moving forward...

1:20PM
- replaced the site.css file provided by the professor..
- added the content to _layout.cshtml about css files
- Datatables, SweetAlert, FontAwsome and Toastr URLS...
- Additional 3rd party files for Java-Script files URLS...
edited the layout file as per the reqirements !!!!!
Removed all the "text-dark" from _loginPartials.cshtml file...

- commit the files to github repo....
- rebuild the project and run the application to look all  changes made !!!! 1:30PM

1:31PM
- removed the breakpoints from the "HomeControllers.cs" file.

02-11-2022    8:18PM --------------------------------
Created the README.md file for the description of te web application displayed on the github only...
- Adding the dropdown box in the View >  shared > _layout.cshtml file.....
- Now just typing the code for the above mentioned code !!!
- Updated the lines from 32 to 37 in _layout.cshtml file !!!!
saved the content and uploading it to the git repo... and rebuilding the projec again and checking it if the erroroccurs or not ?  8:31PM

8:32PM
- changed the "Dropdown" anchor tag to "Content Management" in the same file: View > Shared >  _layout.cshtml...
No errors so far🙂

03-11-2022    7:00PM --------------------------------
- deleted the .DataAccess class library to complete this step and again start the same solution as per
the pptx provided by the professor and again commiting it to the github repo... 

7:08PM
- Created the RajvirsBooks.DataAccess class library by following the four steps
- keeping the name: "RajvirsBooks.DataAccess" file
- selecting the same options of c#, All platforms, All types
- select the first class library
- choose 3.1 long-term support
- select the path as "C:\Users\rajvi\source\repos\RajvirChalthanwala\RajvirsBookStore"
- Created sucessfully...
- Saved the content and commit all to git repo... lets see the changes 7:11PM

7:17PM
- checked the same project by cloning it from the repository if the same folder exists or not
- Created the rest of the class library the same way using the four steps of checking it
- slecting the same directory but eith two different names: "RajvirsBooks.Models" and "RajvirsBooks.Utility"
- choosing the same 3.1 long-term support and..
- saving the content in the local step and commiting it to the git....
- one more step before commiting is pasting the "Data" folder in the .DataAccess library...
- commit all! 7:21PM

7:24PM
- As per the further step I created the class library and than installed the NuGet Packages...
- Installed the "Microsoft.EntityFramework.Core.Relational" 3.1.28 version
- Another installing the same version but package "Microsoft.EntityFramework.Core.sqlserver"...
- updated the README.txt and commiting the files to the git repo...
- saving the content! 7:28PM

7:30PM
- Deleted the Migrations folder from ".DataAccess > Data > Migrations"
- Updated the README.txt and update the GitHub repo...
- Save the content... 

7:37PM
- Install the next packages from Tools > Package Console > Manage the Package Console
- Commit to GitHub....

7:40PM
- Edited the line number 7 to change the namespace in the "Application.Dbcontext" file
- from RajvirsBookStore.Data > RajvirsBookStore.DataAccess.Data
- Deleted the all default class1 files created by default by the class library...
- commit the file to repo... 7:42PM

7:46PM
- Build the project
- 0 Succeeded, 1 Failed
- checked the error list and found 49 Errors... 🙁
- continuing the project with further steps after commiting it.
- Deletd the original Models folder form the existing project and moved it to the "RajvirsBooks.Models" library.
- saved the content
- commit all ! 7:49PM

8:04PM
- Added the refrences in bith the files the DataAccess and Models
- Rename the RajvirBooks.Models > Models folder to ViewModels...
- commit the changes to repo...
- save the content.

8:08PM
- change the namespace from .Models to .Models.ViewModels in the line number 3 in 
RajvirBooks.Models > ViewModels > ErrorViewModel.cs
- commit to github repository and save the content.

8:12PM
- Changed the content of the project build again
- 1 succeeded, 0 Failed...
- commit to repo. 8:13PM

8:16PM
- Modify the Startup.cs file in the line 31 and 36 by pressing Alt + Ent and wrote 
RajvirsBook.Data.DataAccess instead of ApplicationDbContext.
- just changed the refrence...
- Run the Application and Review the error 🙁

8:21PM
- Runed the appliocation 52 Errors found ans appliction didnt succeeded
- Removed the "using RajvirsBookStore.Data;" line from Startup.cs file
- Now 51 Errors still found 
- correct default refreces from Error.cshtml file.
- Changed the First line of Error.cshtml
- Now 48 Errors found so far...
- Commit the project to repo...
- Save the content 8:25PM

8:28PM
- trying to solve this 48 Errors but nothing changes till now...
Stopped the work !!! Take a rest

11:05PM
Created a new application and added the README.txt.... creating a git repository called RajvirsBookStore
Complting the steps till part 1.3 again

7:53PM
Got 48 duplications error of conflict "Reflection duplication error found in ApplicationDbContext" and 
finally solved this error by changing the name of the class library by "RajvirsBooks.DataAccess" from "RajvirsBook.DataAccess"
7:54PM

2022-11-07  1:04PM --------------------------------
- Changed the location of the Home folder and shifted it to the View Folder !!!
- Run the application...
- succeeded and save the content.
- upload to git... 1:05PM

// ----------------------------------------------------------------------------------------------------- //


2022-11-09  13:30  ----------------------------------
- Changed the old reposiotry name to "RajvirsBookStore_OLD"
- copied the README content to my local PC and starting to make new Web application
- there were lots of duplications error for the newley creaed project 
because of the path.
- now making it again from strap....
- hope now I wont get any error
- created the project at    1320
- created the README.txt file
- creating new git repo....
commit all to github repo... 
13:46

14:43 
- Right after one hour a completed the full steps again
but kept the 3 project files outside the RajvirsBookStore folders
- as there are no such duplication error now i can run my application
- save the content and update all the commits to github repository...
14:45

2022-11-10  13:04 ----------------
- Deleted the Old Repository and solved the error of Duplication....
- In the first step by Unchecking the "Save the project and solution file in the same directory" box
Doing the whole Part - 1 ...

18:05 ----------------
- Started with the Utility class project as per the pptx.
- move the Homecontrollers.cs file to Area > View > home and delete the "Data" and "Models" folder...
- Save the content and run the application
- After running the web application update the git repo... 0608

18:11 ----------------
- Add Area Admin in the Areas folder.
- Delete the "Data" and "Models" folder from it...
- View the content properly and delete the Controllers folder from the main project !!!
- Update the github repository and save the content...
18:12

---------------------------------------- [END OF PART-1] ----------------------------------------


2022-11-10  08:30 -----------------
- Starting Assignment_2 Part - 2 using the same project in the Visual Studio Community 2019...
- ASP.NET Core 3.1
- Open the Visual Studio in Local Computer and Clone the repository we created for the First Part
- Clone the Repository in the default local path in RajvirChalthanwala Folder...
- Save the content in the local PC and continue with 2.1
- Create Db 2.1 step
- Build the project and look that there are no errors...
- 4 succeeded 0 failed 0 up-to-date
- Modify the 3rd line in the reviwing of appsettings.json file for the default Db connection...
- Open NuGet Package console and add the default migration with the "RajvirsBookStore" as default selected project.
- "add-migration AddDefaultIdentityMigration" add this line in the package console...
when error occurs change the default project to "RajvirBooks.DataAccess" to remove the error...
- now after running the same code it will succeeded...
- Save and update the github repo...  
08:47

08:48 -----------------
- To add the new Migration file name "20221111014238_AddDefaultIdentityMigration.cs" in RajvirsBooks.DataAccess > Data > Migrations
- Review the code of the newley created file of migrations...
- edit the code as per the pptx.
- again in the package console : "update-database" 
- in the output window it shows "build start" and "build succeeded"...
- save the content and update git...
09:02

09:17 -----------------
- as per the second page open the sqlserver object page....
- View > Sql Server Object Explorer
- open the Database > RajvirBookStore > Tables and look that all the tables are present !!!
- after looking it proceed to next step...
- Run the application withot any error...

- after running the application add the "Category.cs" file in the .Models class library...
- Modify it as per the requirement and add the public int and public string field in the same class
- add the limitations and add "[Key]" in the top of the public static file...
- save the content and update the repo....
09:26 

09:28 -----------------
- add the migration again for the new Category file.
open the package console write : "add-migration AddCategoryToDb" and enter the application...
	- Build Start
	- Build Succeeded
- again open the migration file of CategoryToDb file and look it will be empty...
- save the content and move forward.
- Edit the ApplicationDbContext.cs file
	- add the "using RajvirsBooks.Models;" to the top of the file...
	- Another add "public DbSet<Category> Categories { get; set; }" in that same file...
- save the content and then again in package console "add-migration AddCategoryToDb" !!!
- Update the database !!!
	- Build Start
	- Build Succeeded
	- Done
- Commit all to the github repository till End of Part 2.1
09:41

2022-11-12  17:40 -----------------
- open Visual Studio code 2019 Community version...
- Open the colned repository which was saved in the local folder and open the sln file.
- build the project and save it to continue Part 2.2... 
17:46

17:53 -----------------
- Added "Repository" folder in the .DataAccess class project...
- Added another implementation folder named "IRepository"
- Include one "interface" file in that folder named: "IRepository.cs"
- modify it as per pptx
- save the code and update the git commits.... 
17:58

18:07 -----------------
- further add the given code in the same interface file....
- add comments too for the further assistance
- save the code as clean the project tobe safe...
18:09

18:21 -----------------
- add the implements class in the Repository > Repository.cs file...
- add the content in that file using given code by professor...
- save the content for the further commit...
- Add two new files in the same Repository folder named: "ICategoryRepository.cs" interface file and "CategoryRepository.cs" class file
- modify the CategoryRepository.cs file as shown in the pptx...
- it's time to coomit 5 chnages in the repo...
18:35

18:40 -----------------
- Modify the code in the ICategoryRepository.cs file as shown and change the namespace...
- build the application if:
	- 4 succeeded 0 failed 0 up-to-date
	- update the git repository with the following code.
18:59

19:11 -----------------
- Create the ISP_Call.cs interface file in the .DataAccess class project
- modifyit according to the pptx...
- continue the coding and add the new class file in Repository > "SP_Call.cs"...
19:15

Took a Break !!! :)

20:10 -----------------
- After adding the SP_Call.cs file... 
- modify it using the provided file reference...
- almost added 15 lines and then finally commit it to git repo...
- save the code....
20:12

20:48 -----------------
- error occured :
"Error	CS0053	Inconsistent accessibility: property type 'ISP_Call' is less accessible than property 'UnitOfWork.SP_Call'	RajvirsBooks.DataAccess	C:\Users\rajvi\Source\Repos\RajvirChalthanwala\RajvirsBookStore\RajvirsBooks.DataAccess\Repository\UnitOfWork.cs"
- trying to solve this error !!!! :(

			Error solved whuuuuu.............
			Add "public" to all the interfaces and classes
- after solving the error commit to github...
20:57

21:58 -----------------
- open startup.cs file
- add code in line 36 about the UnitOfWork and IUnitOfWork
- remove the addRazorPages line and save the code...
- one error occured about using the database connectivity
- solved using the Alt + Ent
using the suggestion solved the error...
- Commit the code to Github repo....
21:04

Had a Dinner break in between !!!!

23:21 -----------------
- To start part 2.3 Category Crud pages...
- open the visual studio code 2019 community again and close all the current tabs open except README.txt
- continue working on the 3rd part of Assignmnet Part - 2.
- open the "RajvirsBookStore" main project
- Open Area > Admin > Controllers
	- create a new controller name : "CategoryController.cs"
	- add the using statement on the top and modify the rest of the code...
- save the code, update the github repo...
23:52

00:05 -----------------
- open Areas > Admin > View 
- create one folder "Category".
- add _viewImports.cshtml and _viewStart.cshtml files in Areas > Admin > View
- create one razor view page in the category file and insert the html code in it.
- code provided by the professor should be pasted in the gven file IndexView.cshtml
- save the code...
- Rebuild the application and Run the Project !
- After successful project update the git repository
00:13

00:16 -----------------
- open Views > Shared > _Layout.cshtml
- add one extra link for "Category" in the Content Management dropdown list...
- after adding it rebuild the code and run the application to check the navigation bar...
- commit till navigation
00:19

00:27 -----------------
- add the code for _Layout.cshtml
- to add fancy icons from the "fontawsome.com" and edit the given code from the pptx.
- re-run the application fot testing the correct icon andcontinue doing the project...
- after running the code save it to the Git!
- as an error " I only can see the color of the button but not the actual icon"
	- as a result I am going forward...
- add one category.js file in the wwwroot > js folder and look at the application...
add the code provided in the black board... Re-Run the application ?
- it is exactly as per the pptx but the icon are not displayed so....
		- I will ask professor about the icons...
		It took me much longer time for the error solving ?
- rest all completed commit till now. ;(
01:03

2022-11-13  19:02 -----------------
- open the visual studio code 2019 community
- open the clonned project
- continue with the pptx 2.3

- Error occured when running the Create Category page 
- Error Solved 20:17
Actualy the Category database table was not updated and it was showing the error...
- once I updated the database table it was successfully executed...  :)
- commit it to the repo erro solved...
20:19

20:21 -----------------
- add the @model razor in the text file in Views > Shared > _EditAndBackToListButton.cshtml
- add the js script and check the validation of the project
- open the category.js file for the delete functionality...
- modify the given code in the Delete URL in Category.js file !!!
after writing the code, run the application and commit all saying "End Of Part: 2"
20:36

---------------------------------------- [END OF PART-2] ----------------------------------------

2022-11-11  10:24 -----------------
- after completeing these Assignment part 2.1.1 and 2.2.2 move forward to 2.3.1 [Section 1]
- As usual open Visual studio code community version 2019...
- clone the pervious project and clean it on the first step...
	- 4 succeeded 0 failed 0 up-to-date
	- no errors
	- project cleaned
- run the aplication to move forward !
- Open the pptx for our reference to start, same like Category CRUD pages now we have to create New CoverType CRUD pages !!!
- Create one CoverType.cs class file in .Model Class library...
- Modiy the code by keeping just ID and Name field with respective data types...
after compelting this move forward to the covertype repository's files and UnitOfWork files interface...
before going to job lets commmit this code and start it again after coming back from work...
- Commit till CoverType.cs file...
10:35

2022-11-18  13:12 -----------------
- Open the cleaned web application to continue...
- I am back from my work to continue Assignment 2.3 Section 1
To commence with open Visual Studio 2019 community version...
- open the pptx for the reference...
create the CoverTypeRepository.cs file in Repository folder and ICoverTypeRepository.cs in IRepository folder...
- after creating the files Add the ICoverTypeRepository reference in UnitOfWork and IUnitOfWork
- once you edit the code now push it to create migration and database...
- Update database after creating the migration !
- save the content without commit to github repo...
13:22

2022-11-22  18:14 -----------------
- open the cleaned project to continue...
started the same steps as category CRUD pages and created the CoverType CRUD pages
- add the CoverType in UnitOfWork and IUnitOfWork...
- edit the code in the CoverTypeRepository.cs same as CategoryRespository.cs and add the using statement in the ApplicationDbSetContext file
make changes to the assembley references in the same file and add required statements...
after editing the code save the content and update the GIT repo....
18:18

18:23 -----------------
- Push the Covertype to database and create the migration
- write "add-migration AddCoverTypeToDb" in the package console in .Dataaccess project and enter
- after creating the migration its time to update the database and check that the table is created or not ?
- the new migration file "20221122232234_AddCoverTypeToDb.cs" got created...
- Check the View > SQL object explorer > CoverType.cs table
- save it and move forward...
18:26

20:16 -----------------
- took a break in between and now continuing with the same !!!!
- tried solving the previous errors of refrencing
- created "CoverTypeContoller" in Area > Admin > Contollers folder same as CategoryController to create the CRUD pages 
- Now going forward to create the same Index Razor View page for the Index view and the Upsert view...
- create CoverType folder in the Areas > Admin > views
- create two razor view pages "Index.cshtml" and "Upsert.cshtml"
- alter the code in both the files same as the pervious CRUD pages...
- save all the content with all 6 errors for now :(
- then update the git repository....
- I tried making the Razor View page but failed as there was 6 errors so its build failed...
- Taking another break will continue after some time !!!!
- As of now commiting the halfwork with errors
20:26

2022-11-22  23:33 -----------------
- Again continuing the code with solving the error by changing the exact code again and created the Index.cshtml 
razor view and same way creating Upsert.cshtml
- Index file is edited !!!
- creating the upsert.cshtml file in CoverType folder!
- creaste coverType.js file in the wwwroot > js folder and edit the code given perviously...
- and added the delete button and check the application after running the whole code !!!!
- update the git repo...
23:52

00:09 -----------------
- Create Product.cs class file in the .Models project
- alter the same code in the file as per provided in the pptx...
- continue ahead
- update the ApplicationDbContext.cs line about Product same as CoverType.cs
- add migration file in the .dataAccess and add the new created file name with the new name "20221123053201_addProductToDb"
- update the database in the same project...
- Checked the SEO and Product.cs database table...
- Created the addValidationToProduct migration 
- file name "20221123053348_addValidationToProduct.cs" and again update the database...

01:24 -----------------
- creating the new Product class in the Repository folder and IRepository folder and edit the code as given in the pptx...
- created the Product in UnitOFWork and IUnitOfWork with errors 
- commiting till this step and errors 10...
01:47

2022-11-23  11:04 -----------------
- Open the code again to continue with Assignment_3 section 2
- create the Product Controller and other following files in order to create CRUD pages
- update the code given in the Controller page and create one class file "ProductVM.cs" in the ViewsModel folder in .Model
- install one package of "Microsoft.AspNetCore.Mvc.ViewFeature" to all four projects and add the extra using statement in the files mentioned
- 3 errors :( of namespace Mvc does not exists which I don't know how to solve...
- update the git repository to clear all pending commits !
11:09