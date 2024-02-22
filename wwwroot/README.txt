Web Application Security - CYB206
Group Name:Gamma
Lokesh Donga
GopiKrishna Thottathil
Divyanshu Sharma

2024-01-15 1600 hrs

- Fields decided:

Name (String)	
Type (String)	
Color (String)	
Comp (decimal)	
Size (String)	
Price (decimal)
Material (String)	

- Entries decided:

Scudera Ferrari Style Wallet
Gucci GG Marmont Bifold Wallet
Tom Ford Micro Grain Bifold Wallet
Balenciaga Superbusy Messenger Bag
Swissgear Anti-Theft Backpack
Ralph Lauren Ranger Backpack
Adidas Defender Duffle bag





2024-01-18 1345 hrs

- Finalized the fields to be used in the database. (Id, Name, Type, Color, Material, Compartments, Size, Price)

- Created a new Web App project "pursify" in Visual Studio, using the ASP.NET Core Web App (Model-View-Controller) template.

- Added a Model in the "Models" section, new class named "Purse.cs."

- Added scaffolding to generate CRUD pages for the "Movie" model.

- Add a new scaffolded item; in "Controllers", which creates: a purses controller: Controllers/PursesController.cs, Razor view files for Create, Delete, Details, Edit, and Index pages: Views/Purses/*.cshtml, and a database context class: Data/pursifyContext.cs.

- Created a new class "SeedData" in the Models folder, it has the data that will be used to populate the DB. 

- In the Package Manager Console (PMC), Added Migration InitialCreate (20240125095935_InitialCreate.cs) and updated database to the latest migration.

- Added search functionality to the website, added <form> tags in Views/Purses/Index.cshtml and modified Controllers/PursesController.cs.

- Added a search by genre option, by adding the class  PurseTypeV iewModel to models, updated the index view Views/Purses/Index.cshtml.

- Added new field "Material" to the model. Updated the view templates (Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml).

- Added Material field and data in SeedData.cs, in order to update te database with the new field. Build and creayed another migration "Material".

- Added validation rules to the movie model, attributes such as StringLength, MinimumLength, Required, Range, etc. in movie.cs.

- Added shortcut link at home page, modified UI.

- Added github account to visual studio, created repository and pushed the project.

Errors- 

- SQL error: Due to different data types, we fix this by correcting data types in the Model
- Naming convention was a little confusing and run into some errors
- Reasearch online for styling options for modifying UI.

2024-01-18 1801 hrs
Migration is created - 20240218235606_InitialCreate, 20240219030338_Material, 20240222165514_Initial2


2024-01-22 1335 hrs
Added a button to naviagvte to the inventory
Updated Readme and modified the seddata file with 3 more items.
Commited proect.
