# Pro Eventos


Criar solução
```
dotnet new sln -n ProEventos
```


Criar projeto lib
```
dotnet new classlib -n P
```

Rodar Migrations
```
dotnet ef migrations add Initial -p ProEventos.Persistence -s ProEventos.API
```


Criar banco de dados 
```
dotnet ef database update -s ProEventos.API
```