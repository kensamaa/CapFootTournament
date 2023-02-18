using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
//adding the presentation layer
var PresentationAssembly = typeof(Presentation.AssemblyReference).Assembly;
// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddPersistanceService(builder.Configuration);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//adding the presentation layer
builder.Services.AddControllers()
    .AddApplicationPart(PresentationAssembly);

builder.Services.AddCors(options =>
{
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("all");
app.UseHttpsRedirection();
app.UseCors("all");
app.MapControllers();


app.Run();

