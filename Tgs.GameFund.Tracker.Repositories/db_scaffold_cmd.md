
#### insall dotnet official ef tools

```pwsh
dotnet tool install --global dotnet-ef
```

#### execute ef scaffold command

```pwsh
dotnet ef dbcontext scaffold "Host=localhost; Database=tgs; Username=tgs; Password=1qaz2wsx!@;" Npgsql.EntityFrameworkCore.PostgreSQL `
--table dbo.game_fund_transfer_trace `
--no-onconfiguring `
--namespace Tgs.GameFund.Tracker.Repositories.Entities `
--context TgsDbContext `
--context-dir Entities/Tgs `
--output-dir Entities/Tgs/Models
```
