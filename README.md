# DatingApp
Course cet core and angular

dotnet dev-certs https --trust

#--nuget packages
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Design
#dotnet-ef
dotnet tool install --global dotnet-ef --version 5.0.4

#--used command
dotnet new sln
dotnet new ...<web api>

dotnet ef migrations add InitialCreate -o Data\Migrations 
dotnet ef database drop
dotnet ef database update

If certs fail
https://stackoverflow.com/questions/53300480/unable-to-configure-https-endpoint-no-server-certificate-was-specified-and-the/57301251#57301251