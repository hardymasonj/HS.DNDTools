global using FastEndpoints;
using HS.DNDTools.SpellPoints.Application.Providers;
using HS.DNDTools.SpellPoints.Domain.Providers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFastEndpoints();
builder.Services.AddScoped<ICharacterListProvider, TestCharacterListProvider>();
builder.Services.AddScoped<ICharacterProvider, TestCharacterProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseFastEndpoints();
app.UseHttpsRedirection();

app.Run();
