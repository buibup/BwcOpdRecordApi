# BwcOpdRecordApi

* Setup

      .NET Core Runtime 2.1.1
      .NET Core SDK 2.1.301
      
* Develop     

      ASP.NET Core 2.1
      ODBC Access Database.
      - ODBC-2017.2.1.801.0-win_x64
      Dapper mapper object. 
      
* Deploy to iis <br/>

      1. dotnet publish -c release
      2. run iisreset on server 

* If publish on Visual Studio not working, Used dotnet command publish

      dotnet publish -c release -r win10-x64
