using TravelApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;
//using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<TravelApiContext>(
    dbContextOptions => dbContextOptions
      .UseMySql(
      builder.Configuration["ConnectionStrings:DefaultConnection"], 
      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
      )
      )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.ResolveConflictingActions(x => x.Last()));

builder.Services.AddApiVersioning(opt => {
    opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1,0);
    opt.AssumeDefaultVersionWhenUnspecified = true;
    opt.ReportApiVersions = true;
    opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
      new HeaderApiVersionReader("x-version"),
      new MediaTypeApiVersionReader("x-version"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(/*options =>
    {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions.Reverse())
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        }
    }*/);
}
else
{
    app.UseHttpsRedirection();
}

// app.UseRequestLocalization(options);
// app.UseStaticFiles();
// app.UseMiddleware<LocalizerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
