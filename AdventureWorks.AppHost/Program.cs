var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Frontend>("frontend");

builder.Build().Run();
