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



### Inciando


Rodando migrations




## INSTALANDO FERRAMETNAS

#### Install Migrations Tools



To install the dotnet-ef tool, run the following command:

.NET 7

dotnet tool install --global dotnet-ef

.NET 6

dotnet tool install --global dotnet-ef --version 6.*

.NET 5

dotnet tool install --global dotnet-ef --version 5.0.2

.NET Core 3

dotnet tool install --global dotnet-ef --version 3.*
