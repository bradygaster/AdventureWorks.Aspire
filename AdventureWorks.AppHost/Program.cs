var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Frontend>("frontend")
       .WithExternalHttpEndpoints();

builder.Build().Run();
