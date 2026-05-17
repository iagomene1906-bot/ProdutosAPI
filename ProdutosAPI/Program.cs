using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Contexts;
using ProdutosAPI.Interfaces;
using ProdutosAPI.Repositories;
using ProdutosAPI.Services;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

// Criar string de conexão na program
string? connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");

if (string.IsNullOrEmpty(connectionString))
{
    throw new Exception("Connection string não encontrada.");
}

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra conexão com o banco (DbContext -> ProdutoContext)
builder.Services.AddDbContext<ProdutoContext>(options => options.UseSqlServer(connectionString));

// Injeção de dependências
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ProdutoService>();

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
