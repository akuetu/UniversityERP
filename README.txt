dotnet tool install --global dotnet-ef

dotnet ef database drop
dotnet ef migrations remove


dotnet ef migrations add InitialCreate
dotnet ef database update

https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools
dotnet tool install dotnetsay --tool-path c:\dotnet-tools


======================= CONSOLE ==================

--drop database 

PM> Drop-Database

--remove migration

PM> remove-migration

-- first migration

PM> add-migration InitialCreate

PM> Update-Database

--- for update

PM> add-migration upgrade_Curso_Periodo
PM> update-database


 







 {
  "id": 1,
  "userId": 1,
  "documentTypeId": 1,
  "pathTypeDocument": "teste",
  "countryId": 1,
  "countyId": 1,
  "coursePeriods": [
    {
      "id": 1,
      "courseId": 5,
      "course": {
        "id": 5,
        "name": "curso1"
      },
      "periodId": 4,
      "period": {
        "id": 4,
        "name": "Periodo1"
      }
    }
  ],
  "paymentTypeId": 1,
  "pathTypePayment": "payment",
  "note": "obs"
}