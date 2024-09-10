using DoctorNearby.Persistence;
using Microsoft.EntityFrameworkCore;
using DoctorNearby.Business.Configuration;
using DoctorNearby.Business.MappingProfiles.Base;
using Newtonsoft.Json.Converters;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.Converters.Add(new StringEnumConverter()));

builder.Services.AddSwaggerGenNewtonsoftSupport();

builder.Services.ConfigureApplicationApp();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlDocPaths = new List<string> {
        builder.Configuration["XmlDocumentation:PathApi"],

    };

    foreach (var xmlDocPath in xmlDocPaths)
    {
        if (string.IsNullOrEmpty(xmlDocPath)) continue;
        if (File.Exists(xmlDocPath))
        {
            c.IncludeXmlComments(xmlDocPath);
        }
    }
  
   
});

builder.Services.AddAutoMapper(typeof(IMapper));


builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
});

builder.Services.ConfigurePersistenceApp(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
