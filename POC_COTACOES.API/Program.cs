using POC_COTACOES.Application;
using POC_COTACOES.Application.Extensions;
using POC_COTACOES.Application.Service;
using POC_COTACOES.Domain.Interfaces;
using POC_COTACOES.Infrastructure.External;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigurationApplicationApp();

builder.Services.AddTransient<ICotacaoService, CotacaoService>();
builder.Services.AddTransient<IExternalCotacao, ExternalCotacao>();

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
