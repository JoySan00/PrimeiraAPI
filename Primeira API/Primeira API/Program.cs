//program.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Primeira_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Adicionamos o servi�o DbContext para que o Entity Framework Core saiba como gerenciar a conex�o com o banco de dados
builder.Services.AddDbContext<AppDbContext>(Options =>
{   // Obt�m a string de conex�o definida no appsettings.json. 
    // Aqui usamos o nome "DefaultConnection", que � a chave definida em "ConnectionStrings".
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    // Configura o Entity Framework Core para usar o provedor MySQL.
    // O m�todo UseMySql requer:
    // 1. A string de conex�o.
    // 2. A vers�o do servidor MySQL para ajustar os recursos usados pelo Entity Framework Core.
    // A string de conex�o que cont�m informa��es como servidor, banco de dados, usu�rio e senha.
    Options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 41)));
});
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
