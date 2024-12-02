## Ferramentas e frameworks para instalação:

*dotnet aspnet code-generator*  
`dotnet tool install --global dotnet-aspnet-codegenerator`

*dotnet EntityFramework*  
`dotnet tool install --global dotnet-ef`  

*EntityFrameworkCore Design*  
`dotnet add package Microsoft.EntityFrameworkCore.Design`

*EntityFrameworkCore SQLite*  
`dotnet add package Microsoft.EntityFrameworkCore.SQLite`

*VisualStudio Web CodeGenerator Design*  
`dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`

*EntityFramework Core Design*  
`dotnet add package Microsoft.EntityFrameworkCore.SqlServer`

*EntityFramework Core Tools*  
`dotnet add package Microsoft.EntityFrameworkCore.Tools`
<br/>
<br/>


## Scafolding do EntityFrame
* Cria um controller para model **Product**,
* Nome **ProductsController**, de forma assincrona usando parametros de api,
* Context **CafeteriaContext**, 
* Banco de dados **SQLite**  
`dotnet aspnet-codegenerator controller -name ProductsController -async -api -m Product -dc CafeteriaAPI.Data.CafeteriaContext -outDir Controllers --databaseProvider sqlite`
<br/>
<br/>
<br/>


## Criação e Atualização do banco de dados
*Cria o primeiro commit para migração com EntityFramework*   
`dotnet ef migrations add InitialCreate`


*Atualiza o banco de dados*   
`dotnet ef database update`