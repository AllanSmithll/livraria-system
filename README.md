# livraria-system

## Introduction
This application was created based on the CRUD (Create, Read, Update, and Delete) practice for building systems. It's a bookstore with the main functions of book registration, update, and deletion.

## Execution via Terminal

### Front (WebLivraria)
To run the application on localhost: `ng serve --port <Port number>` or simply `ng serve`
After that, set the "localhost:{number port}/livros" to access the book registration, update, and deletion page.

### Back (APILivraria)
To run the application, type in the terminal: `dotnet run`

## What tools were used?

### ASP.NET Core Web
<img src="https://tr.metacomplex.com/wp-content/uploads/2021/06/NET_Core_Logo.svg_.png/" alt=".NET Core" width="50" height="50">

1. With this tool, I created two classes, Livro and Autor, that would be related within the Database, since "authors write books."
2. I created a Model folder so that it was possible to migrate the information to the Database.
3. Finally, Controllers, so that the tables could be accessed by routes in the browser.

### SQL Server 2022
<img src="https://cdn-icons-png.flaticon.com/512/5968/5968306.png" alt="SQL Server" width="50" height="50">

*Default database for the project.*

### Angular

<img src="https://cdn2.iconfinder.com/data/icons/designer-skills/128/angular-512.png" alt="Angular framework" width="50" height="50">

- I created an interface just for book registration, it's on the "/livros" route of the browser.

## Conclusion

Even though it was the third time, I managed to do as much as I could. More improvements will be made as soon as possible 🙆.
