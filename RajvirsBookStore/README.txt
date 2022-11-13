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