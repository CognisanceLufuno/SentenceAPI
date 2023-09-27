using Microsoft.EntityFrameworkCore;
using Sentence.Application;
using Sentence.Application.Repositories;
using Sentence.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;


// Add services to the container.
builder.Services.AddDbContext<DBContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
b => b.MigrationsAssembly("Sentence.API")));
builder.Services.AddScoped<ISentenceRepository, SentenceRepository>();
builder.Services.AddScoped<IWordRepository, WordRepository>();
builder.Services.AddScoped<IWordTypeRepository, WordTypeRepository>();

builder.Services.AddScoped<IWordService, WordService>();
builder.Services.AddScoped<IWordTypeService, WordTypeService>();
builder.Services.AddScoped<ISentenceService, SentenceService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
                builder =>
                {
                    builder
                    .WithOrigins("http://localhost:3000")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
                }));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();

