using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApi
{
    /// <summary>
    /// Simple Demo of web application with Web.Api and Angular, 
    /// which use MS SQL, EF, .NET Core
    /// Database created by method "Code first"
    /// Written by Serge Klokov in 2019
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Loosely based on tutorial: 
    /// Asp.Net Core Web API and Angular 7 CRUD
    /// https://www.youtube.com/watch?v=fom80TujpYQ
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        // <add name = "AdventureWorks2016CTP3Entities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=LAPTOP-TVCRG0TN\MSSQLSERVER01;initial catalog=AdventureWorks2016CTP3;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" /><add name = "AdventureWorks2016CTP3Entities1" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=LAPTOP-TVCRG0TN\MSSQLSERVER01;initial catalog=AdventureWorks2016CTP3;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
    }
}
