var builder = DistributedApplication.CreateBuilder(args);

var sql = builder
    .AddSqlServerContainer("sql")
    .AddDatabase("tempdb");


var apiService = builder
    .AddProject<Projects.AspireWithSentry_ApiService>("apiservice")
    .WithReference(sql);

builder.AddProject<Projects.AspireWithSentry_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
