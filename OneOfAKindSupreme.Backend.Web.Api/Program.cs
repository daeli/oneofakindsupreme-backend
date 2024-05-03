using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using OneOfAKindSupreme.Backend.Infrastructure.Data.EF;
using OneOfAKindSupreme.Backend.Infrastructure.Configuration;
using OneOfAKindSupreme.Backend.UseCases.Configuration;
using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")) ;
});

builder.Services.RegisterUseCaseServices();
builder.Services.RegisterInfrastructureServices();

builder.Services.AddFastEndpoints()
    .SwaggerDocument(o =>
    {
        o.ShortSchemaNames = true;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else 
{
    app.UseDefaultExceptionHandler(); // from FastEndpoints
    app.UseHsts();
}

app.UseFastEndpoints()
    .UseSwaggerGen();

app.UseHttpsRedirection();

app.Run();
