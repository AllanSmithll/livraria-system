# livraria-minsait

## Introdução
Foi criada uma aplicação baseada na prática CRUD (Create, Read, Update e Delete) de criação de sistemas. Uma livraria que tem como principais funções o cadastro, atualização e deletação de livros.

## Execução via Terminal

### Front (WebLivraria)
Para rodar a aplicação no localhost: `ng serve --port <Port number>` ou simplesmente `ng serve`
Após isso, setar o "localhost:{number port}/livros", para que acesse a página de cadastro, atualização e deletação de livros

### Back (APILivraria)
Para rodar a aplicação, digite no terminal: `dotnet run`

## Quais ferramentas foram utilizadas?

### ASP.NET Core Web
<img src="https://tr.metacomplex.com/wp-content/uploads/2021/06/NET_Core_Logo.svg_.png/" alt=".NET Core" width="50" height="50">

1. Com esta ferramenta, criei duas classes, Livro e Autor, que se relacionariam dentro do Banco de Dados, pois "autores escrevem livros".
2. Criei uma pasta Model, para que fosse possível migrar as informações para o Banco de Dados.
3. Por fim, Controllers, para que as tabelas pudessem ser acessadas por rotas no navegador.

### SQL Server 2022
<img src="https://cdn-icons-png.flaticon.com/512/5968/5968306.png" alt="SQL Server" width="50" height="50">

*Base de Dados padrão do projeto*

### Angular

<img src="https://cdn2.iconfinder.com/data/icons/designer-skills/128/angular-512.png" alt="Angular framework" width="50" height="50">

- Criei uma interface apenas para o cadastro de livros, está na rota livros do navegador "/livros"

## Conclusão

Mesmo sendo a terceira vez, consegui fazer o máximo que podia. Mais melhorias serão feitas o mais breve possível 🙆.
